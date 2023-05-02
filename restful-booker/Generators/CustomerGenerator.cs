using restful_booker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using restful_booker.Helpers;

namespace restful_booker.Generators
{
    public class CustomerGenerator
    {
        public static Customer GenerateCustomer()
        {
           var customer = new CustomerFaker().Generate();
           return customer;
        }
    }
}
