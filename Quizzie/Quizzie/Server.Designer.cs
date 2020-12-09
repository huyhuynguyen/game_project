namespace Quizzie
{
    partial class Server
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
            this.lwMess = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lwMess
            // 
            this.lwMess.HideSelection = false;
            this.lwMess.Location = new System.Drawing.Point(23, 63);
            this.lwMess.Name = "lwMess";
            this.lwMess.Size = new System.Drawing.Size(198, 159);
            this.lwMess.TabIndex = 0;
            this.lwMess.UseCompatibleStateImageBehavior = false;
            this.lwMess.View = System.Windows.Forms.View.List;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 245);
            this.Controls.Add(this.lwMess);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lwMess;
    }
}