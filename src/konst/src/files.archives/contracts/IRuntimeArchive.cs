//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using X = FS.Extensions;

    public interface IRuntimeArchive : IFileArchive
    {
        /// <summary>
        /// All runtime-related files in the archive
        /// </summary>
        FS.Files Files
             => Root.Files(false, X.Exe, X.Dll, X.Pdb, X.Json, X.Xml).Where(x => !x.Name.Contains("System.Private.CoreLib"));

        IModuleArchive Modules
            => Archives.modules(Root);

        FS.Files ManagedDllFiles
            => ArchiveFiles().Where(x => FS.managed(x) && x.Is(X.Dll)).Array();

        FS.Files ManagedExecutables
            => ArchiveFiles().Where(x => FS.managed(x) && x.Is(X.Exe)).Array();

        FS.Files NativeDllFiles
            => ArchiveFiles().Where(x => !FS.managed(x) && x.Is(X.Dll)).Array();

        FS.Files NativeLibFiles
            => Root.EnumerateFiles(X.Lib, true).Array();

        FS.Files NativeExecutables
            => ArchiveFiles().Where(x => !FS.managed(x) && x.Is(X.Exe)).Array();

        FS.Files ExeFiles
            => ArchiveFiles().Where(x => x.Is(X.Exe)).Array();

        FS.Files JsonFiles
            => ArchiveFiles().Where(x => x.Is(X.Json)).Array();

        FS.Files XmlFiles
            => ArchiveFiles().Where(x => x.Is(X.Xml)).Array();

        FS.Files DllFiles
            => ArchiveFiles().Where(x => x.Is(X.Dll)).Array();

        FS.Files PdbFiles
            => ArchiveFiles().Where(x => x.Is(X.Pdb)).Array();

        FS.Files JsonDepsFiles
            => Root.EnumerateFiles(X.JsonDeps, true).Array();

    }
}