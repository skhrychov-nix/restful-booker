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
    public class BookingDates
    {
        [JsonProperty("checkin", Required = Required.Always)]
        [XmlElement("checkin", DataType = "date", IsNullable = false)]
        [Required]
        public DateTime CheckIn { get; set; }

        [JsonProperty("checkout", Required = Required.Always)]
        [XmlElement("checkout", DataType = "date", IsNullable = false)]
        [Required]
        public DateTime CheckOut { get; set; }
    }
}
