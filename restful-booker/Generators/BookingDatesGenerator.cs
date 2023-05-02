using restful_booker.Models;
using restful_booker.Utilities;

namespace restful_booker.Generators;

public static class BookingDatesGenerator
{
    private readonly static DateTimeRange Range = new() {StartDate = DateTime.Now.AddDays(1), EndDate = DateTime.Now.AddYears(1) }; 

    // range of period of staying

    public static BookingDates GenerateBookingDates()
    {
        var checkIn = DateTime.Now.AddDays(1);  // add random
        var checkOut = DateTime.Now.AddDays(2);

        return new BookingDates { CheckIn = checkIn, CheckOut = checkOut };
    }
}