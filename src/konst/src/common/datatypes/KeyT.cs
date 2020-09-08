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

    public readonly struct Key<T>
        where T : unmanaged
    {
        readonly T Value;

        [MethodImpl(Inline)]
        public static implicit operator Key<T>(T src)
            => new Key<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(Key<T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public Key(T src)
            => Value = src;

        public string Format()
            => Value.ToString();
    }
}