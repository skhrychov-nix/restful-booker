using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful_booker.Models
{
    internal class ExistingBooking
    {
        [JsonProperty("bookingid")]
        public int Id { get; set; }
        
        [JsonProperty("booking")]
        public Booking Booking { get; set; }
    }
}
