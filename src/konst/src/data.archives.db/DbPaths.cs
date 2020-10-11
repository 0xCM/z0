//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct DbPaths : IDbPaths
    {
        public static DbPaths create()
        {
            var dst = new DbPaths();
            dst.DbRoot = FS.dir(@"j:\database");
            return dst;
        }

        public static DbPaths create(IWfShell wf)
        {
            var dst = new DbPaths();
            dst.DbRoot = FS.dir(@"j:\database");
            return dst;
        }

        public FS.FolderPath DbRoot;

        public FS.FolderPath TableRoot()
            => DbRoot + FS.folder("tables");

        public FS.FolderPath DocRoot()
            => DbRoot + FS.folder("docs");

        public FS.FolderPath StageRoot()
            => DbRoot + FS.folder("stage");

        public FS.FolderPath SourceRoot()
            => DbRoot + FS.folder("sources");

        public FS.FilePath Doc(string name, FS.FileExt ext)
            => DocRoot() + FS.file(name, ext);

        FS.FolderPath IDbPaths.DbRoot
            => DbRoot;
    }
}