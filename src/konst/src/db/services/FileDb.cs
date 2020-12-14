//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Service]
    public readonly struct FileDb : IFileDb, IService<FileDb,IFileDb>
    {
        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        internal FileDb(FS.FolderPath root)
            => Root = root;
    }
}