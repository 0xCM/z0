//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Konst;

    partial class TestApp<A>
    {
        void EmitLogs()
        {
            var basename = AppName;
            
            var benchmarks = SortBenchmarks();
            if(benchmarks.Any())
            {
                LogBenchmarks(basename.Replace(".test",".bench"),benchmarks, LogWriteMode.Overwrite);
            }
            
            var results = SortResults();
            if(results.Any())
            {
                // Emit a unique file
                LogTestResults(FolderName.Define("history"), basename, results, LogWriteMode.Create);
                
                // Overwrite the current test log file for the app
                LogTestResults2(basename, results, LogWriteMode.Overwrite);
            }
        }
    }
}