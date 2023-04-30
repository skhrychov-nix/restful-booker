using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful_booker.Models
{
    internal class Booking
    {
        public Customer Customer { get; set; }

        [JsonProperty("totalprice")]
        public decimal TotalPrice { get; set; }

        [JsonProperty("depositpaid")]
        public bool DepositPaid { get; set; }

        public BookingDates BookingDates { get; set; }

        [JsonProperty("additionalneeds")]
        public string AdditionalNeeds { get; set; }
    }
}
