//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct Consequence<T>
    {
        public T C{get;}

        [MethodImpl(Inline)]
        public Consequence(T src)
            => C = src;

        [MethodImpl(Inline)]
        public static implicit operator Consequence<T>(T src)
            => new Consequence<T>(src);
    }
}