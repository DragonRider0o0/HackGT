using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace SafetyNet.Models
{
    class SafeZone
    {
        public int SafeZoneId { get; set; }
        string latitude { get; set; }
        string longitude { get; set; }
    }
}
