using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzie
{
    public partial class Server : MetroFramework.Forms.MetroForm
    {
        public Server()
        {
            InitializeComponent();
            Thread thread = new Thread(serverThread);
            thread.Start();
        }

        // Tạo list các socket client kết nối tới server
        //List<Socket> clientList = new List<Socket>();

        void serverThread()
        {
            try
            {
                // Tạo Endpoint
                IPEndPoint ipServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                TcpListener listener = new TcpListener(ipServer);
                listener.Start();
                while (true)
                {
                    TcpClient tcpClient = listener.AcceptTcpClient();
                    //AddMessage("New client connected");

                    Thread process = new Thread(Process);
                    process.Start(tcpClient);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table, tableUser;
        List<int> list = new List<int>(); // List những câu hỏi đã đươc trả lời

        private void Process(object obj)
        {
            TcpClient tcpClient = (TcpClient)obj;
            StreamReader sr = new StreamReader(tcpClient.GetStream());
            StreamWriter sw = new StreamWriter(tcpClient.GetStream());
            NetworkStream ns = tcpClient.GetStream();
            sw.AutoFlush = true;
            string strRequest = "";

            while (tcpClient.Connected)
            {
                strRequest = sr.ReadLine();
                if (strRequest == "LOGIN")
                {
                    if (LoginCheck(sr, sw))
                    {
                        sw.WriteLine("NEW");
                        sw.WriteLine(ScoreH);
                        sw.WriteLine(ScoreE);
                        sw.WriteLine(Heart);
                    }
                    else
                    {
                        sw.WriteLine("EXISTS");
                        sw.WriteLine(ScoreH);
                        sw.WriteLine(ScoreE);
                        sw.WriteLine(Heart);
                    }
                    sw.Flush();
                }
                if (strRequest == "QUESTION")
                {
                    string requestAtMode = sr.ReadLine();
                    if (requestAtMode == "HARD")
                    {
                        SendDataHardQuestion(ns);
                    }
                    else if (requestAtMode == "EASY")
                    {
                        SendDataEasyQuestion(ns);
                    }
                }
                if (strRequest == "RANKE")
                {
                    LeaderBoardEasy(sw);
                }
                if (strRequest == "RANKH")
                {
                    LeaderBoardHard(sw);
                }
                if (strRequest == "END")
                {
                    EndGame(sr, sw);
                }

                if (strRequest== "ANSWER")
                {
                    SendAnswerIDToServer sa = new SendAnswerIDToServer();
                    BinaryFormatter bf = new BinaryFormatter();
                    sa = (SendAnswerIDToServer)bf.Deserialize(ns);
                    strMSSV = sa.mssv;
                    string strAnsID = sa.ansid;
                    string strContent = sa.result;
                    InsertUserAnswer(ns, strMSSV, strAnsID, strContent);
                }
            }
        }

        string strMSSV, strName, strAge, strGender;
        int ScoreH = 0, ScoreE = 0, Heart = 10;
        // Hàm kiểm tra tài khoản
        private bool LoginCheck(StreamReader sr, StreamWriter sw)
        {
            bool check = false;
            string queryUser = "select * from Users";
            using (connection = new SqlConnection(Program.connectstring))
            {
                connection.Open(); // Mở kết nối database
                command = new SqlCommand(queryUser, connection);
                tableUser = new DataTable();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(tableUser);

                // Đoc các dữ liệu trong NetworkStream
                strMSSV = sr.ReadLine();
                strName = sr.ReadLine();
                strAge = sr.ReadLine();
                strGender = sr.ReadLine();
                // Kiểm tra trong table có tồn tại tài khoảng hay chưa
                for (int i = 0; i < tableUser.Rows.Count; i++)
                {
                    string sqlMSSV = tableUser.Rows[i]["UserID"].ToString();
                    if (strMSSV == sqlMSSV) // MSSV giống nhau => Đã tồn tại
                    {
                        check = true;
                        strMSSV = tableUser.Rows[i]["UserID"].ToString();
                        strName = tableUser.Rows[i]["Name"].ToString();
                        strAge = tableUser.Rows[i]["Age"].ToString();
                        strGender = tableUser.Rows[i]["Gender"].ToString();
                        ScoreH = Int32.Parse(tableUser.Rows[i]["ScoreH"].ToString());
                        ScoreE = Int32.Parse(tableUser.Rows[i]["ScoreE"].ToString());
                        Heart = Int32.Parse(tableUser.Rows[i]["Heart"].ToString());
                        break;
                    }
                }
                if (check == true)
                {
                    return false;
                }
                // Nếu chưa tồn tại thì tạo mới
                command = new SqlCommand("Insert into Users values (@UserID, @Name, @Age, @Gender, @ScoreH, @ScoreE, @Heart)", connection);
                command.Parameters.AddWithValue("@UserID", strMSSV);
                command.Parameters.AddWithValue("@Name", strName);
                command.Parameters.AddWithValue("@Age", strAge);
                command.Parameters.AddWithValue("@Gender", strGender);
                command.Parameters.AddWithValue("@ScoreH", ScoreH);
                command.Parameters.AddWithValue("@ScoreE", ScoreH);
                command.Parameters.AddWithValue("@Heart", Heart);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
        }

        int hardindex = 46;
        // Gửi câu hỏi
        private void SendDataHardQuestion(NetworkStream ns)
        {
            int j;
            string strQuesID, strDiff, strAns, strAnsID;
            byte[] data1, data2;
            string query = "select Question.QuesID, Difficulty, Img, Answer.Acontent, Answer.AnsID from Question, Answer where Question.QuesID = Answer.QuesID";
            using (connection = new SqlConnection(Program.connectstring))
            {
                int x = BlackList(strMSSV, "hard");
                if (x == 0)
                    hardindex = 46;
                else
                    hardindex = x - 1;

                connection.Open();
                command = new SqlCommand(query, connection);
                table = new DataTable();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(table);

                // Vị trí sẽ lấy ảnh trong database
                hardindex += 2;
                j = hardindex + 1;
                if (hardindex < 100)
                {
                    // Lấy các dữ liệu của câu hỏi từ table
                    strQuesID = table.Rows[hardindex]["QuesID"].ToString();
                    strDiff = table.Rows[hardindex]["Difficulty"].ToString();
                    strAns = table.Rows[hardindex]["Acontent"].ToString();
                    strAnsID = table.Rows[hardindex]["AnsID"].ToString();
                    data1 = (byte[])table.Rows[hardindex]["Img"];
                    data2 = (byte[])table.Rows[j]["Img"];
                    MemoryStream ms1 = new MemoryStream(data1);
                    MemoryStream ms2 = new MemoryStream(data2);

                    ImageForSend ifs = new ImageForSend();
                    BinaryFormatter bf = new BinaryFormatter();
                    ifs.quesid = strQuesID;
                    ifs.difficult = strDiff;
                    ifs.answer = strAns;
                    ifs.ansid = strAnsID;
                    ifs.img1 = Image.FromStream(ms1);
                    ifs.img2 = Image.FromStream(ms2);
                    bf.Serialize(ns, ifs);
                }
                connection.Close();
            }
        }

        int easyindex = -2;
        private void SendDataEasyQuestion(NetworkStream ns)
        {
            
            int j;
            string strQuesID, strDiff, strAns, strAnsID;
            byte[] data1, data2;
            string query = "select Question.QuesID, Difficulty, Img, Acontent, AnsID from Question, Answer where Question.QuesID = Answer.QuesID";
            using (connection = new SqlConnection(Program.connectstring))
            {
                int x = BlackList(strMSSV, "easy");
                if (x == 0)
                    easyindex = -2;
                else
                    easyindex = x - 1;

                connection.Open();
                command = new SqlCommand(query, connection);
                table = new DataTable();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(table);

                easyindex += 2;
                j = easyindex + 1;
                if (easyindex <= 47)
                {
                    // Lấy các dữ liệu của câu hỏi từ table
                    strQuesID = table.Rows[easyindex]["QuesID"].ToString();
                    strDiff = table.Rows[easyindex]["Difficulty"].ToString();
                    strAns = table.Rows[easyindex]["Acontent"].ToString();
                    strAnsID = table.Rows[easyindex]["AnsID"].ToString();
                    data1 = (byte[])table.Rows[easyindex]["Img"];
                    data2 = (byte[])table.Rows[j]["Img"];

                    MemoryStream ms1 = new MemoryStream(data1);
                    MemoryStream ms2 = new MemoryStream(data2);

                    ImageForSend ifs = new ImageForSend();
                    BinaryFormatter bf = new BinaryFormatter();
                    ifs.quesid = strQuesID;
                    ifs.difficult = strDiff;
                    ifs.answer = strAns;
                    ifs.ansid = strAnsID;
                    ifs.img1 = Image.FromStream(ms1);
                    ifs.img2 = Image.FromStream(ms2);
                    bf.Serialize(ns, ifs);
                }
                connection.Close();
            }
        }

        private void LeaderBoardHard(StreamWriter sw)
        {
            using (connection = new SqlConnection(Program.connectstring))
            {
                connection.Open();
                string queryH = "select UserID, Name, Age, Gender, ScoreH, Heart from Users order by ScoreH Desc";
                command = new SqlCommand(queryH, connection);
                table = new DataTable();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                int len = table.Rows.Count;
                sw.WriteLine("RANKH");
                sw.WriteLine(len.ToString());
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    sw.WriteLine(table.Rows[i]["UserID"].ToString());
                    sw.WriteLine(table.Rows[i]["Name"].ToString());
                    sw.WriteLine(table.Rows[i]["Age"].ToString());
                    sw.WriteLine(table.Rows[i]["Gender"].ToString());
                    sw.WriteLine(table.Rows[i]["ScoreH"].ToString());
                    sw.WriteLine(table.Rows[i]["Heart"].ToString());
                }
                sw.Flush();
            }
        }

        private void LeaderBoardEasy(StreamWriter sw)
        {
            using (connection = new SqlConnection(Program.connectstring))
            {
                connection.Open();
                string queryE = "select UserID, Name, Age, Gender, ScoreE, Heart from Users order by ScoreE Desc";
                command = new SqlCommand(queryE, connection);
                table = new DataTable();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                int len = table.Rows.Count;
                sw.WriteLine("RANKE");
                sw.WriteLine(len.ToString());
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    sw.WriteLine(table.Rows[i]["UserID"].ToString());
                    sw.WriteLine(table.Rows[i]["Name"].ToString());
                    sw.WriteLine(table.Rows[i]["Age"].ToString());
                    sw.WriteLine(table.Rows[i]["Gender"].ToString());
                    sw.WriteLine(table.Rows[i]["ScoreE"].ToString());
                    sw.WriteLine(table.Rows[i]["Heart"].ToString());
                }
                sw.Flush();
            }
        }

        // Cập nhật Score vào database
        private void EndGame(StreamReader sr, StreamWriter sw)
        {
            using (connection = new SqlConnection(Program.connectstring))
            {
                connection.Open();
                string content = sr.ReadLine();
                if (content == "EASY")
                {
                    strMSSV = sr.ReadLine();
                    ScoreE += Int32.Parse(sr.ReadLine());
                    Heart = Int32.Parse(sr.ReadLine());

                    command = new SqlCommand("update Users set ScoreE = @ScoreE, Heart = @Heart where UserID = @UserID", connection);
                    command.Parameters.AddWithValue("@ScoreE", ScoreE);
                    command.Parameters.AddWithValue("@Heart", Heart);
                    command.Parameters.AddWithValue("@UserID", strMSSV);
                    command.ExecuteNonQuery();
                }
                if (content == "HARD")
                {
                    strMSSV = sr.ReadLine();
                    ScoreH += Int32.Parse(sr.ReadLine());
                    Heart = Int32.Parse(sr.ReadLine());

                    command = new SqlCommand("update Users set ScoreH = @ScoreH, Heart = @Heart where UserID = @UserID", connection);
                    command.Parameters.AddWithValue("@ScoreH", ScoreH);
                    command.Parameters.AddWithValue("@Heart", Heart);
                    command.Parameters.AddWithValue("@UserID", strMSSV);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        // Cập nhật các câu User trl được vào database
        private void InsertUserAnswer(NetworkStream ns, string strMSSV, string strAnsID, string strContent)
        {
            using (connection = new SqlConnection(Program.connectstring))
            {
                connection.Open();
                command = new SqlCommand("insert into User_Answer values (@AnsID, @UserID, @Ucontent)", connection);
                command.Parameters.AddWithValue("@AnsID", strAnsID);
                command.Parameters.AddWithValue("@UserID", strMSSV);
                command.Parameters.AddWithValue("@Ucontent", strContent);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        // Kiểm tra những câu User đã trả lời
        private int BlackList(string MSSV, string mode)
        {
            int x = 0;
            using (var connection = new SqlConnection(Program.connectstring))
            {
                connection.Open();
                command = new SqlCommand("select  User_Answer.UserID, User_Answer.AnsID, User_Answer.UContent, Answer.QuesID " +
                    "from User_Answer, Answer " +
                    "where User_Answer.AnsID = Answer.AnsID and User_Answer.UserID = @MSSV", connection);
                command.Parameters.AddWithValue("@MSSV", MSSV);
                command.ExecuteNonQuery();
                table = new DataTable();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(table);

                string ansid;
                int idE, idH;
                int maxE = 0;
                int a = table.Rows.Count;
                if (mode=="easy")
                {
                    bool ktEasy = false;
                    for (int i = 0; i < a; i++)
                    {
                        ansid = table.Rows[i]["AnsID"].ToString();
                        idE = Int32.Parse(ansid.Substring(2));
                        if (i == 0 && idE == 49)
                        {
                            ktEasy = true;
                            break;
                        }
                        if (idE > 0 && idE < 49)
                        {
                            if (idE > maxE)
                                maxE = idE;
                        }
                        if ((maxE > 0 && maxE < 49) && (idE > 48))
                        {
                            break;
                        } 
                    }
                    if (maxE==47)
                    {
                        maxE = 0;
                        command = new SqlCommand("delete from User_Answer where User_Answer.UserID = @MSSV", connection);
                        command.Parameters.AddWithValue("@MSSV", MSSV);
                        command.ExecuteNonQuery();
                    }
                    if (ktEasy)
                    {
                        maxE = 0;
                    }
                    x = maxE;
                }
                else if (mode=="hard")
                {
                    if (a == 0)
                        x = 0;
                    else
                    {
                        ansid = table.Rows[a - 1]["AnsID"].ToString();
                        idH = Int32.Parse(ansid.Substring(2));
                        if (idH == 99)
                        {
                            x = 0;
                            command = new SqlCommand("delete from User_Answer where User_Answer.UserID = @MSSV", connection);
                            command.Parameters.AddWithValue("@MSSV", MSSV);
                            command.ExecuteNonQuery();
                        }
                        else if (idH > 48 && idH < 101)
                            x = idH;
                    }
                }
            }
            return x;
        }
    }
}