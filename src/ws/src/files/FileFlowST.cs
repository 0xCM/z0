//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct FileFlow<S,T> : IDataFlow<S,T>
        where S : struct, ITypedFile
        where T : struct, ITypedFile
    {
        public S Source {get;}

        public T Target {get;}

        [MethodImpl(Inline)]
        public FileFlow(S src, T dst)
        {
            Source = src;
            Target = dst;
        }

        public string Format()
            => string.Format("{0} -> {1}", Source, Target);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator FileFlow<S,T>((S src, T dst) x)
            => new FileFlow<S,T>(x.src, x.dst);
    }
}