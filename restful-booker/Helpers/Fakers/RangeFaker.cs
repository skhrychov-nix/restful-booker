using Bogus;
using restful_booker.Utilities;

namespace restful_booker.Helpers;

public class RangeFaker : Faker<PeriodOfStayingRange>
{
    public RangeFaker()
    {
        RuleFor(p => p.StartStayingDate, f => f.Date.Between(DateTime.Now.AddDays(1), DateTime.Now.AddDays(1)));
        RuleFor(p => p.EndStayingDate, (f, p) => f.Date.Between(p.StartStayingDate, DateTime.Now.AddMonths(1)));
    }
}