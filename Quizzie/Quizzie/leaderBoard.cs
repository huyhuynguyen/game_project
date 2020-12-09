using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzie
{
    public partial class leaderBoard : MetroFramework.Forms.MetroForm
    {
        public leaderBoard()
        {
            InitializeComponent();
            Connect();
        }

        NetworkStream ns;
        TcpClient tcpClient;
        IPEndPoint ipep;
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
                MessageBox.Show("Không thể kết nối với server");
            }
        }

        void Receive (object obj)
        {
            tcpClient = (TcpClient)obj;
            sr = new StreamReader(tcpClient.GetStream());
            sw = new StreamWriter(tcpClient.GetStream());
            ns = tcpClient.GetStream();
            sw.AutoFlush = true;
            string content = "";
            while (tcpClient.Connected)
            {
                content = sr.ReadLine();
                if (content == "RANKE")
                {
                    LoadData(sr);
                }
                if (content == "RANKH")
                {
                    LoadData(sr);
                }
            }
        }

        void LoadData(StreamReader sr)
        {
            ltView.Invoke(new MethodInvoker(delegate ()
            {
                ltView.Columns.Add("TOP", 48);
                ltView.Columns.Add("UserID", 165);
                ltView.Columns.Add("Name", 239);
                ltView.Columns.Add("Age", 71);
                ltView.Columns.Add("Gender", 135);
                ltView.Columns.Add("Score", 69);
                ltView.Columns.Add("Heart", 69);
                ltView.View = View.Details;
            }));
            int len;
            int a = 0;
            string strUser, strAge, strName, strGender, Score, Heart;
            len = int.Parse(sr.ReadLine());
            for (int i = 0; i < len; i++)
            {
                strUser = sr.ReadLine();
                strName = sr.ReadLine();
                strAge = sr.ReadLine();
                strGender = sr.ReadLine();
                Score = sr.ReadLine();
                Heart = sr.ReadLine();
                a = i + 1;
                ltView.Invoke(new MethodInvoker(delegate ()
                {
                    ltView.Items.Add(a.ToString());
                    ltView.Items[i].SubItems.Add(strUser);
                    ltView.Items[i].SubItems.Add(strName);
                    ltView.Items[i].SubItems.Add(strAge);
                    ltView.Items[i].SubItems.Add(strGender);
                    ltView.Items[i].SubItems.Add(Score);
                    ltView.Items[i].SubItems.Add(Heart);
                }));
            }
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            ltView.Clear();
            sw = new StreamWriter(tcpClient.GetStream());
            sw.WriteLine("RANKE");
            sw.Flush();
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            ltView.Clear();
            sw = new StreamWriter(tcpClient.GetStream());
            sw.WriteLine("RANKH");
            sw.Flush();
        }

        private void pbxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
