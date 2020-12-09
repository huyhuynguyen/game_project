using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzie
{
    public partial class modeScreen : MetroFramework.Forms.MetroForm
    {
        public modeScreen()
        {
            InitializeComponent();
            player.Play();
            btnSpeakerOff.Visible = false;
        }
        public SoundPlayer player = new SoundPlayer(@"D:\Quizzie\music.wav");

        LoginScreen lg = new LoginScreen();
        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            lg.Show();
        }

        private void modeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            lg.Show();
        }

        private void easyButton_Click_1(object sender, EventArgs e)
        {
            easyMode easy = new easyMode();
            this.Hide();
            easy.Show();
            easy.txtMSSV.Text = txtName.Text;
            easy.txtHeart.Text = txtHeart.Text;
        }

        private void hardButton_Click_1(object sender, EventArgs e)
        {
            hardMode hard = new hardMode();
            this.Hide();
            hard.Show();
            hard.txtMSSV.Text = txtName.Text;
            hard.txtHeart.Text = txtHeart.Text;
        }

        private void btnBoard_Click(object sender, EventArgs e)
        {
            leaderBoard ld = new leaderBoard();
            ld.Show();
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

        
    }
}
