﻿using System;
using System.Collections.Generic;

namespace JustEat.StatsD
{
    public interface IStatsDUdpClient : IDisposable
    {
        bool Send(string metric);
        bool Send(IEnumerable<string> metrics);
    }
}
