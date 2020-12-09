namespace Quizzie
{
    partial class hardMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hardMode));
            this.label6 = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Time = new System.Windows.Forms.Label();
            this.btnCheckAndNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ptbHard2 = new System.Windows.Forms.PictureBox();
            this.ptbHard1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuesID = new System.Windows.Forms.TextBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.txtHeart = new System.Windows.Forms.TextBox();
            this.btnSpeakerOff = new System.Windows.Forms.Button();
            this.btnSpeakerOn = new System.Windows.Forms.CheckBox();
            this.ptbSkip = new System.Windows.Forms.PictureBox();
            this.ptbHome = new System.Windows.Forms.PictureBox();
            this.ptbHelp = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 53);
            this.label6.TabIndex = 18;
            this.label6.Text = "HARD MODE";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(84, 269);
            this.txtScore.Margin = new System.Windows.Forms.Padding(2);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(79, 34);
            this.txtScore.TabIndex = 54;
            this.txtScore.Text = "0";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.Location = new System.Drawing.Point(84, 139);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.ReadOnly = true;
            this.txtMSSV.Size = new System.Drawing.Size(79, 34);
            this.txtMSSV.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 28);
            this.label3.TabIndex = 52;
            this.label3.Text = "Ques:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 55;
            this.label4.Text = "Score:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 57;
            this.label1.Text = "Time:";
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.Location = new System.Drawing.Point(83, 330);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(40, 26);
            this.lb_Time.TabIndex = 58;
            this.lb_Time.Text = "20s";
            // 
            // btnCheckAndNext
            // 
            this.btnCheckAndNext.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCheckAndNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAndNext.ForeColor = System.Drawing.Color.White;
            this.btnCheckAndNext.Location = new System.Drawing.Point(296, 566);
            this.btnCheckAndNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckAndNext.Name = "btnCheckAndNext";
            this.btnCheckAndNext.Size = new System.Drawing.Size(147, 48);
            this.btnCheckAndNext.TabIndex = 57;
            this.btnCheckAndNext.Text = "Check And Next";
            this.btnCheckAndNext.UseVisualStyleBackColor = false;
            this.btnCheckAndNext.Click += new System.EventHandler(this.btnCheckAndNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ptbHard2);
            this.groupBox1.Controls.Add(this.btnCheckAndNext);
            this.groupBox1.Controls.Add(this.ptbHard1);
            this.groupBox1.Location = new System.Drawing.Point(187, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(747, 638);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(232, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 24);
            this.label5.TabIndex = 59;
            this.label5.Text = "ĐÂY LÀ GÌ / CHỮ GÌ/ CÁI GÌ ?";
            // 
            // ptbHard2
            // 
            this.ptbHard2.BackColor = System.Drawing.Color.White;
            this.ptbHard2.Location = new System.Drawing.Point(384, 17);
            this.ptbHard2.Margin = new System.Windows.Forms.Padding(2);
            this.ptbHard2.Name = "ptbHard2";
            this.ptbHard2.Size = new System.Drawing.Size(349, 312);
            this.ptbHard2.TabIndex = 58;
            this.ptbHard2.TabStop = false;
            // 
            // ptbHard1
            // 
            this.ptbHard1.BackColor = System.Drawing.Color.White;
            this.ptbHard1.Location = new System.Drawing.Point(19, 17);
            this.ptbHard1.Margin = new System.Windows.Forms.Padding(2);
            this.ptbHard1.Name = "ptbHard1";
            this.ptbHard1.Size = new System.Drawing.Size(349, 312);
            this.ptbHard1.TabIndex = 18;
            this.ptbHard1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 28);
            this.label2.TabIndex = 59;
            this.label2.Text = "User:";
            // 
            // txtQuesID
            // 
            this.txtQuesID.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuesID.Location = new System.Drawing.Point(84, 202);
            this.txtQuesID.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuesID.Name = "txtQuesID";
            this.txtQuesID.ReadOnly = true;
            this.txtQuesID.Size = new System.Drawing.Size(79, 34);
            this.txtQuesID.TabIndex = 60;
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSkip.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.ForeColor = System.Drawing.Color.Black;
            this.btnSkip.Location = new System.Drawing.Point(1017, 292);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(2);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(72, 47);
            this.btnSkip.TabIndex = 67;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(1017, 368);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(72, 48);
            this.btnHome.TabIndex = 65;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Gold;
            this.btnHelp.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Location = new System.Drawing.Point(1017, 213);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(72, 48);
            this.btnHelp.TabIndex = 63;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // txtHeart
            // 
            this.txtHeart.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeart.Location = new System.Drawing.Point(1017, 141);
            this.txtHeart.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeart.Multiline = true;
            this.txtHeart.Name = "txtHeart";
            this.txtHeart.ReadOnly = true;
            this.txtHeart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHeart.Size = new System.Drawing.Size(72, 40);
            this.txtHeart.TabIndex = 62;
            // 
            // btnSpeakerOff
            // 
            this.btnSpeakerOff.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSpeakerOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeakerOff.ForeColor = System.Drawing.Color.White;
            this.btnSpeakerOff.Image = ((System.Drawing.Image)(resources.GetObject("btnSpeakerOff.Image")));
            this.btnSpeakerOff.Location = new System.Drawing.Point(988, 62);
            this.btnSpeakerOff.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpeakerOff.Name = "btnSpeakerOff";
            this.btnSpeakerOff.Size = new System.Drawing.Size(69, 69);
            this.btnSpeakerOff.TabIndex = 76;
            this.btnSpeakerOff.UseVisualStyleBackColor = false;
            this.btnSpeakerOff.Click += new System.EventHandler(this.btnSpeakerOff_Click);
            // 
            // btnSpeakerOn
            // 
            this.btnSpeakerOn.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnSpeakerOn.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSpeakerOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeakerOn.ForeColor = System.Drawing.Color.White;
            this.btnSpeakerOn.Image = ((System.Drawing.Image)(resources.GetObject("btnSpeakerOn.Image")));
            this.btnSpeakerOn.Location = new System.Drawing.Point(988, 62);
            this.btnSpeakerOn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpeakerOn.Name = "btnSpeakerOn";
            this.btnSpeakerOn.Size = new System.Drawing.Size(69, 69);
            this.btnSpeakerOn.TabIndex = 75;
            this.btnSpeakerOn.UseVisualStyleBackColor = false;
            this.btnSpeakerOn.CheckedChanged += new System.EventHandler(this.btnSpeakerOn_CheckedChanged);
            // 
            // ptbSkip
            // 
            this.ptbSkip.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptbSkip.ErrorImage")));
            this.ptbSkip.Image = ((System.Drawing.Image)(resources.GetObject("ptbSkip.Image")));
            this.ptbSkip.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptbSkip.InitialImage")));
            this.ptbSkip.Location = new System.Drawing.Point(960, 292);
            this.ptbSkip.Margin = new System.Windows.Forms.Padding(2);
            this.ptbSkip.Name = "ptbSkip";
            this.ptbSkip.Size = new System.Drawing.Size(48, 47);
            this.ptbSkip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbSkip.TabIndex = 68;
            this.ptbSkip.TabStop = false;
            // 
            // ptbHome
            // 
            this.ptbHome.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptbHome.ErrorImage")));
            this.ptbHome.Image = ((System.Drawing.Image)(resources.GetObject("ptbHome.Image")));
            this.ptbHome.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptbHome.InitialImage")));
            this.ptbHome.Location = new System.Drawing.Point(960, 368);
            this.ptbHome.Margin = new System.Windows.Forms.Padding(2);
            this.ptbHome.Name = "ptbHome";
            this.ptbHome.Size = new System.Drawing.Size(48, 48);
            this.ptbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbHome.TabIndex = 66;
            this.ptbHome.TabStop = false;
            // 
            // ptbHelp
            // 
            this.ptbHelp.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptbHelp.ErrorImage")));
            this.ptbHelp.Image = ((System.Drawing.Image)(resources.GetObject("ptbHelp.Image")));
            this.ptbHelp.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptbHelp.InitialImage")));
            this.ptbHelp.Location = new System.Drawing.Point(960, 213);
            this.ptbHelp.Margin = new System.Windows.Forms.Padding(2);
            this.ptbHelp.Name = "ptbHelp";
            this.ptbHelp.Size = new System.Drawing.Size(48, 48);
            this.ptbHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbHelp.TabIndex = 64;
            this.ptbHelp.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(960, 139);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 42);
            this.button6.TabIndex = 61;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quizzie.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1108, 721);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // hardMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 728);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSpeakerOff);
            this.Controls.Add(this.btnSpeakerOn);
            this.Controls.Add(this.ptbSkip);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.ptbHome);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.ptbHelp);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.txtHeart);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtQuesID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "hardMode";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.hardMode_FormClosing);
            this.Shown += new System.EventHandler(this.hardMode_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSkip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Button btnCheckAndNext;
        private System.Windows.Forms.PictureBox ptbHard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtQuesID;
        private System.Windows.Forms.PictureBox ptbHard2;
        private System.Windows.Forms.PictureBox ptbSkip;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.PictureBox ptbHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox ptbHelp;
        private System.Windows.Forms.Button btnHelp;
        public System.Windows.Forms.TextBox txtHeart;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnSpeakerOff;
        private System.Windows.Forms.CheckBox btnSpeakerOn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}