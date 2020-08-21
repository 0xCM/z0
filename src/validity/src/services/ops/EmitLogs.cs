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
                EmitBenchmarkLog(basename.Replace(".test",".bench"),benchmarks, LogWriteMode.Overwrite);

            var results = SortResults();
            if(results.Any())
                EmitTestCaseLog(AppPaths.OutcomeFolder, basename, results);

        }

        static FilePath EmitTestCaseLog(FolderName subdir, string basename,  TestCaseRecord[] records)
        {
            if(records.Length == 0)
                return FilePath.Empty;

            return TestLog.Create().Write(records, subdir, basename, LogWriteMode.Overwrite, Chars.Pipe, true, FileExtension.Define("csv"));
        }


        static FilePath AppendCaseResults(FolderName subdir, string basename,  TestCaseRecord[] records)
        {
            if(records.Length == 0)
                return FilePath.Empty;

            return TestLog.Create().Write(records, subdir, basename, LogWriteMode.Overwrite, Chars.Pipe, true, FileExtension.Define("csv"));
        }

        static FilePath EmitBenchmarkLog<R>(string basename, R[] records, LogWriteMode mode = LogWriteMode.Create, bool header = true, char delimiter = Chars.Pipe)
            where R : ITabular
        {
            if(records.Length == 0)
                return FilePath.Empty;

            return Z0.Log.BenchLog.Write(records, FolderName.Empty, basename, mode, delimiter, header, FileExtension.Define("csv"));
        }

    }
}