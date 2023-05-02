using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace restful_booker.Models
{
    public class Customer
    {
        [JsonProperty("firstname", Required = Required.Always)]
        [XmlElement("firstname", DataType = "string", IsNullable = false)]
        [Required]
        public string FirstName { get; set; }

        [JsonProperty("lastname", Required = Required.Always)]
        [XmlElement("lastname", DataType = "string", IsNullable = false)]
        [Required]
        public string LastName { get; set; }
    }
}
