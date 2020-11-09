//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Projected<S,T>
    {
        public S Source {get;}

        public T Target {get;}

        [MethodImpl(Inline)]
        public Projected(S src, T dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator Projected<S,T>(Paired<S,T> src)
            => new Projected<S,T>(src.Left, src.Right);
    }
}