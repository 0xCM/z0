//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    public interface IBenchResultSink
    {
        BenchmarkRecord ReportBenchmark(string name, long opcount, TimeSpan duration);        
    }


    public interface IBenchResultSource
    {
        IEnumerable<BenchmarkRecord> TakeBenchmarks();
    }

}