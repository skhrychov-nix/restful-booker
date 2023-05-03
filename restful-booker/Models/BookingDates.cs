using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
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
