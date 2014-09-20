using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using SafetyNet.Models;

using Twilio;
using Twilio.TwiML;

namespace SafetyNet.Controllers
{
    public class PhoneController : Controller
    {
        public void Index()
        {
            //SendSMS();
            SendCall("+18017878026");
        }
        string docType = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
        string responseOpen = "<Response>";
        string responseClose = "</Response>";

        void SetupTwilio()
        {
            // put your Twilio API credentials here
            string accountSid = "AC2cbe631411b305e102ac2e3ce2da0407";
            string authToken = "9093223b161f8d4a9a97577b5cddbc20";

            var capability = new TwilioCapability(accountSid, authToken);
            //capability.AllowClientIncoming;
            //capability.AllowClientOutgoing("APabe7650f654fc34655fc81ae71caa3ff");
            //string token = capability.GenerateToken();
        }

        public void AnswerCall()
        {
            string message = docType + responseOpen;
            message += "<Say voice=\"woman\">Please leave a message after the tone.</Say>";
            message += "<Record maxLength=\"20\" />";
            message += responseClose;
        }

        public void SendSMS(string targetNumber, string message)
        {
            string twilioNumber = "+18014299303";
            string accountSid = "AC2cbe631411b305e102ac2e3ce2da0407";
            string authToken = "9093223b161f8d4a9a97577b5cddbc20";

            var client = new TwilioRestClient(accountSid, authToken);

            client.SendSmsMessage(twilioNumber, targetNumber, message);
        }

        public void SendCall(string targetNumber)
        {
            string twilioNumber = "+18014299303";
            string accountSid = "AC2cbe631411b305e102ac2e3ce2da0407";
            string authToken = "9093223b161f8d4a9a97577b5cddbc20";

            var client = new TwilioRestClient(accountSid, authToken);

            var url = "http://safetynet.azurewebsites.net/phone/GetCallTwiml";
            client.InitiateOutboundCall(twilioNumber, targetNumber, url);
        }

        public string GetCallTwiml()
        {
            string message = docType + responseOpen;
            message += "<Say voice=\"woman\">Please leave a message after the tone.</Say>";
            message += "<Record maxLength=\"20\" />";
            message += responseClose;
            return message;
        }

    }
}
