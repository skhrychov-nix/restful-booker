using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace restful_booker.Models
{
    public class Token
    {
        [JsonProperty("token", Required = Required.Always)]
        [XmlElement("token", DataType = "string", IsNullable = false)]
        [Required]
        public string TokenValue { get; set; }
    }
}
