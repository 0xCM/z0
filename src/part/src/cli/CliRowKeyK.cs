//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CliRowKey<T>
        where T : struct, IRecord<T>
    {
        public uint Value {get;}

        [MethodImpl(Inline)]
        public CliRowKey(uint value)
            => Value = value;

        [MethodImpl(Inline)]
        public CliRowKey(CliTableKind table, uint index)
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
        public bool Equals(CliRowKey<T> src)
            => Value == src.Value;

        public override bool Equals(object src)
            => src is CliRowKey<T> k && Equals(k);

        [MethodImpl(Inline)]
        public string Format()
            => Value.ToString("X");

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Value;

        [MethodImpl(Inline)]
        public static implicit operator CliRowKey<T>(uint value)
            => new CliRowKey<T>(value);

        [MethodImpl(Inline)]
        public static implicit operator CliRowKey<T>(int value)
            => new CliRowKey<T>((uint)value);

        [MethodImpl(Inline)]
        public static implicit operator CliRowKey(CliRowKey<T> src)
            => new CliRowKey((src.Value));
    }
}