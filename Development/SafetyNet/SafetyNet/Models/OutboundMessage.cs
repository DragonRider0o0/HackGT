using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Newtonsoft.Json;

namespace SafetyNet.Models
{
    public class OutboundMessage
    {
        [JsonIgnore]
        public int OutboundMessageId { get; set; }
        public string source { get; set; }
        public DangerEvent danger { get; set; }
        public List<string> messages { get; set; }
        public List<GPS> safeZones { get; set; }

        public OutboundMessage()
        {
            OutboundMessageId = 0;
            source = "";
            danger = new DangerEvent();
            messages = new List<string>();
            safeZones = new List<GPS>();

        }
    }
}