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
            var firstName = "John";
            var lastName = "Doe";

            return new Customer { FirstName = firstName, LastName = lastName };
        }
    }
}
