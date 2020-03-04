//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct AppPathProvider : IAppPaths<AppPathProvider>
    {
        public static AppPathProvider Create(AssemblyId id, FolderPath root)
        {
            var data = root + FolderName.Define("data");
            var stdout = root + FolderName.Define("test");
            var stderr = stdout;
            var test = stdout + FolderName.Define("results");
            var bench = test;
            return new AppPathProvider(id,root,data, stdout, stderr, test, bench);
        }

 
        AppPathProvider(AssemblyId id, FolderPath root, FolderPath data, FolderPath stdout, FolderPath stderr, FolderPath test, FolderPath bench)
        {
            this.AppId = id;
            this.GlobalRootDir = root;
            this.DataRootDir = data;
            this.StandardOutDir = stdout;
            this.StandardErrorDir = stderr;
            this.TestResultDir = test;
            this.BenchResultDir = bench;
        }

        public AssemblyId AppId {get;}

        public FolderPath GlobalRootDir {get;}

        public FolderPath DataRootDir {get;}

        public FolderPath StandardOutDir {get;}

        public FolderPath StandardErrorDir {get;}

        public FolderPath TestResultDir {get;}

        public FolderPath BenchResultDir {get;}

        const string sep = " := ";

        public string Format()
        {
            var dst = text.factory.Builder();
            dst.AppendLine(text.concat(nameof(AppId), sep, AppId.Format()));
            dst.AppendLine(text.concat(nameof(GlobalRootDir), sep, GlobalRootDir));
            dst.AppendLine(text.concat(nameof(DataRootDir), sep, DataRootDir));
            dst.AppendLine(text.concat(nameof(StandardOutDir), sep, StandardOutDir));
            dst.AppendLine(text.concat(nameof(StandardErrorDir), sep, StandardErrorDir));
            dst.AppendLine(text.concat(nameof(TestResultDir), sep, TestResultDir));
            dst.AppendLine(text.concat(nameof(BenchResultDir), sep, BenchResultDir));
            return dst.ToString();
        }

    }
}