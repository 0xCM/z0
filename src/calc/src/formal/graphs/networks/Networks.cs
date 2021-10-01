//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly partial struct Networks
    {
        public readonly struct Pipe<S,T>
        {
            public readonly S Source;

            public readonly T Target;

            [MethodImpl(Inline)]
            public Pipe(S src, T dst)
            {
                Source = src;
                Target = dst;
            }

            [MethodImpl(Inline)]
            public static implicit operator Pipe<S,T>((S src, T dst) x)
                => new Pipe<S,T>(x.src, x.dst);
        }
    }
}
