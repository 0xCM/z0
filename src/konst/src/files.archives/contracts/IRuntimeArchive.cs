//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IRuntimeArchive : IFileArchive
    {
        FS.Files ManagedLibraries
            => ArchivedFiles().Where(x => FS.managed(x) && x.Is(Dll)).Array();

        FS.Files ManagedExecutables
            => ArchivedFiles().Where(x => FS.managed(x) && x.Is(Exe)).Array();

        FS.Files NativeLibraries
            => ArchivedFiles().Where(x => !FS.managed(x) && x.Is(Dll)).Array();

        FS.Files NativeExecutables
            => ArchivedFiles().Where(x => !FS.managed(x) && x.Is(Exe)).Array();

        FS.Files ExeFiles
            => ArchivedFiles().Where(x => x.Is(Exe)).Array();

        FS.Files JsonFiles
            => ArchivedFiles().Where(x => x.Is(Json)).Array();

        FS.Files XmlFiles
            => ArchivedFiles().Where(x => x.Is(Xml)).Array();

        FS.Files DllFiles
            => ArchivedFiles().Where(x => x.Is(Dll)).Array();

        FS.Files PdbFiles
            => ArchivedFiles().Where(x => x.Is(Pdb)).Array();
    }
}