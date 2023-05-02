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
    public class Credentials
    {
        [JsonProperty("username", Required = Required.Always)]
        [XmlElement("username", DataType = "string", IsNullable = false)]
        [Required]
        public string UserName { get; set; }

        [JsonProperty("password", Required = Required.Always)]
        [XmlElement("password", DataType = "string", IsNullable = false)]
        [Required]
        public string Password { get; set; }
    }
}
