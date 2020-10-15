//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static z;
    using static Konst;
    using static ArchiveFileKinds;

    public readonly struct RuntimeArchive : IFileArchive<RuntimeArchive>
    {
        public FS.FolderPath Root {get;}

        public FS.Files Files {get;}

        public static RuntimeArchive create()
            => new RuntimeArchive(FS.dir(RuntimeEnvironment.GetRuntimeDirectory()));

        [MethodImpl(Inline)]
        internal RuntimeArchive(FS.FolderPath root)
        {
            Root = root;
            Files = root.Files(false, Exe, Dll, Pdb).Where(x => !x.Name.Contains("System.Private.CoreLib"));
        }

        public Files ManagedLibraries
        {
            get => Files.Where(x => FS.managed(x) && x.Is(Dll)).Array();
        }

        public Files ManagedExecutables
        {
            get => Files.Where(x => FS.managed(x) && x.Is(Exe)).Array();
        }

        public Files NativeLibraries
        {
            get => Files.Where(x => !FS.managed(x) && x.Is(ArchiveFileKinds.Dll)).Array();
        }

        public Files NativeExecutables
        {
            get => Files.Where(x => !FS.managed(x) && x.Is(Exe)).Array();
        }

        public Files PdbFiles
        {
            get => Files.Where(x => x.Is(Pdb)).Array();
        }

    }
}