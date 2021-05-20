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
        where S : struct, IFileType<S>
        where T : struct, IFileType<T>
    {
        public TypedFile<S> Source {get;}

        public TypedFile<T> Target {get;}

        [MethodImpl(Inline)]
        public FileFlow(TypedFile<S> src, TypedFile<T> dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator FileFlow<S,T>((TypedFile<S> src, TypedFile<T> dst) x)
            => new FileFlow<S,T>(x.src,x.dst);
    }
}