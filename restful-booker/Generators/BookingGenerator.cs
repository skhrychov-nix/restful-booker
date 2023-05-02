using restful_booker.Helpers;
using restful_booker.Models;

namespace restful_booker.Generators;

public class BookingGenerator
{
    public static Booking GenerateBooking()
    {
        var booking = new BookingFaker().Generate();
        return booking;
    }
}