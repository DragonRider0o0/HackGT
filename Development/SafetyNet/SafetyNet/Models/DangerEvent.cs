using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.Globalization;

using Newtonsoft.Json;

namespace SafetyNet.Models
{
    public class DangerEvent
    {
        [JsonIgnore]
        public int DangerEventId { get; set; }
        public string name { get; set; }
        public string time { get; set; }
        public Location location { get; set; }

        public DangerEvent()
        {
            DangerEventId = 0;
            name = "";
            time = "";
            location = new Location();
        }
    }
}
