//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FS
    {
        /// <summary>
        /// Defines a kind-discriminated file path
        /// </summary>
        public struct FilePath<K> : IFile<K>
            where K : unmanaged
        {
            public FS.FilePath Path {get;}

            public K Kind {get;}

            [MethodImpl(Inline)]
            public FilePath(FS.FilePath path, K kind)
            {
                Kind = kind;
                Path = path;
            }

            [MethodImpl(Inline)]
            public static implicit operator FilePath(FilePath<K> src)
                => src.Path;
        }
    }
}
