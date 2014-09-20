using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.Globalization;

using Newtonsoft.Json;

namespace SafetyNet.Models
{
    public class Address
    {
        [JsonIgnore]
        public int AddressId { get; set; }
        public string number { get; set; }
        public string street { get; set; }
        public string suburb { get; set; }
        public string city { get; set; }

        public Address()
        {
            AddressId = 0;
            number = "";
            street = "";
            suburb = "";
            city = "";
        }
    }
}
