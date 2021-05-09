//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CliRowKey : IEquatable<CliRowKey>, ITextual
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

        public uint Row
        {
            [MethodImpl(Inline)]
            get => Value & 0xFFFFFF;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format("{0:x2}:{1:x6}", (byte)Table, Row);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Value;

        [MethodImpl(Inline)]
        public bool Equals(CliRowKey src)
            => Value == src.Value;

        public override bool Equals(object src)
            => src is CliRowKey k && Equals(k);

        [MethodImpl(Inline)]
        public static implicit operator CliRowKey(uint value)
            => new CliRowKey(value);

        [MethodImpl(Inline)]
        public static implicit operator CliRowKey((CliTableKind table, uint index) src)
            => new CliRowKey(src.table, src.index);

        [MethodImpl(Inline)]
        public static implicit operator CliRowKey(int value)
            => new CliRowKey((uint)value);


        [MethodImpl(Inline)]
        public static implicit operator CliToken(CliRowKey src)
            => src;
    }
}