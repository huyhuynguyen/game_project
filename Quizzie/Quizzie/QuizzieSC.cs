using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quizzie
{
    public partial class QuizzieSC : MetroFramework.Forms.MetroForm
    {
        public QuizzieSC()
        {
            InitializeComponent();
        }

        private void btnServer_Click_1(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            LoginScreen client = new LoginScreen();
            client.Show();
        }
    }
}
