//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct FileArchive : IFileArchive
    {
        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public FileArchive(FS.FolderPath root)
            => Root = root;

        [MethodImpl(Inline)]
        public static implicit operator FileArchive(FS.FolderPath src)
            => new FileArchive(src);
    }
}