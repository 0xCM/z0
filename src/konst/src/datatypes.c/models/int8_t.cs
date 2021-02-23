//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using Wrapped = System.SByte;
    using Wrapper = int8_t;

    public struct int8_t : IEquatable<Wrapper>, IComparable<Wrapper>
    {
        Wrapped Value;

        [MethodImpl(Inline)]
        public int8_t(Wrapped src)
            => Value =src;

        [MethodImpl(Inline)]
        public bool Equals(Wrapper src)
            => Value == src.Value;

        [MethodImpl(Inline)]
        public int CompareTo(Wrapper src)
            => Value.CompareTo(src.Value);

        public override int GetHashCode()
            => Value.GetHashCode();

        public override bool Equals(object src)
            => src is Wrapper a && Equals(a);

        public override string ToString()
            => Value.ToString();

        [MethodImpl(Inline)]
        public static Wrapper @bool(bool src)
            => src ? one : zero;

        [MethodImpl(Inline)]
        public static bool operator true(Wrapper src)
            => src.Value != 0;

        [MethodImpl(Inline)]
        public static bool operator false(Wrapper src)
            => src.Value == 0;

        [MethodImpl(Inline)]
        public static implicit operator Wrapper(Wrapped src)
            => new Wrapper(src);

        [MethodImpl(Inline)]
        public static implicit operator Wrapped(Wrapper src)
            => src.Value;

        [MethodImpl(Inline)]
        public static explicit operator byte(Wrapper src)
            => (byte)src.Value;

        [MethodImpl(Inline)]
        public static explicit operator short(Wrapper src)
            => (short)src.Value;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Wrapper src)
            => (byte)src.Value;

        [MethodImpl(Inline)]
        public static explicit operator int(Wrapper src)
            => (int)src.Value;

        [MethodImpl(Inline)]
        public static explicit operator uint(Wrapper src)
            => (uint)src.Value;

        [MethodImpl(Inline)]
        public static explicit operator long(Wrapper src)
            => (long)src.Value;

        [MethodImpl(Inline)]
        public static explicit operator ulong(Wrapper src)
            => (ulong)src.Value;

        [MethodImpl(Inline)]
        public static implicit operator float(Wrapper src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator double(Wrapper src)
            => src.Value;

        [MethodImpl(Inline)]
        public static Wrapper operator == (Wrapper a, Wrapper b)
            => @bool(a.Value == b.Value);

        [MethodImpl(Inline)]
        public static Wrapper operator != (Wrapper a, Wrapper b)
            => @bool(a.Value != b.Value);

        [MethodImpl(Inline)]
        public static Wrapper operator + (Wrapper a, Wrapper b)
            => (Wrapper)(a.Value + b.Value);

        [MethodImpl(Inline)]
        public static Wrapper operator - (Wrapper a, Wrapper b)
            => (Wrapper)(a.Value - b.Value);

        [MethodImpl(Inline)]
        public static Wrapper operator * (Wrapper a, Wrapper b)
            => (Wrapper)(a.Value * b.Value);

        [MethodImpl(Inline)]
        public static Wrapper operator / (Wrapper a, Wrapper b)
            => (Wrapper)(a.Value / b.Value);

        [MethodImpl(Inline)]
        public static Wrapper operator % (Wrapper a, Wrapper b)
            => (Wrapper)(a.Value % b.Value);

        [MethodImpl(Inline)]
        public static Wrapper operator < (Wrapper a, Wrapper b)
            => @bool(a.Value < b.Value);

        [MethodImpl(Inline)]
        public static Wrapper operator <= (Wrapper a, Wrapper b)
            => @bool(a.Value <= b.Value);

        [MethodImpl(Inline)]
        public static Wrapper operator > (Wrapper a, Wrapper b)
            => @bool(a.Value > b.Value);

        [MethodImpl(Inline)]
        public static Wrapper operator >= (Wrapper a, Wrapper b)
            => @bool(a.Value >= b.Value);

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
        public static Wrapper operator - (Wrapper src)
            => (Wrapper)(-src.Value);

        [MethodImpl(Inline)]
        public static Wrapper operator -- (Wrapper src)
            =>  --src.Value;

        [MethodImpl(Inline)]
        public static Wrapper operator ++ (Wrapper src)
            =>  ++src.Value;

        public static Wrapper zero => 0;

        public static Wrapper one => 1;
    }
}