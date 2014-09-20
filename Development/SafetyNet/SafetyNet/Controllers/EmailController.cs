using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System;
using System.Net;
using System.Net.Mail;
using SendGrid;

namespace SafetyNet.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public void Index()
        {
            SendEmail("DragonRider0o0@gmail.com");
        }

        public void SendEmail(string toEmail)
        {
            var Password = "5m7TfyhBEG4358L";
            var SMTP_SERVER = "smtp.sendgrid.net";
            var Username = "azure_4fb85a20f9e9acf10f74ab90f7152825@azure.com";
            var fromEmail = "CMUHackGT@outlook.com";
            var fromName = "CMU HCI @ HackGT";
            var message = "awesome test message";

            var credentials = new NetworkCredential(Username, Password);
            // Create the email object first, then add the properties.
            // Create the email object first, then add the properties.
            SendGridMessage myMessage = new SendGridMessage();
            myMessage.AddTo(toEmail);
            myMessage.From = new MailAddress(fromEmail, fromName);
            myMessage.Subject = "SafetyNet - Emergency";
            myMessage.Text = message;


            // Create an Web transport for sending email.
            var transportWeb = new Web(credentials);

            // Send the email.
            // You can also use the **DeliverAsync** method, which returns an awaitable task.
            transportWeb.Deliver(myMessage);
        }
    }
}