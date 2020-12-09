namespace Quizzie
{
    partial class modeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modeScreen));
            this.logoutButton = new System.Windows.Forms.Button();
            this.btnBoard = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHeart = new System.Windows.Forms.TextBox();
            this.hardButton = new MetroFramework.Controls.MetroButton();
            this.easyButton = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.leaderBoardButton = new System.Windows.Forms.Button();
            this.btnSpeakerOn = new System.Windows.Forms.CheckBox();
            this.btnSpeakerOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.SandyBrown;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(570, 377);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(123, 40);
            this.logoutButton.TabIndex = 52;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // btnBoard
            // 
            this.btnBoard.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoard.ForeColor = System.Drawing.Color.White;
            this.btnBoard.Location = new System.Drawing.Point(83, 377);
            this.btnBoard.Margin = new System.Windows.Forms.Padding(2);
            this.btnBoard.Name = "btnBoard";
            this.btnBoard.Size = new System.Drawing.Size(143, 40);
            this.btnBoard.TabIndex = 51;
            this.btnBoard.Text = "LeaderBoard";
            this.btnBoard.UseVisualStyleBackColor = false;
            this.btnBoard.Click += new System.EventHandler(this.btnBoard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 28);
            this.label3.TabIndex = 50;
            this.label3.Text = "User:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(83, 50);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(122, 36);
            this.txtName.TabIndex = 49;
            // 
            // txtHeart
            // 
            this.txtHeart.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeart.Location = new System.Drawing.Point(581, 50);
            this.txtHeart.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeart.Name = "txtHeart";
            this.txtHeart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHeart.Size = new System.Drawing.Size(59, 36);
            this.txtHeart.TabIndex = 48;
            // 
            // hardButton
            // 
            this.hardButton.AutoSize = true;
            this.hardButton.BackColor = System.Drawing.Color.Orange;
            this.hardButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.hardButton.ForeColor = System.Drawing.Color.White;
            this.hardButton.Location = new System.Drawing.Point(267, 270);
            this.hardButton.Margin = new System.Windows.Forms.Padding(2);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(212, 64);
            this.hardButton.Style = MetroFramework.MetroColorStyle.Red;
            this.hardButton.TabIndex = 44;
            this.hardButton.Text = "HARD";
            this.hardButton.UseCustomBackColor = true;
            this.hardButton.UseCustomForeColor = true;
            this.hardButton.UseSelectable = true;
            this.hardButton.UseStyleColors = true;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click_1);
            // 
            // easyButton
            // 
            this.easyButton.AutoSize = true;
            this.easyButton.BackColor = System.Drawing.Color.Yellow;
            this.easyButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.easyButton.ForeColor = System.Drawing.Color.Black;
            this.easyButton.Location = new System.Drawing.Point(267, 178);
            this.easyButton.Margin = new System.Windows.Forms.Padding(2);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(212, 64);
            this.easyButton.Style = MetroFramework.MetroColorStyle.Green;
            this.easyButton.TabIndex = 43;
            this.easyButton.Text = "EASY";
            this.easyButton.UseCustomBackColor = true;
            this.easyButton.UseCustomForeColor = true;
            this.easyButton.UseSelectable = true;
            this.easyButton.UseStyleColors = true;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Location = new System.Drawing.Point(203, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 57);
            this.label6.TabIndex = 42;
            this.label6.Text = "Select Your Mode";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(539, 49);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 39);
            this.button3.TabIndex = 47;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // leaderBoardButton
            // 
            this.leaderBoardButton.BackColor = System.Drawing.Color.White;
            this.leaderBoardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaderBoardButton.ForeColor = System.Drawing.Color.White;
            this.leaderBoardButton.Image = ((System.Drawing.Image)(resources.GetObject("leaderBoardButton.Image")));
            this.leaderBoardButton.Location = new System.Drawing.Point(31, 353);
            this.leaderBoardButton.Margin = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.leaderBoardButton.Name = "leaderBoardButton";
            this.leaderBoardButton.Size = new System.Drawing.Size(56, 64);
            this.leaderBoardButton.TabIndex = 46;
            this.leaderBoardButton.UseVisualStyleBackColor = false;
            // 
            // btnSpeakerOn
            // 
            this.btnSpeakerOn.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnSpeakerOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeakerOn.ForeColor = System.Drawing.Color.White;
            this.btnSpeakerOn.Image = ((System.Drawing.Image)(resources.GetObject("btnSpeakerOn.Image")));
            this.btnSpeakerOn.Location = new System.Drawing.Point(652, 34);
            this.btnSpeakerOn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpeakerOn.Name = "btnSpeakerOn";
            this.btnSpeakerOn.Size = new System.Drawing.Size(69, 69);
            this.btnSpeakerOn.TabIndex = 73;
            this.btnSpeakerOn.UseVisualStyleBackColor = true;
            this.btnSpeakerOn.CheckedChanged += new System.EventHandler(this.btnSpeakerOn_CheckedChanged);
            // 
            // btnSpeakerOff
            // 
            this.btnSpeakerOff.BackColor = System.Drawing.Color.White;
            this.btnSpeakerOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeakerOff.ForeColor = System.Drawing.Color.White;
            this.btnSpeakerOff.Image = ((System.Drawing.Image)(resources.GetObject("btnSpeakerOff.Image")));
            this.btnSpeakerOff.Location = new System.Drawing.Point(652, 34);
            this.btnSpeakerOff.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpeakerOff.Name = "btnSpeakerOff";
            this.btnSpeakerOff.Size = new System.Drawing.Size(69, 69);
            this.btnSpeakerOff.TabIndex = 74;
            this.btnSpeakerOff.UseVisualStyleBackColor = false;
            this.btnSpeakerOff.Click += new System.EventHandler(this.btnSpeakerOff_Click);
            // 
            // modeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.btnSpeakerOff);
            this.Controls.Add(this.btnSpeakerOn);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.btnBoard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtHeart);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.leaderBoardButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.label6);
            this.Name = "modeScreen";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button btnBoard;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtHeart;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button leaderBoardButton;
        private MetroFramework.Controls.MetroButton hardButton;
        private MetroFramework.Controls.MetroButton easyButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox btnSpeakerOn;
        private System.Windows.Forms.Button btnSpeakerOff;
    }
}