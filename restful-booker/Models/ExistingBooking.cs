using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful_booker.Models
{
    public class ExistingBooking
    {
        [JsonProperty("id")]   // ??????
        public int Id { get; set; }

        public Booking Booking { get; set; }
    }
}
