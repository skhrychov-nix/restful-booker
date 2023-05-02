using restful_booker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful_booker.Generators
{
    public class CustomerGenerator
    {
        public static Customer GenerateCustomer()
        {
            var firstName = "John"; // use Bogus for fake data
            var lastName = "Doe"; // use Bogus for fake data

            return new Customer { FirstName = firstName, LastName = lastName };
        }
    }
}
