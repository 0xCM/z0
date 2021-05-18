//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct FileFlow<S,T> : IFileFlow<S,T>
        where S : struct, IFilePath<S>, IFileType<S>
        where T : struct, IFilePath<T>, IFileType<T>
    {
        public FilePath<S> Source {get;}

        public FilePath<T> Target {get;}

        [MethodImpl(Inline)]
        public FileFlow(FilePath<S> src, FilePath<T> dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator FileFlow<S,T>((FilePath<S> src, FilePath<T> dst) x)
            => new FileFlow<S,T>(x.src,x.dst);

        [MethodImpl(Inline)]
        public static implicit operator FileFlow(FileFlow<S,T> src)
            => new FileFlow(
                    src.Source.Path, src.Source.FileType.Untyped,
                    src.Target.Path, src.Target.FileType.Untyped
                    );

    }
}