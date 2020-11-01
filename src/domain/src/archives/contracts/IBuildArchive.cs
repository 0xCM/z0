//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;
    using static z;

    using System.Collections.Generic;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IBuildArchive : IFileArchive<BuildArchive>
    {
        IEnumerable<FS.FilePath> BuildFiles(FS.FileExt ext)
            => Root.EnumerateFiles(ext, true);

        IEnumerable<FS.FilePath> ExeFiles()
            => BuildFiles(Exe);

        IEnumerable<FS.FilePath> JsonDepsFiles()
            => BuildFiles(JsonDeps);

        IEnumerable<FS.FilePath> DllFiles()
            => BuildFiles(Dll);

        IEnumerable<FS.FilePath> PdbFiles()
            => BuildFiles(Pdb);

        IEnumerable<FS.FilePath> LibFiles()
            => BuildFiles(Lib);
    }
}