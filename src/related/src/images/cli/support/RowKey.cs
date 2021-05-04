//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ImageRecords
    {
        public readonly struct RowKey : IEquatable<RowKey>, ITextual
        {
            public uint Value {get;}

            [MethodImpl(Inline)]
            public RowKey(uint value)
                => Value = value;

            [MethodImpl(Inline)]
            public RowKey(CliTableKind table, uint index)
            {
                Value = ((uint)table << 24) | (index & 0xFFFFFF);
            }

            public CliTableKind Table
            {
                [MethodImpl(Inline)]
                get => (CliTableKind)(Value >> 24);
            }

            public uint Index
            {
                [MethodImpl(Inline)]
                get => Value & 0xFFFFFF;
            }

            [MethodImpl(Inline)]
            public string Format()
                => Value.ToString("X");

            public override string ToString()
                => Format();

            public override int GetHashCode()
                => (int)Value;

            [MethodImpl(Inline)]
            public bool Equals(RowKey src)
                => Value == src.Value;

            public override bool Equals(object src)
                => src is RowKey k && Equals(k);

            [MethodImpl(Inline)]
            public static implicit operator RowKey(uint value)
                => new RowKey(value);

            [MethodImpl(Inline)]
            public static implicit operator RowKey((CliTableKind table, uint index) src)
                => new RowKey(src.table, src.index);

            [MethodImpl(Inline)]
            public static implicit operator RowKey(int value)
                => new RowKey((uint)value);
        }

        public readonly struct RowKey<T>
            where T : struct, IRecord<T>
        {
            public uint Value {get;}

            [MethodImpl(Inline)]
            public RowKey(uint value)
                => Value = value;

            [MethodImpl(Inline)]
            public static implicit operator RowKey<T>(uint value)
                => new RowKey<T>(value);

            [MethodImpl(Inline)]
            public static implicit operator RowKey<T>(int value)
                => new RowKey<T>((uint)value);

            [MethodImpl(Inline)]
            public static implicit operator RowKey(RowKey<T> src)
                => new RowKey((src.Value));
        }
    }
}