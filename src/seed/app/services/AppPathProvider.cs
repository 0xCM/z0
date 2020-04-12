//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    public readonly struct AppPathProvider : IAppPaths<AppPathProvider>
    {
        public static AppPathProvider Create(PartId id, FolderPath root)
        {
            var data = root + FolderName.Define("data");
            var benchmarks = root + FolderName.Define("bench");
            var test = root + FolderName.Define("test");
            var stdout = test + FolderName.Define("stdout");
            var stderr = test + FolderName.Define("stderr");
            var testResults = test + FolderName.Define("results");            
            return new AppPathProvider(id, root, data, stdout, stderr, testResults, benchmarks);
        }

        AppPathProvider(PartId id, FolderPath root, FolderPath data, FolderPath stdout, FolderPath stderr, FolderPath testResults, FolderPath benchmarks)
        {
            this.AppId = id;
            this.Root = root;
            this.DataRoot = data;
            this.StandardOut = stdout;
            this.StandardError = stderr;
            this.TestResults = testResults;
            this.BenchResults = benchmarks;
        }

        public PartId AppId {get;}

        public FolderPath Root {get;}

        public FolderPath DataRoot {get;}

        public FolderPath StandardOut {get;}

        public FolderPath StandardError {get;}

        public FolderPath TestResults {get;}

        public FolderPath BenchResults {get;}

        const string sep = " := ";

        public string Format()
        {
            var dst = new StringBuilder();
            dst.AppendLine(string.Concat(nameof(AppId), sep, AppId.Format()));
            dst.AppendLine(string.Concat(nameof(Root), sep, Root));
            dst.AppendLine(string.Concat(nameof(DataRoot), sep, DataRoot));
            dst.AppendLine(string.Concat(nameof(StandardOut), sep, StandardOut));
            dst.AppendLine(string.Concat(nameof(StandardError), sep, StandardError));
            dst.AppendLine(string.Concat(nameof(TestResults), sep, TestResults));
            dst.AppendLine(string.Concat(nameof(BenchResults), sep, BenchResults));
            return dst.ToString();
        }
    }
}