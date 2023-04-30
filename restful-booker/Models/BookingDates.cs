﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful_booker.Models
{
    public class BookingDates
    {
        [JsonProperty("checkin")]
        public DateTime CheckIn { get; set; }

        [JsonProperty("checkout")]
        public DateTime CheckOut { get; set; }
    }
}
