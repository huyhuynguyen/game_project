using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzie
{
    public partial class endGame : MetroFramework.Forms.MetroForm
    {
        public endGame()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            modeScreen ms = new modeScreen();
            this.Hide();
            ms.Show();
            ms.txtName.Text = txtMSSV.Text;
            ms.txtHeart.Text = txtHeart.Text;
        }
    }
}
