using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace restful_booker.Models
{
    internal class ExistingBooking
    {
        [JsonProperty("bookingid", Required = Required.Always)]
        [XmlElement("bookingid", DataType = "int", IsNullable = false)]
        [Required]
        public int Id { get; set; }
        
        [JsonProperty("booking", Required = Required.Always)]
        [XmlElement("booking", DataType = "Booking", IsNullable = false)]
        [Required]
        public Booking Booking { get; set; }
    }
}
