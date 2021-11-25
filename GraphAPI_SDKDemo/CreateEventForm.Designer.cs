
namespace GraphAPI_SDKDemo
{
    partial class CreateEventForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tbx_Attendees = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Subject = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_HTMLBody = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_Organizer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendees : ";
            // 
            // Tbx_Attendees
            // 
            this.Tbx_Attendees.Location = new System.Drawing.Point(236, 40);
            this.Tbx_Attendees.Name = "Tbx_Attendees";
            this.Tbx_Attendees.Size = new System.Drawing.Size(888, 26);
            this.Tbx_Attendees.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject : ";
            // 
            // tbx_Subject
            // 
            this.tbx_Subject.Location = new System.Drawing.Point(236, 75);
            this.tbx_Subject.Name = "tbx_Subject";
            this.tbx_Subject.Size = new System.Drawing.Size(888, 26);
            this.tbx_Subject.TabIndex = 1;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(13, 43);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 69);
            this.btn_Send.TabIndex = 3;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "End : ";
            // 
            // dtp_Start
            // 
            this.dtp_Start.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Start.Location = new System.Drawing.Point(236, 115);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(358, 26);
            this.dtp_Start.TabIndex = 4;
            // 
            // dtp_End
            // 
            this.dtp_End.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End.Location = new System.Drawing.Point(731, 115);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(393, 26);
            this.dtp_End.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "HTML Body";
            // 
            // tbx_HTMLBody
            // 
            this.tbx_HTMLBody.Location = new System.Drawing.Point(16, 188);
            this.tbx_HTMLBody.MaxLength = 3276700;
            this.tbx_HTMLBody.Multiline = true;
            this.tbx_HTMLBody.Name = "tbx_HTMLBody";
            this.tbx_HTMLBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_HTMLBody.Size = new System.Drawing.Size(1108, 516);
            this.tbx_HTMLBody.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Organizer : ";
            // 
            // tbx_Organizer
            // 
            this.tbx_Organizer.Location = new System.Drawing.Point(236, 4);
            this.tbx_Organizer.Name = "tbx_Organizer";
            this.tbx_Organizer.Size = new System.Drawing.Size(888, 26);
            this.tbx_Organizer.TabIndex = 1;
            // 
            // CreateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 716);
            this.Controls.Add(this.tbx_HTMLBody);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_End);
            this.Controls.Add(this.dtp_Start);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_Subject);
            this.Controls.Add(this.tbx_Organizer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tbx_Attendees);
            this.Controls.Add(this.label1);
            this.Name = "CreateEventForm";
            this.Text = "CreateEventForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbx_Attendees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Subject;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_HTMLBody;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_Organizer;
    }
}