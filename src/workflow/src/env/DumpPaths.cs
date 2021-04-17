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

        FS.FilePath DumpPath(string id)
            => DumpRoot() + FS.file(id, FS.Dmp);

        FS.FileName DumpFile(Process process, Timestamp ts)
            => FS.file(string.Format("{0}.{1}", process.ProcessName, ts.Format()), FS.Dmp);

        FS.FilePath DumpPath(Process process, Timestamp ts)
            => DumpRoot() + DumpFile(process, ts);

        FS.FilePath DumpPath(FS.FolderPath dst, Process process, Timestamp ts)
            => dst + DumpFile(process, ts);
    }
}