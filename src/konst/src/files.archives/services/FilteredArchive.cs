//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    public readonly struct FilteredArchive : IFileArchive
    {
        public FS.FolderPath Root {get;}

        public string Filter {get;}

        [MethodImpl(Inline)]
        internal FilteredArchive(FS.FolderPath root, string filter)
        {
            Root = root;
            Filter = filter;
        }

        public IEnumerable<FS.FolderPath> Directories()
            => Root.SubDirs(true);

        public IEnumerable<FS.FilePath> Files()
            => Root.Files(Filter, true);

        public IEnumerable<FS.FilePath> Files(FS.FileExt ext)
            => Root.Files(ext, true);
    }
}