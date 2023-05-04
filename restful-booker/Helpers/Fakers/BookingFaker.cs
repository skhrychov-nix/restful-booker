using Bogus;
using restful_booker.Generators;
using restful_booker.Models;

namespace restful_booker.Helpers;

public class BookingFaker : Faker<Booking>
{
    public BookingFaker()
    {
        RuleFor(b => b.Customer,  CustomerGenerator.GenerateCustomer);
        RuleFor(b => b.TotalPrice, f => f.Random.Number(100, 1000));
        RuleFor(b => b.DepositPaid, f => f.Random.Bool());
        RuleFor(b => b.BookingDates, BookingDatesGenerator.GenerateBookingDates);
        RuleFor(b => b.AdditionalNeeds, f => f.Random.Bool() ? "Breakfast" : "");
    }
}