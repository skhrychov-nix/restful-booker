using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful_booker.Models
{
    public class Token
    {
        [JsonProperty("token")]
        public string TokenValue { get; set; }
    }
}
