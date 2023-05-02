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
    public class Token
    {
        [JsonProperty("token", Required = Required.Always)]
        [XmlElement("token", DataType = "string", IsNullable = false)]
        [Required]
        public string TokenValue { get; set; }
    }
}
