using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzie
{
    public partial class easyMode : MetroFramework.Forms.MetroForm
    {
        public easyMode()
        {
            InitializeComponent();
            player.Play();
            btnSpeakerOff.Visible = false;
            Thread conn = new Thread(Connect);
            conn.Start();
        }
        public SoundPlayer player = new SoundPlayer(@"D:\Quizzie\music.wav");

        TcpClient tcpClient;
        IPEndPoint ipep;
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;

        void Connect()
        {
            ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            tcpClient = new TcpClient();
            try
            {
                // Bắt đầu kết nối
                tcpClient.Connect(ipep);
                ns = tcpClient.GetStream();

                Thread receive = new Thread(Receive);
                receive.Start(tcpClient);
            }
            catch
            {
                MessageBox.Show("Server connection failed");
            }
        }

        bool ktNext = true;
        string strAns, strQuesID, strAnsID;
        void Receive(object obj)
        {
            TcpClient tcpClient = (TcpClient)obj;
            sr = new StreamReader(tcpClient.GetStream());
            sw = new StreamWriter(tcpClient.GetStream());
            ns = tcpClient.GetStream();
            sw.AutoFlush = true;
            
            while (tcpClient.Connected)
            {
                if (ktNext)
                {
                    sw.WriteLine("QUESTION");
                    sw.WriteLine("EASY");
                    sw.Flush();
                    ImageForSend ifs = new ImageForSend();
                    BinaryFormatter bf = new BinaryFormatter();
                    ifs = (ImageForSend)bf.Deserialize(ns);
                    strQuesID = ifs.quesid;
                    strAns = ifs.answer;
                    strAnsID = ifs.ansid;
                    string difficult = ifs.difficult;

                    ptbEasy1.BackgroundImage = ifs.img1;
                    ptbEasy1.Invoke(new MethodInvoker(delegate ()
                    {
                        ptbEasy1.BackgroundImageLayout = ImageLayout.Stretch;
                    }));

                    ptbEasy2.BackgroundImage = ifs.img2;
                    ptbEasy2.Invoke(new MethodInvoker(delegate ()
                    {
                        ptbEasy2.BackgroundImageLayout = ImageLayout.Stretch;
                    }));

                    txtQuesID.Invoke(new MethodInvoker(delegate ()
                    {
                        txtQuesID.Text = strQuesID;
                    }));
                    ktNext = false;
                }
            }
        }

        Button[] button_DapAn;
        Button[] button_GoiY;

        int i = 21;
        int score = 0;
        int count_button = 0;
        int count_time = 0;
        int count_skip = 0;
        int quesright = 0;
        private void btnCheckAndNext_Click_1(object sender, EventArgs e)
        {
            if (count_button == 23)
            {
                /* Kiểm tra kết quả trong listButonDapAn */
                string result = "";
                for (int i = 0; i < button_DapAn.Length; i++)
                {
                    result += button_DapAn[i].Text;
                }
                // kiểm tra với đáp án
                if (result == strAns) // vì index ở Form_Load đã +1 nên phải -1 để lấy đúng đáp án
                {
                    score += 10;
                    txtScore.Text = score.ToString();
                    quesright += 1;
                    heart += 4;
                    txtHeart.Text = heart.ToString();

                    timer1.Stop();
                    MessageBox.Show("Hết hình");

                    sw.WriteLine("ANSWER");
                    SendAnswerIDToServer sas = new SendAnswerIDToServer();
                    BinaryFormatter bf = new BinaryFormatter();
                    sas.mssv = txtMSSV.Text;
                    sas.ansid = strAnsID;
                    sas.result = result;
                    bf.Serialize(ns, sas);

                    sw = new StreamWriter(tcpClient.GetStream());
                    sw.WriteLine("END");
                    sw.WriteLine("EASY");
                    sw.WriteLine(txtMSSV.Text);
                    sw.WriteLine(txtScore.Text);
                    sw.WriteLine(txtHeart.Text);
                    sw.Flush();

                    endGame eg = new endGame();
                    eg.txtMSSV.Text = txtMSSV.Text;
                    eg.txtHeart.Text = txtHeart.Text;
                    eg.txtQuesRight.Text = quesright.ToString();
                    eg.Show();
                }
                // nếu sai
                else
                {
                    MessageBox.Show("Wrong. Do again");
                }
            }
            else
            {
                string result = "";
                for (int i = 0; i < button_DapAn.Length; i++)
                {
                    result += button_DapAn[i].Text;
                }
                // kiểm tra với đáp án
                if (result == strAns) // vì index ở Form_Load đã +1 nên phải -1 để lấy đúng đáp án
                {
                    score += 10;
                    txtScore.Text = score.ToString();
                    heart += 4;
                    txtHeart.Text = heart.ToString();
                    quesright += 1;

                    sw.WriteLine("ANSWER");
                    SendAnswerIDToServer sas = new SendAnswerIDToServer();
                    BinaryFormatter bf = new BinaryFormatter();
                    sas.mssv = txtMSSV.Text;
                    sas.ansid = strAnsID;
                    sas.result = result;
                    bf.Serialize(ns, sas);

                    ChuyenHinh();
                    timer1.Stop();
                    i = 21;
                    timer1.Start();

                    // tăng count_time và đồng thời cũng tăng count_button
                    count_button++;
                    count_time++;
                    count_skip++;
                }
                // nếu sai
                else
                {
                    MessageBox.Show("Wrong. Do again");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 0)
            {
                if (count_time == 23)
                {
                    /* Hết thời gian thì kiểm tra trong textBox bất kể sai hay đúng */
                    string result = "";
                    for (int i = 0; i < button_DapAn.Length; i++)
                    {
                        result += button_DapAn[i].Text;
                    }
                    if (result == strAns)
                    {
                        score += 10;
                        txtScore.Text = score.ToString();
                        quesright += 1;
                    }
                    else
                    {
                        result = "";
                    }

                    timer1.Stop();
                    MessageBox.Show("Hết hình");

                    sw.WriteLine("ANSWER");
                    SendAnswerIDToServer sas = new SendAnswerIDToServer();
                    BinaryFormatter bf = new BinaryFormatter();
                    sas.mssv = txtMSSV.Text;
                    sas.ansid = strAnsID;
                    sas.result = result;
                    bf.Serialize(ns, sas);

                    sw = new StreamWriter(tcpClient.GetStream());
                    sw.WriteLine("END");
                    sw.WriteLine("EASY");
                    sw.WriteLine(txtMSSV.Text);
                    sw.WriteLine(txtScore.Text);
                    sw.WriteLine(txtHeart.Text);
                    sw.Flush();

                    endGame eg = new endGame();
                    eg.txtMSSV.Text = txtMSSV.Text;
                    eg.txtHeart.Text = txtHeart.Text;
                    eg.txtQuesRight.Text = quesright.ToString();
                    eg.Show();

                }
                else //nếu chưa
                {
                    string result = "";
                    for (int i = 0; i < button_DapAn.Length; i++)
                    {
                        result += button_DapAn[i].Text;
                    }
                    if (result == strAns)
                    {
                        score += 10;
                        txtScore.Text = score.ToString();
                        quesright += 1;
                    }
                    else
                    {
                        result = "";
                    }

                    sw.WriteLine("ANSWER");
                    SendAnswerIDToServer sas = new SendAnswerIDToServer();
                    BinaryFormatter bf = new BinaryFormatter();
                    sas.mssv = txtMSSV.Text;
                    sas.ansid = strAnsID;
                    sas.result = result;
                    bf.Serialize(ns, sas);

                    // dừng timer khi i=0
                    timer1.Stop();
                    // chuyển sang hình kế tiếp
                    ChuyenHinh();
                    // set lại thời gian
                    i = 21;
                    // start lại timer
                    timer1.Start();
                    // tăng count_time và đồng thời cũng tăng count_button
                    count_time++;
                    count_button++;
                    count_skip++;
                }
            }
            else
            {
                i--;
                lb_Time.Text = i.ToString() + "s";
            }
        }
      
        private void btnSkip_Click(object sender, EventArgs e)
        {
            string result = "";
            if (count_skip == 23)
            {
                timer1.Stop();
                MessageBox.Show("Hết hình");

                sw.WriteLine("ANSWER");
                SendAnswerIDToServer sas = new SendAnswerIDToServer();
                BinaryFormatter bf = new BinaryFormatter();
                sas.mssv = txtMSSV.Text;
                sas.ansid = strAnsID;
                sas.result = result;
                bf.Serialize(ns, sas);

                sw = new StreamWriter(tcpClient.GetStream());
                sw.WriteLine("END");
                sw.WriteLine("EASY");
                sw.WriteLine(txtMSSV.Text);
                sw.WriteLine(txtScore.Text);
                sw.WriteLine(txtHeart.Text);
                sw.Flush();

                endGame eg = new endGame();
                eg.txtMSSV.Text = txtMSSV.Text;
                eg.txtHeart.Text = txtHeart.Text;
                eg.txtQuesRight.Text = quesright.ToString();
                eg.Show();
            }
            else
            {
                sw.WriteLine("ANSWER");
                SendAnswerIDToServer sas = new SendAnswerIDToServer();
                BinaryFormatter bf = new BinaryFormatter();
                sas.mssv = txtMSSV.Text;
                sas.ansid = strAnsID;
                sas.result = result;
                bf.Serialize(ns, sas);

                timer1.Stop();
                ChuyenHinh();
                i = 21;
                timer1.Start();
                count_time++;
                count_button++;
                count_skip++;
            }
        }

        int indexDapAn = 0;
        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (heart == 0)
            {
                MessageBox.Show("You are out of heart", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (heart > 0) 
            {
                heart -= 2;
                if (heart < 0)
                {
                    heart += 2;
                    MessageBox.Show("You are not enough heart", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (indexDapAn<strAns.Length)
                    {
                        button_DapAn[indexDapAn].Text = strAns.ToCharArray()[indexDapAn].ToString();
                        button_DapAn[indexDapAn].Enabled = false;
                        indexDapAn++;
                    }
                    else
                    {
                        heart += 2;
                        MessageBox.Show("Full answer");
                    }
                    txtHeart.Text = heart.ToString();
                }
            }
        }

        void ChuyenHinh()
        {
            ktNext = true;
            Thread.Sleep(1000);
            indexDapAn = 0;
            for (int i = 0; i < button_DapAn.Length; i++)
            {
                this.groupBox1.Controls.Remove(button_DapAn[i]);
            }
            PhatSinhButtonDapAn();

            // reset lại các button đã sinh ra trước đó
            for (int i = 0; i < button_GoiY.Length; i++)
            {
                this.groupBox1.Controls.Remove(button_GoiY[i]);
            }
            PhatSinhButtonGoiYDapAn();

            HienThiChuCaiLenButtonGoiY();
        }

        void PhatSinhButtonDapAn()
        {
            button_DapAn = new Button[strAns.Length];
            for (int i = 0; i < strAns.Length; i++)
            {
                button_DapAn[i] = new Button();
                if (i == 0)
                {
                    button_DapAn[i].Location = new Point(ptbEasy1.Location.X + 20, label3.Location.Y + label3.Size.Height + 20);
                }
                else
                {
                    button_DapAn[i].Location = new Point(button_DapAn[i - 1].Location.X + button_DapAn[i - 1].Size.Width + 10, button_DapAn[0].Location.Y);
                }
                button_DapAn[i].Size = new Size(35, 30);
                button_DapAn[i].FlatStyle = FlatStyle.Flat;
                button_DapAn[i].BackColor = Color.White;
                this.groupBox1.Controls.Add(button_DapAn[i]);
                button_DapAn[i].Click += Form1_Click1;
            }
        }

        // Click của ButtonDapAn
        private void Form1_Click1(object sender, EventArgs e)
        {
            for (int i = 0; i < button_GoiY.Length; i++)
            {
                if (button_GoiY[i].Visible == false && button_GoiY[i].Text == ((Button)sender).Text)
                {

                    button_GoiY[i].Visible = true;
                    break;
                }
            }
            ((Button)sender).Text = ""; // xóa text đã ấn trong button_DapAn
        }

        void PhatSinhButtonGoiYDapAn()
        {
            button_GoiY = new Button[16];
            button_GoiY[0] = new Button();
            button_GoiY[0].Location = new Point(label3.Location.X - 90, button_DapAn[0].Location.Y + button_DapAn[0].Size.Height + 30);
            button_GoiY[0].Size = new Size(44, 44);
            this.groupBox1.Controls.Add(button_GoiY[0]);
            button_GoiY[0].Click += Form1_Click; // tạo sự kiện Click bằng code

            button_GoiY[1] = new Button();
            button_GoiY[1].Location = new Point(button_GoiY[0].Location.X, button_GoiY[0].Location.Y + button_GoiY[0].Size.Height + 10);
            button_GoiY[1].Size = new Size(44, 44);
            this.groupBox1.Controls.Add(button_GoiY[1]);
            button_GoiY[1].Click += Form1_Click;

            for (int i = 2; i < button_GoiY.Length; i++)
            {
                button_GoiY[i] = new Button();
                button_GoiY[i].Location = new Point(button_GoiY[i - 2].Location.X + button_GoiY[i - 2].Size.Width + 15, button_GoiY[i - 2].Location.Y);
                button_GoiY[i].Size = new Size(44, 44);
                this.groupBox1.Controls.Add(button_GoiY[i]);
                button_GoiY[i].Click += Form1_Click;
            }
        }

        // Click của ButtonGoiYDapAn
        private void Form1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < button_DapAn.Length; i++)
            {
                if (button_DapAn[i].Text == "")
                {
                    button_DapAn[i].Text = ((Button)sender).Text; // thêm Text vào
                    button_DapAn[i].TextAlign = ContentAlignment.MiddleCenter; // chỉnh giữa
                    button_DapAn[i].BackColor = Color.White;
                    ((Button)sender).Visible = false; // ẩn button
                    break;
                }
            }
        }

        void HienThiChuCaiLenButtonGoiY()
        {
            Random rd1 = new Random();
            char[] arrGoiY = new char[16]; // tổng của arrDapAn và n(n = arrDapAn.Length) chữ random trong arrChuCai
            char[] arrDapAn = strAns.ToCharArray(); // chia từ trong đáp án thành các chữ cái rồi gộp thành mảng
            char[] arrChuCai = { 'A', 'B', 'C', 'D', 'E', 'G', 'H', 'I', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'X', 'Y' };
            int j = 0; // index của arrGoiY
            // cộng các chữ trong arrDapAn
            for (int i = 0; i < arrDapAn.Length; i++)
            {
                arrGoiY[j++] = arrDapAn[i];
            }

            // cộng các chữ trong arrChuCai
            for (int i = 0; i < arrGoiY.Length - arrDapAn.Length; i++)
            {
                int index_arrChuCai = rd1.Next(0, arrChuCai.Length);
                arrGoiY[j++] = arrChuCai[index_arrChuCai];
            }

            // lọc random trong mảng arrGoiY
            int[] chisodadung = new int[arrGoiY.Length]; // mảng các chỉ số đã random (không được trùng nhau các chỉ số)
            int l = 0; // index của mảng chisodadung
            for (int i = 0; i < button_GoiY.Length; i++)
            {
                int chiso; // chỉ số random
                int kt;  // kiểm tra trùng
                // kiểm tra nếu random trùng với các chỉ số trước đó thì random lại
                do
                {
                    kt = 0;
                    chiso = rd1.Next(0, arrGoiY.Length);
                    for (int k = 0; k < l; k++)
                    {
                        if (chiso == chisodadung[k])
                        {
                            kt = 1;
                            break;
                        }
                    }
                    if (kt == 0) // nếu không trùng
                    {
                        chisodadung[l++] = chiso; // add chiso vào mảng chisodadung
                        button_GoiY[i].Text = arrGoiY[chiso].ToString(); // hiển thị lên button
                    }
                } while (kt == 1);
            }
        }

        private void btnSpeakerOff_Click(object sender, EventArgs e)
        {
            player.Play();
            btnSpeakerOff.Visible = false;
            btnSpeakerOn.Visible = true;
        }

        private void btnSpeakerOn_CheckedChanged(object sender, EventArgs e)
        {
            player.Stop();
            btnSpeakerOn.Visible = false;
            btnSpeakerOff.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit game and save the result?", "Notification!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sw = new StreamWriter(tcpClient.GetStream());
                sw.WriteLine("END");
                sw.WriteLine("EASY");
                sw.WriteLine(txtMSSV.Text);
                sw.WriteLine(txtScore.Text);
                sw.WriteLine(txtHeart.Text);
                sw.Flush();

                modeScreen ms = new modeScreen();
                this.Hide();
                ms.txtName.Text = txtMSSV.Text;
                ms.txtHeart.Text = txtHeart.Text;
                ms.Show();
            }
        }
        int heart;
        private void easyMode_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Start");
            heart = Int32.Parse(txtHeart.Text);
            PhatSinhButtonDapAn();
            PhatSinhButtonGoiYDapAn();
            HienThiChuCaiLenButtonGoiY();
            timer1.Start();
        }

        private void easyMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnHome_Click(sender, e);
        }
    }
}
