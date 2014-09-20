using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Newtonsoft.Json;

namespace SafetyNet.Models
{
    public class GPS
    {
        [JsonIgnore]
        public int GPSId { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }

        public GPS()
        {
            GPSId = 0;
            latitude = "";
            longitude = "";
        }

    }
}
