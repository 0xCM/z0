//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using Wrapped = System.Byte;
    using Wrapper = AsmByte;

    /// <summary>
    /// Represents an encoded instruction byte
    /// </summary>
    public readonly struct AsmByte : IDataTypeComparable<Wrapper>
    {
        public Wrapped Value {get;}

        [MethodImpl(Inline)]
        public AsmByte(Wrapped value)
            => Value = value;

        [MethodImpl(Inline)]
        public string Format()
            => Value.FormatHex(specifier:false);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Value.GetHashCode();

        public override bool Equals(object src)
            => src is Wrapper a && Equals(a);

        [MethodImpl(Inline)]
        public int CompareTo(Wrapper src)
            => Value.CompareTo(src.Value);

        [MethodImpl(Inline)]
        public bool Equals(Wrapper src)
            => Value.Equals(src.Value);

        [MethodImpl(Inline)]
        public static bit operator == (Wrapper a, Wrapper b)
            => a.Value == b.Value;

        [MethodImpl(Inline)]
        public static bit operator != (Wrapper a, Wrapper b)
            => a.Value != b.Value;

        [MethodImpl(Inline)]
        public static bit operator < (Wrapper a, Wrapper b)
            => a.Value < b.Value;

        [MethodImpl(Inline)]
        public static bit operator <= (Wrapper a, Wrapper b)
            => a.Value <= b.Value;

        [MethodImpl(Inline)]
        public static bit operator > (Wrapper a, Wrapper b)
            => a.Value > b.Value;

        [MethodImpl(Inline)]
        public static bit operator >= (Wrapper a, Wrapper b)
            => a.Value >= b.Value;

        [MethodImpl(Inline)]
        public static Wrapper operator & (Wrapper a, Wrapper b)
            => (Wrapper)(a.Value & b.Value);

        [MethodImpl(Inline)]
        public static Wrapper operator | (Wrapper a, Wrapper b)
            => (Wrapper)(a.Value | b.Value);

        [MethodImpl(Inline)]
        public static Wrapper operator ^ (Wrapper a, Wrapper b)
            => (Wrapper)(a.Value ^ b.Value);

        [MethodImpl(Inline)]
        public static Wrapper operator >> (Wrapper a, int offset)
            => (Wrapper)(a.Value >> offset);

        [MethodImpl(Inline)]
        public static Wrapper operator << (Wrapper a, int offset)
            => (Wrapper)(a.Value << offset);

        [MethodImpl(Inline)]
        public static Wrapper operator ~ (Wrapper x)
            => (Wrapper)~ x.Value;

        [MethodImpl(Inline)]
        public static implicit operator Wrapper(Wrapped src)
            => new Wrapper(src);
    }
}