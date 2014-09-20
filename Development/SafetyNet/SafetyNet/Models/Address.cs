using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace SafetyNet.Models
{
    class Address
    {
        public int AddressId { get; set; }
        string number { get; set; }
        string street { get; set; }
        string suburb { get; set; }
        string city { get; set; }
    }
}
