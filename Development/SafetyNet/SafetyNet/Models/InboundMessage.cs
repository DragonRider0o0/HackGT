using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Newtonsoft.Json;

namespace SafetyNet.Models
{
    public class InboundMessage
    {
        [JsonIgnore]
        string InboundMessageID = "";
        GPS location = new GPS();
        string time = "";
        int count = 0;
        bool injured = false;
        bool mobile = false; 
    }
}