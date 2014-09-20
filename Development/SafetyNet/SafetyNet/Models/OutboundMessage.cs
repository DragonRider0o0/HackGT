using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace SafetyNet.Models
{
    public class OutboundMessage
    {
        public int OutboundMessageId { get; set; }
        public string source { get; set; }
        public DangerEvent danger { get; set; }
        public List<string> messages { get; set; }
        public List<SafeZone> safeZones { get; set; }
    }
}