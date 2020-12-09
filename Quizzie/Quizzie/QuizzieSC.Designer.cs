namespace Quizzie
{
    partial class QuizzieSC
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
            this.btnServer = new MetroFramework.Controls.MetroButton();
            this.btnClient = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnServer
            // 
            this.btnServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnServer.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnServer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnServer.Location = new System.Drawing.Point(65, 89);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(132, 54);
            this.btnServer.TabIndex = 0;
            this.btnServer.Text = "Server";
            this.btnServer.UseSelectable = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click_1);
            // 
            // btnClient
            // 
            this.btnClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClient.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnClient.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClient.Location = new System.Drawing.Point(65, 182);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(132, 54);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Client";
            this.btnClient.UseSelectable = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // QuizzieSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 282);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnServer);
            this.Name = "QuizzieSC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "QuizzieSC";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnServer;
        private MetroFramework.Controls.MetroButton btnClient;
    }
}