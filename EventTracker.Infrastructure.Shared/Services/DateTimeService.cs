using System;
using System.Collections.Generic;
using System.Text;
using EventTracker.Application.Interfaces;

namespace EventTracker.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
