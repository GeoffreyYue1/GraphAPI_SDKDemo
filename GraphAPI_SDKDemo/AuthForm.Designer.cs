
namespace GraphAPI_SDKDemo
{
    partial class AuthForm
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
            this.authWeb = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // authWeb
            // 
            this.authWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authWeb.Location = new System.Drawing.Point(0, 0);
            this.authWeb.MinimumSize = new System.Drawing.Size(20, 20);
            this.authWeb.Name = "authWeb";
            this.authWeb.Size = new System.Drawing.Size(1051, 837);
            this.authWeb.TabIndex = 0;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 837);
            this.Controls.Add(this.authWeb);
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser authWeb;
    }
}