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
    using static z;

    /// <summary>
    /// Defines a rooted archive over files with specified extensions
    /// </summary>
    public readonly struct FileKinds : IFileArchive
    {
        public FS.FolderPath Root {get;}

        public FS.FileExt[] Ext {get;}

        [MethodImpl(Inline)]
        public FileKinds(FS.FolderPath root, FS.FileExt[] ext)
        {
            Root = root;
            Ext = ext;
        }

        public IEnumerable<FS.FilePath> Files()
            => Root.EnumerateFiles(true, Ext);
    }
}