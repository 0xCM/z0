//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using prim = System.Int32;
    using analog = int32_t;

    public struct int32_t : IEquatable<analog>
    {
        prim data;

        public static readonly analog zero = 0;

        public static readonly analog one = 1;

        public const int bitsize = 32;

        [MethodImpl(Inline)]
        public int32_t(prim x)
            => data = x;

        [MethodImpl(Inline)]
        public static analog @bool(bool x)
            => x ? one : zero;

        [MethodImpl(Inline)]
        public static bool operator true(analog x)
            => x.data != 0;

        [MethodImpl(Inline)]
        public static bool operator false(analog x)
            => x.data == 0;

        [MethodImpl(Inline)]
        public static implicit operator analog(prim src)
            => new analog(src);

        [MethodImpl(Inline)]
        public static implicit operator prim(analog src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator byte(analog src)
            => (byte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator sbyte(analog src)
            => (sbyte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator short(analog src)
            => (short)src.data;

        [MethodImpl(Inline)]
        public static explicit operator ushort(analog src)
            => (ushort)src.data;

        [MethodImpl(Inline)]
        public static explicit operator uint8_t(analog src)
            => (byte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator int8_t(analog src)
            => (sbyte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator int16_t(analog src)
            => (short)src.data;

        [MethodImpl(Inline)]
        public static explicit operator uint16_t(analog src)
            => (ushort)src.data;

        [MethodImpl(Inline)]
        public static explicit operator ulong(analog src)
            => (ulong)src.data;

        [MethodImpl(Inline)]
        public static implicit operator float(analog src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator double(analog src)
            => src.data;

        [MethodImpl(Inline)]
        public static analog operator + (analog lhs, analog rhs)
            => lhs.data + rhs.data;

        [MethodImpl(Inline)]
        public static analog operator - (analog lhs, analog rhs)
            => lhs.data - rhs.data;

        [MethodImpl(Inline)]
        public static analog operator * (analog lhs, analog rhs)
            => lhs.data * rhs.data;

        [MethodImpl(Inline)]
        public static analog operator / (analog lhs, analog rhs)
            => lhs.data / rhs.data;

        [MethodImpl(Inline)]
        public static analog operator % (analog lhs, analog rhs)
            => lhs.data % rhs.data;

        [MethodImpl(Inline)]
        public static analog operator & (analog lhs, analog rhs)
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static analog operator | (analog lhs, analog rhs)
            => lhs.data | rhs.data;

        [MethodImpl(Inline)]
        public static analog operator ^ (analog lhs, analog rhs)
            => lhs.data ^ rhs.data;

        [MethodImpl(Inline)]
        public static analog operator >> (analog lhs, int rhs)
            => lhs.data >> rhs;

        [MethodImpl(Inline)]
        public static analog operator << (analog lhs, int rhs)
            => lhs.data << rhs;

        [MethodImpl(Inline)]
        public static analog operator ~ (analog src)
            => ~ src.data;

        [MethodImpl(Inline)]
        public static analog operator - (analog src)
            => (analog)(-src.data);

        [MethodImpl(Inline)]
        public static analog operator -- (analog src)
            =>  --src.data;

        [MethodImpl(Inline)]
        public static analog operator ++ (analog src)
            =>  ++src.data;

        [MethodImpl(Inline)]
        public static analog operator < (analog lhs, analog rhs)
            => @bool(lhs.data < rhs.data);

        [MethodImpl(Inline)]
        public static analog operator + (analog lhs, int16_t rhs)
            => lhs.data + (analog)rhs;

        [MethodImpl(Inline)]
        public static analog operator - (analog lhs, int16_t rhs)
            => lhs.data - (analog)rhs;

        [MethodImpl(Inline)]
        public static analog operator * (analog lhs, int16_t rhs)
            => lhs.data * (analog)rhs;

        [MethodImpl(Inline)]
        public static analog operator / (analog lhs, int16_t rhs)
            => lhs.data / (analog)rhs;

        [MethodImpl(Inline)]
        public static analog operator <= (analog lhs, analog rhs)
            => @bool(lhs.data <= rhs.data);

        [MethodImpl(Inline)]
        public static analog operator > (analog lhs, analog rhs)
            => @bool(lhs.data > rhs.data);

        [MethodImpl(Inline)]
        public static analog operator >= (analog lhs, analog rhs)
            => @bool(lhs.data >= rhs.data);

        [MethodImpl(Inline)]
        public static analog operator == (analog lhs, analog rhs)
            => @bool(lhs.data == rhs.data);

        [MethodImpl(Inline)]
        public static analog operator != (analog lhs, analog rhs)
            => @bool(lhs.data != rhs.data);

        [MethodImpl(Inline)]
        public bool Equals(analog rhs)
            => data == rhs.data;

        public override int GetHashCode()
            => data.GetHashCode();

        public override bool Equals(object rhs)
            => rhs is analog a && Equals(a);

        public override string ToString()
            => data.ToString();

    }
}
