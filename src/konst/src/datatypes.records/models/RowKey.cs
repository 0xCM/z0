//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RowKey
    {
        public ulong Value {get;}

        [MethodImpl(Inline)]
        public RowKey(ulong value)
            => Value = value;

        [MethodImpl(Inline)]
        public static implicit operator RowKey(ulong value)
            => new RowKey(value);
    }
}