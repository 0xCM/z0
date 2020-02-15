//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IBenchResultSink
    {
        BenchmarkRecord ReportBenchmark(string name, long opcount, TimeSpan duration);        
    }
}