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

    public readonly struct FileDb : IFileDbHost<FileDb>
    {
        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public static implicit operator FileDb(FS.FolderPath src)
            => new FileDb(src);

        [MethodImpl(Inline)]
        public FileDb(FS.FolderPath root)
            => Root = root;
    }
}