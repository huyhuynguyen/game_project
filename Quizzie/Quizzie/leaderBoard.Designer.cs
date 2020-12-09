namespace Quizzie
{
    partial class leaderBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(leaderBoard));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hardButton = new System.Windows.Forms.Button();
            this.easyButton = new System.Windows.Forms.Button();
            this.pbxHome = new System.Windows.Forms.PictureBox();
            this.ltView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(242, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 57);
            this.label6.TabIndex = 13;
            this.label6.Text = "LEADERBOARD";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(829, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // hardButton
            // 
            this.hardButton.BackColor = System.Drawing.Color.White;
            this.hardButton.Font = new System.Drawing.Font("Segoe Print", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.hardButton.Location = new System.Drawing.Point(591, 81);
            this.hardButton.Margin = new System.Windows.Forms.Padding(2);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(146, 46);
            this.hardButton.TabIndex = 17;
            this.hardButton.Text = "Hard Mode";
            this.hardButton.UseVisualStyleBackColor = false;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.Color.White;
            this.easyButton.Font = new System.Drawing.Font("Segoe Print", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.easyButton.Location = new System.Drawing.Point(121, 81);
            this.easyButton.Margin = new System.Windows.Forms.Padding(2);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(146, 46);
            this.easyButton.TabIndex = 18;
            this.easyButton.Text = "Easy Mode";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // pbxHome
            // 
            this.pbxHome.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxHome.ErrorImage")));
            this.pbxHome.Image = ((System.Drawing.Image)(resources.GetObject("pbxHome.Image")));
            this.pbxHome.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxHome.InitialImage")));
            this.pbxHome.Location = new System.Drawing.Point(17, 14);
            this.pbxHome.Margin = new System.Windows.Forms.Padding(2);
            this.pbxHome.Name = "pbxHome";
            this.pbxHome.Size = new System.Drawing.Size(48, 48);
            this.pbxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHome.TabIndex = 71;
            this.pbxHome.TabStop = false;
            this.pbxHome.Click += new System.EventHandler(this.pbxHome_Click);
            // 
            // ltView
            // 
            this.ltView.HideSelection = false;
            this.ltView.Location = new System.Drawing.Point(31, 132);
            this.ltView.Name = "ltView";
            this.ltView.Size = new System.Drawing.Size(801, 325);
            this.ltView.TabIndex = 72;
            this.ltView.UseCompatibleStateImageBehavior = false;
            this.ltView.View = System.Windows.Forms.View.Details;
            // 
            // leaderBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 489);
            this.Controls.Add(this.ltView);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.pbxHome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "leaderBoard";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.PictureBox pbxHome;
        private System.Windows.Forms.ListView ltView;
    }
}