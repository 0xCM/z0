//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct FileDbPaths : IFileDbPaths<FileDbPaths>
    {
        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public FileDbPaths(FS.FolderPath root)
            => Root = root;

        [MethodImpl(Inline)]
        public static implicit operator FileDbPaths(FS.FolderPath root)
            => new FileDbPaths(root);
    }
}