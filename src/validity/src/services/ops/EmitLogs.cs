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
                var dst = Db.SortedCaseLogPath();
                Wf.Status($"Emitting case log to {dst.ToUri()}");
                EmitTestCaseLog(dst, results);
            }

            var benchmarks = SortBenchmarks();
            if(benchmarks.Any())
            {
                Wf.Status("Emitting benchmarks");

                Write(benchmarks, TestPaths.BenchLogPath);
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
            where R : struct, ITabular
            where F : unmanaged, Enum
        {
            if(records.Length == 0)
                return;

            using var writer = dst.Writer();
            writer.WriteLine(Table.header53<F>(delimiter));
            var formatter = Table.formatter<F>(delimiter);
            z.iter(records, r => writer.WriteLine(r.DelimitedText(delimiter)));
        }

        FS.FilePath Write(BenchmarkRecord[] src, FS.FilePath path)
        {
            using var writer = path.Writer();
            writer.WriteLine(string.Join(Chars.Pipe, BenchmarkRecord.GetHeaders()));
            foreach(var r in src)
                writer.WriteLine(r.DelimitedText(Chars.Pipe));

            return path;
        }
    }
}