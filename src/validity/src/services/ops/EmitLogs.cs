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
        public void EmitLogs()
        {
            var basename = AppName;
            var benchmarks = SortBenchmarks();
            if(benchmarks.Any())
                EmitBenchmarkLog(basename.Replace(".test",".bench"),benchmarks, LogWriteMode.Overwrite);

            var results = SortResults();
            if(results.Any())
                EmitTestCaseLog(AppPaths.SortedCaseLogPath(), results);
        }

        static FilePath EmitTestCaseLog(FS.FilePath dst,  TestCaseRecord[] records)
        {
            if(records.Length == 0)
                return FilePath.Empty;

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

        static FilePath EmitBenchmarkLog<R>(string basename, R[] records, LogWriteMode mode = LogWriteMode.Create, bool header = true, char delimiter = Chars.Pipe)
            where R : ITabular
        {
            if(records.Length == 0)
                return FilePath.Empty;

            return Z0.Log.BenchLog.Write(records, FS.FolderName.Empty, basename, mode, delimiter, header, ArchiveFileKinds.Csv);
        }
    }
}