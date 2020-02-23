//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;
    using static As;

    public readonly struct Any<T>
    {
        public static Any<T> From<S>(in S src)
            => new Any<T>(Unsafe.As<S,T>(ref Unsafe.AsRef(src)));
        
        [MethodImpl(Inline)]
        public static implicit operator Any<T>(T src)
            => new Any<T>();

        [MethodImpl(Inline)]
        public static implicit operator T(Any<T> src)
            => src.Contained;

        [MethodImpl(Inline)]
        public Any(T src)
            => this.Contained = src;
        
        public readonly T Contained;

        [MethodImpl(Inline)]
        public Any<S> As<S>()
            => new Any<S>(Unsafe.As<T,S>(ref Unsafe.AsRef(in Contained)));
    }
}