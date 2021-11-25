using Azure.Identity;
using Microsoft.Graph;
using Microsoft.Graph.Auth;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphAPI_SDKDemo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CodeAuth_Click(object sender, EventArgs e)
        {


            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();

            IConfidentialClientApplication confidentialClientApplication = ConfidentialClientApplicationBuilder
  .Create(GlobalVar.clientId)
  .WithTenantId(GlobalVar.TenantId)
  .WithClientSecret(GlobalVar.secret)
  .WithRedirectUri(GlobalVar.redirectUri)
  .WithAuthority(AzureCloudInstance.AzurePublic, AadAuthorityAudience.AzureAdMyOrg)
  .Build();


            AcquireTokenByAuthorizationCodeParameterBuilder acb = confidentialClientApplication.AcquireTokenByAuthorizationCode(GlobalVar.scopes, GlobalVar.code);

            AuthenticationResult result = acb.ExecuteAsync().Result;



            var delegateAuthProvider = new DelegateAuthenticationProvider((requestMessage) =>
            {
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", result.AccessToken);

                return Task.FromResult(0);
            });

            GlobalVar.graphClient = new GraphServiceClient(delegateAuthProvider);

            GlobalVar.codeAuth = true;
        }



        private void btn_AppAuth_Click(object sender, EventArgs e)
        {
            IConfidentialClientApplication confidentialClientApplication = ConfidentialClientApplicationBuilder
 .Create("b54fc3e3-65d8-469f-a301-89faf3c7de98")
 .WithTenantId("66c34abb-b963-4041-8808-e0a7f4b5b7aa")
 .WithClientSecret("tFE7Q~DTrFtNn2AMNTWj6D_n2ohGps1SC02LL")
 .Build();



            ClientCredentialProvider authProvider = new ClientCredentialProvider(confidentialClientApplication);

            GlobalVar.graphClient = new GraphServiceClient(authProvider);

            GlobalVar.codeAuth = false;

        }

        public async void GetEvents(string userSMTP = null)
        {
            IUserEventsCollectionPage events = null;
            if (string.IsNullOrEmpty(userSMTP))
            {
                events = await GlobalVar.graphClient.Me.Events.Request().GetAsync();
            }
            else
            {
                events = await GlobalVar.graphClient.Users[userSMTP].Events.Request().GetAsync();
            }

            string eventsStr = JsonConvert.SerializeObject(events);

            ResultForm resultForm = new ResultForm(eventsStr);
            resultForm.ShowDialog();

        }

        private void btn_getEvents_Click(object sender, EventArgs e)
        {
            if (GlobalVar.graphClient == null)
            {
                MessageBox.Show("Please choose an Auth method and Sign in first!");
                return;
            }

            if (GlobalVar.codeAuth && string.IsNullOrEmpty(tbx_userSMTP.Text))
            {
                GetEvents();
            }
            else if (!GlobalVar.codeAuth && string.IsNullOrEmpty(tbx_userSMTP.Text))
            {
                MessageBox.Show("Your are currently using Application permission, please input the user's SMTP address");
            }
            else
            {
                GetEvents(tbx_userSMTP.Text);
            }
        }



        private void btn_CreateEvent_Click(object sender, EventArgs e)
        {
            if (GlobalVar.graphClient == null)
            {
                MessageBox.Show("Please choose an Auth method and Sign in first!");
                return;
            }
            CreateEventForm createEventForm = new CreateEventForm();
            createEventForm.ShowDialog();
        }

        private void btn_CreateSubscription_Click(object sender, EventArgs e)
        {
            if (GlobalVar.graphClient == null)
            {
                MessageBox.Show("Please choose an Auth method and Sign in first!");
                return;
            }

            if (GlobalVar.codeAuth && string.IsNullOrEmpty(tbx_userSMTP.Text))
            {
                CreateSubscription();
            }
            else if (!GlobalVar.codeAuth && string.IsNullOrEmpty(tbx_userSMTP.Text))
            {
                MessageBox.Show("Your are currently using Application permission, please input the user's SMTP address");
            }
            else
            {
                CreateSubscription(tbx_userSMTP.Text);
            }
        }
        public async void CreateSubscription(string userSMTP = null)
        {
            string resoureStr = null;
            if (string.IsNullOrEmpty(userSMTP))
            {
                resoureStr = "me/events";
            }
            else
            {
                resoureStr = "Users/"+userSMTP+"/events";
            }

            var subscription = new Subscription
            {
                //Resource = "me/mailFolders('Inbox')/messages",
                Resource = resoureStr,
                ChangeType = "created,updated,deleted",
                NotificationUrl = "https://mail.geoffrey1.msftonlinelab.com/GraphWebhooks/notification/listen",
                ClientState = Guid.NewGuid().ToString(),
                ExpirationDateTime = DateTime.UtcNow.AddMinutes(30) // shorter duration useful for testing
            };

            var newSubscription = await GlobalVar.graphClient.Subscriptions.Request().AddAsync(subscription);
        }
    }
}
