//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using PN = DbPartitionNames;

    public struct DbPaths : IDbPaths
    {
        public static DbPaths create(IWfShell wf)
        {
            var dst = new DbPaths();
            dst.DbRoot = EnvRules.Default.DbRoot();
            return dst;
        }

        public FS.FolderPath DbRoot;

        public FS.FolderPath TableRoot()
            => DbRoot + FS.folder(PN.Tables);

        public FS.FolderPath DocRoot()
            => DbRoot + FS.folder(PN.Docs);

        public FS.FolderPath StageRoot()
            => DbRoot + FS.folder(PN.Stage);

        public FS.FolderPath SourceRoot()
            => DbRoot + FS.folder(PN.Sources);

        public FS.FilePath Doc(string name, FS.FileExt ext)
            => DocRoot() + FS.file(name, ext);

        FS.FolderPath IDbPaths.DbRoot
            => DbRoot;
    }
}