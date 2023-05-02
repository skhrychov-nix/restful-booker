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
    internal class Booking : Customer
    {
        [JsonProperty("totalprice", Required = Required.Always)]
        [XmlElement("totalprice", DataType = "decimal", IsNullable = false)]
        [Required]
        public decimal TotalPrice { get; set; }

        [JsonProperty("depositpaid", Required = Required.AllowNull)]
        [XmlElement("depositpaid", DataType = "bool", IsNullable = true)]
        public bool DepositPaid { get; set; }

        [JsonProperty("bookingdates", Required = Required.Always)]
        [XmlElement("bookingdates", DataType = "BookingDates", IsNullable = false)]
        [Required]
        public BookingDates BookingDates { get; set; }
        
        [JsonProperty("additionalneeds", Required = Required.AllowNull)]
        [XmlElement("additionalneeds", DataType = "string", IsNullable = true)]
        public string AdditionalNeeds { get; set; }
    }
}
