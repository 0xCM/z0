//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DataFlow<S,T> : IDataFlow<S,T>
    {
        public readonly S Source;

        public readonly T Target;

        [MethodImpl(Inline)]
        public static implicit operator DataFlow<S,T> ((S src, T dst) x)
            => new DataFlow<S,T>(x.src, x.dst);

        [MethodImpl(Inline)]
        public DataFlow(S src, T dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(RenderPatterns.Arrow, Source, Target);

        S IDataFlow<S,T>.Source
            => Source;

        T IDataFlow<S,T>.Target
            => Target;
    }
}