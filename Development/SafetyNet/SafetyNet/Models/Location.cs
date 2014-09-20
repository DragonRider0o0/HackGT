using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.Globalization;

using Newtonsoft.Json;

namespace SafetyNet.Models
{
    public class Location
    {
        [JsonIgnore]
        public int LocationId { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public Address address { get; set; }

        public Location()
        {
            LocationId = 0;
            latitude = "";
            longitude = "";
            address = new Address();
        }
    }
}
