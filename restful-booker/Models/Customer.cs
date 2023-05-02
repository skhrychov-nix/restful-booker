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
