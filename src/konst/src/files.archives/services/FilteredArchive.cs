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

        public string TextFilter {get;}

        public Index<FS.FileExt> ExtFilter {get;}

        [MethodImpl(Inline)]
        internal FilteredArchive(FS.FolderPath root, string filter)
        {
            Root = root;
            TextFilter = filter;
            ExtFilter = Index<FS.FileExt>.Empty;
        }

        [MethodImpl(Inline)]
        internal FilteredArchive(FS.FolderPath root, FS.FileExt[] ext)
        {
            Root = root;
            TextFilter = EmptyString;
            ExtFilter = ext;
        }

        public IEnumerable<FS.FolderPath> Directories()
            => Root.SubDirs(true);

        public Deferred<FS.FilePath> Files()
            =>  ExtFilter.IsNonEmpty
            ?  Root.EnumerateFiles(ExtFilter, true)
            :  Root.EnumerateFiles(TextFilter, true);

    }
}