//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct Sequential<T> : ITextual
        where T : unmanaged
    {
        public T Value;

        [MethodImpl(Inline)]
        public static Sequential<T> operator ++(Sequential<T> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator Sequential<T>(T src)
            => new Sequential<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(Sequential<T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public Sequential(T src)
            => Value = src;

        [MethodImpl(Inline)]
        public string Format()
            => Value.ToString();
    }
}