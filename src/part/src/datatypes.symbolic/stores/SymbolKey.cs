//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SymbolKey
    {
        public ulong Value {get;}

        [MethodImpl(Inline)]
        public SymbolKey(ulong value)
            => Value = value;

        [MethodImpl(Inline)]
        public bool Equals(SymbolKey<ulong> src)
            => Value == src.Value;

        [MethodImpl(Inline)]
        public static implicit operator SymbolKey(ulong value)
            => new SymbolKey(value);
    }
}