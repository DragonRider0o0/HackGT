using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.Globalization;


namespace SafetyNet.Models
{
    class DangerEvent
    {
        public int DangerEventId { get; set; }
        string name { get; set; }
        string time { get; set; }
        Location location { get; set; }
    }
}
