using restful_booker.Models;

namespace restful_booker.Generators;

public class BookingGenerator
{
    public static Booking GenerateBooking()
    {
        var customer = CustomerGenerator.GenerateCustomer();
        var totalPrice = 100; // add random range
        var depositPaid = true; // add random bool
        var bookingDates = BookingDatesGenerator.GenerateBookingDates();
        var additionalNeeds = "Breakfast"; // use Bogus for fake data

        return new Booking
        {
            Customer = customer,
            TotalPrice = totalPrice,
            DepositPaid = depositPaid,
            BookingDates = bookingDates,
            AdditionalNeeds = additionalNeeds
        };
    }
}