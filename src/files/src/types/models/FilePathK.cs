//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct FilePath<K> : IFilePath<FilePath<K>,K>
        where K : struct, IFileType<K>
    {
        public FS.FilePath Path {get;}

        public K FileType {get;}

        [MethodImpl(Inline)]
        public FilePath(FS.FilePath path, K kind)
        {
            FileType = kind;
            Path = path;
        }

        [MethodImpl(Inline)]
        public static implicit operator FS.FilePath(FilePath<K> src)
            => src.Path;

        [MethodImpl(Inline)]
        public static implicit operator K(FilePath<K> src)
            => src.FileType;

        [MethodImpl(Inline)]
        public static implicit operator FilePath<K>((FS.FilePath path, K kind) src)
            => new FilePath<K>(src.path,src.kind);
    }
}
