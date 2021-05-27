//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static FS;

    public interface IRuntimeArchive : IFileArchive
    {
        /// <summary>
        /// All runtime-related files in the archive
        /// </summary>
        new FS.Files Files
             => Root.Files(false, Exe, Dll, Pdb, Json, Xml).Where(x => !x.Name.Contains("System.Private.CoreLib"));

        FS.Files ManagedDllFiles
            => Files().Where(x => FS.managed(x) && x.Is(Dll)).Array();

        FS.Files ManagedExecutables
            => Files().Where(x => FS.managed(x) && x.Is(Exe)).Array();

        FS.Files NativeDllFiles
            => Files().Where(x => !FS.managed(x) && x.Is(Dll)).Array();

        FS.Files NativeLibFiles
            => Root.EnumerateFiles(Lib, true).Array();

        FS.Files NativeExecutables
            => Files().Where(x => !FS.managed(x) && x.Is(Exe)).Array();

        FS.Files ExeFiles
            => Files().Where(x => x.Is(Exe)).Array();

        FS.Files JsonFiles
            => Files().Where(x => x.Is(Json)).Array();

        FS.Files XmlFiles
            => Files().Where(x => x.Is(Xml)).Array();

        FS.Files DllFiles
            => Files().Where(x => x.Is(Dll)).Array();

        FS.Files PdbFiles
            => Files().Where(x => x.Is(Pdb)).Array();
    }
}