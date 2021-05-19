//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct FileFlow<S,P,T> : IFileFlow<S,P,T>
        where S : struct, IFilePath<S>, IFileType<S>
        where T : struct, IFilePath<T>, IFileType<T>
        where P : IFileProcessor<S,T>
    {
        public FilePath<S> Source {get;}

        public P Processor {get;}

        public FilePath<T> Target {get;}

        [MethodImpl(Inline)]
        public FileFlow(FilePath<S> src, P processor, FilePath<T> dst)
        {
            Source = src;
            Processor = processor;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator FileFlow<S,P,T>((FilePath<S> src, P p, FilePath<T> dst) x)
            => new FileFlow<S,P,T>(x.src, x.p, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator FileFlow(FileFlow<S,P,T> src)
            => new FileFlow(
                    src.Source.Path, src.Source.FileType.Untyped,
                    src.Target.Path, src.Target.FileType.Untyped
                    );
    }
}