//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    partial class TestApp<A>
    {
        static FilePath LogTestResults(FolderName subdir, string basename,  TestCaseRecord[] records, LogWriteMode mode, bool header = true, char delimiter = Chars.Pipe)
        {
            if(records.Length == 0)
                return FilePath.Empty;
            
            return TestLog.Create().Write(records, subdir, basename, mode, delimiter, header, FileExtension.Define("csv"));
        }

        static FilePath LogBenchmarks<R>(string basename, R[] records, LogWriteMode mode = LogWriteMode.Create, bool header = true, char delimiter = Chars.Pipe)
            where R : ITabular
        {
            if(records.Length == 0)
                return FilePath.Empty;
                        
            return Z0.Log.BenchLog.Write(records, FolderName.Empty, basename, mode, delimiter, header, FileExtension.Define("csv"));
        }

        FilePath LogTestResults2(string basename, TestCaseRecord[] records, LogWriteMode mode, bool header = true, char delimiter = Chars.Pipe)
                => LogTestResults(AppPaths.TestResultFolder, basename, records, mode, header, delimiter);
    }
}