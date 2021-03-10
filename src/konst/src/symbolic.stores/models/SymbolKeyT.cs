//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct SymbolKey<T>
        where T : unmanaged
    {
        public T Value {get;}

        [MethodImpl(Inline)]
        public SymbolKey(T value)
            => Value = value;

        [MethodImpl(Inline)]
        public bool Equals(SymbolKey<T> src)
            => bw64(Value) == bw64(src.Value);

        [MethodImpl(Inline)]
        public static implicit operator SymbolKey<T>(T value)
            => new SymbolKey<T>(value);

        [MethodImpl(Inline)]
        public static implicit operator SymbolKey(SymbolKey<T> src)
            => new SymbolKey(bw64(src.Value));
    }
}