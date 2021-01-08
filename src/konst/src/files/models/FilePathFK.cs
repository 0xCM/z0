//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct FS
    {
        public struct FilePath<K> : IFile<FilePath<K>,K>
            where K : struct, IFileKind<K>
        {
            public FS.FilePath Path {get;}

            public K Kind {get;}

            public Type FileType {get;}

            [MethodImpl(Inline)]
            public FilePath(FS.FilePath path, K kind)
            {
                Kind = kind;
                Path = path;
                FileType = typeof(K);
            }

            [MethodImpl(Inline)]
            public static implicit operator FilePath(FilePath<K> src)
                => src.Path;
        }
    }
}
