using Microsoft.Graph;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphAPI_SDKDemo
{
    public partial class CreateEventForm : Form
    {
        public CreateEventForm()
        {
            InitializeComponent();
            tbx_HTMLBody.Text = System.IO.File.ReadAllText("HtmlBodySample.html");
            dtp_Start.Value = dtp_Start.Value.AddMinutes(30);
            dtp_End.Value = dtp_Start.Value.AddMinutes(30);

            Tbx_Attendees.Text = "u8@geoffrey1.onmicrosoft.com;u10@geoffrey1.onmicrosoft.com";
            tbx_Subject.Text = "Test Meeting Subject";

        }

        private async void btn_Send_Click(object sender, EventArgs e)
        {
            Event @event = new Event();

            @event.Subject = tbx_Subject.Text.Trim();
            List<Attendee> attendees = new List<Attendee>();
            foreach (string attendeeStr in Tbx_Attendees.Text.Trim().Split(';'))
            {
                attendees.Add(new Attendee { EmailAddress = new EmailAddress { Address = attendeeStr },Type = AttendeeType.Required });
            }
            @event.Attendees = attendees;

            @event.Start = new DateTimeTimeZone { DateTime = dtp_Start.Value.ToString("yyyy-MM-ddTHH:mm:ss"), TimeZone = TimeZone.CurrentTimeZone.StandardName };
            @event.End = new DateTimeTimeZone { DateTime = dtp_End.Value.ToString("yyyy-MM-ddTHH:mm:ss"), TimeZone = TimeZone.CurrentTimeZone.StandardName };
            @event.Body = new ItemBody
            {
                ContentType = BodyType.Html,
            Content= tbx_HTMLBody.Text
            };

            Event newEventCreated = null;

            if (GlobalVar.codeAuth && string.IsNullOrEmpty(tbx_Organizer.Text.Trim()))
            {
                newEventCreated = await GlobalVar.graphClient.Me.Events
                  .Request()

                  .AddAsync(@event);
            }
            else if (!GlobalVar.codeAuth && string.IsNullOrEmpty(tbx_Organizer.Text.Trim()))
            {
                MessageBox.Show("Your are currently using Application permission, please input the user's SMTP address");
            }
            else
            {
                newEventCreated = await GlobalVar.graphClient.Users[tbx_Organizer.Text.Trim()].Events
                 .Request()

                 .AddAsync(@event);
            }


            string newEventStr = JsonConvert.SerializeObject(newEventCreated);


            ResultForm resultForm = new ResultForm(newEventStr);
            resultForm.ShowDialog();
            this.Close();
        }
    }
}
