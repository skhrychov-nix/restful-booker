using restful_booker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful_booker.Generators
{
    public class CredentialsGenerator
    {
        public static Credentials GenerateCredentils()
        {
            var userName = "Admin";
            var password = "password123";

            return new Credentials
            {
                UserName = userName,
                Password = password
            };
        }
    }
}
