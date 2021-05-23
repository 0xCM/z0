//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    using System.Diagnostics;

    partial interface IEnvPaths
    {
        FS.FolderPath DumpRoot()
            => FS.dir("j:/dumps");

        FS.FolderPath DumpRoot(FS.FolderPath root)
            => root;

        DumpPaths DumpPaths()
            => new DumpPaths(DumpRoot(), TableRoot() + FS.folder("dumps.tables"));

        FS.Files Dumps()
            => DumpRoot().Files(FS.Dmp);

        FS.Files Dumps(FS.FolderPath root)
            => DumpRoot(root).Files(FS.Dmp);

        FS.FilePath DumpPath(string id)
            => DumpRoot() + FS.file(id, FS.Dmp);

        FS.FileName DumpFile(Process process, Timestamp ts)
            => FS.file(ProcDumpIdentity.create(process,ts).Format(), FS.Dmp);

        FS.FilePath DumpPath(Process process, Timestamp ts)
            => DumpRoot() + DumpFile(process, ts);

        FS.FilePath DumpPath(FS.FolderPath dst, Process process, Timestamp ts)
            => dst + DumpFile(process, ts);
    }
}