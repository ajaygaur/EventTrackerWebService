﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EventTracker.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
