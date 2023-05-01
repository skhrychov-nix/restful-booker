using restful_booker.Models;

namespace restful_booker.Generators;

public static class BookingDatesGenerator
{
    public static BookingDates GenerateBookingDates()
    {
        var checkIn = DateTime.Now.AddDays(1);
        var checkOut = DateTime.Now.AddDays(2);

        return new BookingDates { CheckIn = checkIn, CheckOut = checkOut };
    }
}