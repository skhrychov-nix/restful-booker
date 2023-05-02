using Bogus;
using restful_booker.Models;

namespace restful_booker.Helpers;

public class CustomerFaker : Faker<Customer>
{
    public CustomerFaker()
    {
        RuleFor(c => c.FirstName, f => f.Person.FirstName);
        RuleFor(c => c.LastName, f => f.Person.LastName);
    }
}