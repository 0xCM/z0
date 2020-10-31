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
        IEnumerable<FS.FilePath> ExeFiles()
            => Files(Exe);

        IEnumerable<FS.FilePath> JsonDepsFiles()
            => Files(JsonDeps);

        IEnumerable<FS.FilePath> DllFiles()
            => Files(Dll);

        IEnumerable<FS.FilePath> PdbFiles()
            => Files(Pdb);

        IEnumerable<FS.FilePath> LibFiles()
            => Files(Lib);
    }
}