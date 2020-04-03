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
            var stdout = root + FolderName.Define("test");
            var stderr = stdout;
            var test = stdout + FolderName.Define("results");
            var bench = test;
            return new AppPathProvider(id,root,data, stdout, stderr, test, bench);
        }

        AppPathProvider(PartId id, FolderPath root, FolderPath data, FolderPath stdout, FolderPath stderr, FolderPath test, FolderPath bench)
        {
            this.AppId = id;
            this.GlobalRootDir = root;
            this.DataRootDir = data;
            this.StandardOutDir = stdout;
            this.StandardErrorDir = stderr;
            this.TestResultDir = test;
            this.BenchResultDir = bench;
        }

        public PartId AppId {get;}

        public FolderPath GlobalRootDir {get;}

        public FolderPath DataRootDir {get;}

        public FolderPath StandardOutDir {get;}

        public FolderPath StandardErrorDir {get;}

        public FolderPath TestResultDir {get;}

        public FolderPath BenchResultDir {get;}

        const string sep = " := ";

        public string Format()
        {
            var dst = new StringBuilder();
            dst.AppendLine(string.Concat(nameof(AppId), sep, AppId.Format()));
            dst.AppendLine(string.Concat(nameof(GlobalRootDir), sep, GlobalRootDir));
            dst.AppendLine(string.Concat(nameof(DataRootDir), sep, DataRootDir));
            dst.AppendLine(string.Concat(nameof(StandardOutDir), sep, StandardOutDir));
            dst.AppendLine(string.Concat(nameof(StandardErrorDir), sep, StandardErrorDir));
            dst.AppendLine(string.Concat(nameof(TestResultDir), sep, TestResultDir));
            dst.AppendLine(string.Concat(nameof(BenchResultDir), sep, BenchResultDir));
            return dst.ToString();
        }
    }
}