//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct RowKey<T>
        where T : struct, IRecord<T>
    {
        public uint Value {get;}

        public RowKey(uint value)
            => Value = value;

        public static implicit operator RowKey<T>(uint value)
            => new RowKey<T>(value);

        public static implicit operator RowKey(RowKey<T> src)
            => new RowKey(src.Value);
    }

    public readonly struct RowKey
    {
        public uint Value {get;}

        public RowKey(uint value)
            => Value = value;

        public static implicit operator RowKey(uint value)
            => new RowKey(value);
    }
}