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
        FS.Files Files
             => Root.Files(false, Exe, Dll, Pdb, Json, Xml).Where(x => !x.Name.Contains("System.Private.CoreLib"));

        IModuleArchive Modules
            => ModuleArchive.create(Root);

        FS.Files ManagedDllFiles
            => ArchiveFiles().Where(x => FS.managed(x) && x.Is(Dll)).Array();

        FS.Files ManagedExecutables
            => ArchiveFiles().Where(x => FS.managed(x) && x.Is(Exe)).Array();

        FS.Files NativeDllFiles
            => ArchiveFiles().Where(x => !FS.managed(x) && x.Is(Dll)).Array();

        FS.Files NativeLibFiles
            => Root.EnumerateFiles(Lib, true).Array();

        FS.Files NativeExecutables
            => ArchiveFiles().Where(x => !FS.managed(x) && x.Is(Exe)).Array();

        FS.Files ExeFiles
            => ArchiveFiles().Where(x => x.Is(Exe)).Array();

        FS.Files JsonFiles
            => ArchiveFiles().Where(x => x.Is(Json)).Array();

        FS.Files XmlFiles
            => ArchiveFiles().Where(x => x.Is(Xml)).Array();

        FS.Files DllFiles
            => ArchiveFiles().Where(x => x.Is(Dll)).Array();

        FS.Files PdbFiles
            => ArchiveFiles().Where(x => x.Is(Pdb)).Array();

        FS.Files JsonDepsFiles
            => Root.EnumerateFiles(JsonDeps, true).Array();
    }
}