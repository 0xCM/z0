//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Part;

    partial class TestApp<A>
    {
        public void EmitLogs()
        {
            var basename = AppName;
            var results = SortResults();

            if(results.Any())
            {
                var timing = results.Sum(x => x.Duration.TimeSpan.TotalSeconds);
                var dst = Db.CaseLogSummary();
                Wf.Status($"Emitting case log to {dst.ToUri()} with execution time of {timing} seconds");
                EmitTestCaseLog(dst, results);
            }

            var benchmarks = SortBenchmarks();
            if(benchmarks.Any())
            {
                var timing = benchmarks.Sum(x => x.Timing.TimeSpan.TotalSeconds);
                // Wf.Status($"Emitting benchmarks to {TestPaths.BenchLogPath} with execution time of {timing} seconds");
                // Write(benchmarks, TestPaths.BenchLogPath);
            }
        }

        static FS.FilePath EmitTestCaseLog(FS.FilePath dst, TestCaseRecord[] records)
        {
            if(records.Length == 0)
                return FS.FilePath.Empty;

            Emit(records, dst, default(TestCaseField));
            return dst;
        }

        static void Emit<R,F>(R[] records, FS.FilePath dst, F f = default, char delimiter = FieldDelimiter)
            where R : struct, ITextual
            where F : unmanaged, Enum
        {
            if(records.Length == 0)
                return;

            using var writer = dst.Writer();
            writer.WriteLine(Datasets.header53<F>(delimiter));
            var formatter = Datasets.formatter<F>(delimiter);
            root.iter(records, r => writer.WriteLine(r.Format()));
        }

    }
}