
namespace GraphAPI_SDKDemo
{
    partial class Form1
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
            this.btn_CodeAuth = new System.Windows.Forms.Button();
            this.btn_AppAuth = new System.Windows.Forms.Button();
            this.btn_getEvents = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_userSMTP = new System.Windows.Forms.TextBox();
            this.btn_CreateEvent = new System.Windows.Forms.Button();
            this.btn_CreateSubscription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CodeAuth
            // 
            this.btn_CodeAuth.Location = new System.Drawing.Point(19, 27);
            this.btn_CodeAuth.Name = "btn_CodeAuth";
            this.btn_CodeAuth.Size = new System.Drawing.Size(168, 39);
            this.btn_CodeAuth.TabIndex = 0;
            this.btn_CodeAuth.Text = "Code Auth";
            this.btn_CodeAuth.UseVisualStyleBackColor = true;
            this.btn_CodeAuth.Click += new System.EventHandler(this.btn_CodeAuth_Click);
            // 
            // btn_AppAuth
            // 
            this.btn_AppAuth.Location = new System.Drawing.Point(255, 27);
            this.btn_AppAuth.Name = "btn_AppAuth";
            this.btn_AppAuth.Size = new System.Drawing.Size(182, 39);
            this.btn_AppAuth.TabIndex = 1;
            this.btn_AppAuth.Text = "Application Auth";
            this.btn_AppAuth.UseVisualStyleBackColor = true;
            this.btn_AppAuth.Click += new System.EventHandler(this.btn_AppAuth_Click);
            // 
            // btn_getEvents
            // 
            this.btn_getEvents.Location = new System.Drawing.Point(19, 92);
            this.btn_getEvents.Name = "btn_getEvents";
            this.btn_getEvents.Size = new System.Drawing.Size(168, 39);
            this.btn_getEvents.TabIndex = 2;
            this.btn_getEvents.Text = "Get Events";
            this.btn_getEvents.UseVisualStyleBackColor = true;
            this.btn_getEvents.Click += new System.EventHandler(this.btn_getEvents_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "SMTP:";
            // 
            // tbx_userSMTP
            // 
            this.tbx_userSMTP.Location = new System.Drawing.Point(535, 33);
            this.tbx_userSMTP.Name = "tbx_userSMTP";
            this.tbx_userSMTP.Size = new System.Drawing.Size(315, 26);
            this.tbx_userSMTP.TabIndex = 4;
            // 
            // btn_CreateEvent
            // 
            this.btn_CreateEvent.Location = new System.Drawing.Point(19, 161);
            this.btn_CreateEvent.Name = "btn_CreateEvent";
            this.btn_CreateEvent.Size = new System.Drawing.Size(168, 37);
            this.btn_CreateEvent.TabIndex = 5;
            this.btn_CreateEvent.Text = "Create Event";
            this.btn_CreateEvent.UseVisualStyleBackColor = true;
            this.btn_CreateEvent.Click += new System.EventHandler(this.btn_CreateEvent_Click);
            // 
            // btn_CreateSubscription
            // 
            this.btn_CreateSubscription.Location = new System.Drawing.Point(19, 219);
            this.btn_CreateSubscription.Name = "btn_CreateSubscription";
            this.btn_CreateSubscription.Size = new System.Drawing.Size(168, 37);
            this.btn_CreateSubscription.TabIndex = 5;
            this.btn_CreateSubscription.Text = "Create Subscription";
            this.btn_CreateSubscription.UseVisualStyleBackColor = true;
            this.btn_CreateSubscription.Click += new System.EventHandler(this.btn_CreateSubscription_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 642);
            this.Controls.Add(this.btn_CreateSubscription);
            this.Controls.Add(this.btn_CreateEvent);
            this.Controls.Add(this.tbx_userSMTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_getEvents);
            this.Controls.Add(this.btn_AppAuth);
            this.Controls.Add(this.btn_CodeAuth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CodeAuth;
        private System.Windows.Forms.Button btn_AppAuth;
        private System.Windows.Forms.Button btn_getEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_userSMTP;
        private System.Windows.Forms.Button btn_CreateEvent;
        private System.Windows.Forms.Button btn_CreateSubscription;
    }
}

