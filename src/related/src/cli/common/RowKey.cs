//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Images
    {
        public readonly struct RowKey
        {
            public uint Value {get;}

            [MethodImpl(Inline)]
            public RowKey(uint value)
                => Value = value;

            [MethodImpl(Inline)]
            public static implicit operator RowKey(uint value)
                => new RowKey(value);

            [MethodImpl(Inline)]
            public static implicit operator RowKey(int value)
                => new RowKey((uint)value);
        }
    }
}