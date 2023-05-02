using Bogus;
using restful_booker.Helpers;
using restful_booker.Models;
using restful_booker.Utilities;

namespace restful_booker.Generators;

public static class BookingDatesGenerator
{
    public static BookingDates GenerateBookingDates()
    {
        var periodOfStayingRange = new RangeFaker().Generate();

        return new BookingDates { CheckIn = periodOfStayingRange.StartStayingDate, CheckOut = periodOfStayingRange.EndStayingDate };
    }
}