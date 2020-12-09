using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Quizzie
{
    public partial class LoginScreen : MetroFramework.Forms.MetroForm
    { 
        public LoginScreen()
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
                MessageBox.Show("Server connection failed!", "Notification!", MessageBoxButtons.OK);
            }
        }

        public string Gender, Name, MSSV, Age;
        public int ScoreH, ScoreE, Heart;
        void Receive(object obj)
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
                ScoreH = Int32.Parse(sr.ReadLine());
                ScoreE = Int32.Parse(sr.ReadLine());
                Heart = Int32.Parse(sr.ReadLine());
                string t = "\t" + "ScoreH = " + ScoreH + "\n\t" + "ScoreE = " + ScoreE + "\n\t" + "Heart= " + Heart;
                if (content == "EXISTS")
                {
                    MessageBox.Show("MSSV HAVE EXISTED. You can continue play! \n" + t, "MESSAGE", MessageBoxButtons.OK);
                }
                if (content == "NEW")
                {
                    MessageBox.Show("NEW ACCOUNT. You can play right now! \n" + t, "MESSAGE", MessageBoxButtons.OK);
                }
            }
        }

        bool kt = false;
        private void checkButton_Click(object sender, EventArgs e)
        {
            if ((txtFirstName.Text == "") || (txtLastName.Text == "") || (txtMSSV.Text == ""))
            {
                MessageBox.Show("Please fill in the blank!", "Notification!", MessageBoxButtons.OK);
            }
            else
            {
                int age;
                try
                {
                    age = Int32.Parse(txtAge.Text);
                    if (age<0 || age>100)
                    {
                        MessageBox.Show("Age from 0->100", "Notification!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        resultGrid.Text += "Player: " + txtFirstName.Text.Trim().ToUpper() + " " + txtLastName.Text.Trim().ToUpper() + "\n" +
                                      txtAge.Text.Trim() + "  years old" + "\n" + "MSSV: " + txtMSSV.Text + "\n";
                        if (maleTick.Checked)
                        {
                            resultGrid.Text += maleTick.Text + "\n";
                            Gender = maleTick.Text;
                        }
                        if (femaleTick.Checked)
                        {
                            resultGrid.Text += femaleTick.Text + "\n";
                            Gender = femaleTick.Text;
                        }
                        if (ratherNotSayTick.Checked)
                        {
                            resultGrid.Text += ratherNotSayTick.Text + "\n";
                            Gender = ratherNotSayTick.Text;
                        }
                        MessageBox.Show("SUCCESS!", "Notification!", MessageBoxButtons.OK);
                        kt = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter age as integer number", "Notification!", MessageBoxButtons.OK);
                }
            }
        }

        bool ktsubmit = false;
        private void submitButton_Click(object sender, EventArgs e)
        {
            // Kiểm tra tài khoảng hoặc đk mới
            NetworkStream ns = tcpClient.GetStream();
            sw = new StreamWriter(ns);
            if (kt == false)
            {
                MessageBox.Show("Press Check before Submit!", "Notification!");
            }
            else
            {
                ktsubmit = true;
                Name = txtLastName.Text + txtFirstName.Text;
                MSSV = txtMSSV.Text.Trim();
                Age = txtAge.Text;

                sw.WriteLine("LOGIN");
                sw.WriteLine(MSSV);
                sw.WriteLine(Name);
                sw.WriteLine(Age);
                sw.WriteLine(Gender);
                sw.Flush();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (ktsubmit)
            {
                modeScreen ms = new modeScreen();
                this.Hide();
                ms.Show();
                ms.txtName.Text = MSSV;
                ms.txtHeart.Text = Heart.ToString();
            }
            else
            {
                MessageBox.Show("Press Submit before Start!", "Notification!");
            }
        }
    }
}
