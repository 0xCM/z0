//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static UI;

    using S = uint8T;
    using W = W8;
    using K = BitSeq8;
    using T = System.Byte;
    using N = N8;

    /// <summary>
    /// Represents the value of a type-level octet and thus is an integer in the range [0,255]
    /// </summary>
    public readonly struct uint8T : ISizedInt<S,W,K,T>
    {
        internal readonly T data;

        [MethodImpl(Inline)]
        public uint8T(byte x)
            => data = x;

        [MethodImpl(Inline)]
        public uint8T(K x)
            => data =(byte)x;

        [MethodImpl(Inline)]
        internal uint8T(BitState src)
            => data = (byte)src;

        public const T MinLiteral = 0;

        public const T MaxLiteral = byte.MaxValue;

        /// <summary>
        /// Specifies the bit-width represented by <see cref='S'/>
        /// </summary>
        public const byte Width = 8;

        public const uint Mod = 256;

        public static W W => default;

        public static N N => default;

        public static S Zero => 0;

        public static S One => 1;

        /// <summary>
        /// Specifies the minimum <see cref='S'/> value
        /// </summary>
        public static S Min
        {
            [MethodImpl(Inline)]
            get => new S(MinLiteral);
        }

        /// <summary>
        /// Specifies the maximum <see cref='S'/> value
        /// </summary>
        public static S Max
        {
            [MethodImpl(Inline)]
            get => new S(MaxLiteral);
        }

        [MethodImpl(Inline)]
        public static implicit operator S(K src)
            => new S(src);

        [MethodImpl(Inline)]
        public static implicit operator K(S src)
            => (K)src.data;

        [MethodImpl(Inline)]
        public static S @bool(bool x)
            => x ? One : Zero;

        [MethodImpl(Inline)]
        public static bool operator true(S x)
            => x.data != 0;

        [MethodImpl(Inline)]
        public static bool operator false(S x)
            => x.data == 0;

        [MethodImpl(Inline)]
        public static implicit operator S(byte src)
            => new S(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(S src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator sbyte(S src)
            => (sbyte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator short(S src)
            => (short)src.data;

        [MethodImpl(Inline)]
        public static implicit operator ushort(S src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint16_t(S src)
            => (ushort)src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint32_t(S src)
            => (uint)src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint64_t(S src)
            => (ulong)src.data;

        [MethodImpl(Inline)]
        public static explicit operator int(S src)
            => (int)src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint(S src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator long(S src)
            => (long)src.data;

        [MethodImpl(Inline)]
        public static implicit operator ulong(S src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator float(S src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator double(S src)
            => src.data;

        [MethodImpl(Inline)]
        public static S operator == (S x, S y)
            => @bool(x.data == y.data);

        [MethodImpl(Inline)]
        public static S operator != (S x, S y)
            => @bool(x.data != y.data);

        [MethodImpl(Inline)]
        public static S operator + (S x, S y)
            => wrap(x.data + y.data);

        [MethodImpl(Inline)]
        public static S operator - (S x, S y)
            => wrap(x.data - y.data);

        [MethodImpl(Inline)]
        public static S operator * (S x, S y)
            => wrap(x.data * y.data);

        [MethodImpl(Inline)]
        public static S operator / (S x, S y)
            => wrap(x.data / y.data);

        [MethodImpl(Inline)]
        public static S operator % (S x, S y)
            => wrap(x.data % y.data);

        [MethodImpl(Inline)]
        public static S operator < (S x, S y)
            => @bool(x.data < y.data);

        [MethodImpl(Inline)]
        public static S operator <= (S x, S y)
            => @bool(x.data <= y.data);

        [MethodImpl(Inline)]
        public static S operator > (S x, S y)
            => @bool(x.data > y.data);

        [MethodImpl(Inline)]
        public static S operator >= (S x, S y)
            => @bool(x.data >= y.data);

        [MethodImpl(Inline)]
        public static S operator & (S x, S y)
            => (S)(x.data & y.data);

        [MethodImpl(Inline)]
        public static S operator | (S x, S y)
            => wrap(x.data | y.data);

        [MethodImpl(Inline)]
        public static S operator ^ (S x, S y)
            => wrap(x.data ^ y.data);

        [MethodImpl(Inline)]
        public static S operator >> (S x, int y)
            => wrap(x.data >> y);

        [MethodImpl(Inline)]
        public static S operator << (S x, int y)
            => wrap(x.data << y);

        [MethodImpl(Inline)]
        public static S operator ~ (S src)
            => wrap(~ src.data);

        [MethodImpl(Inline)]
        public static S operator - (S src)
            => wrap(~src.data + 1);

        [MethodImpl(Inline)]
        public static S operator -- (S src)
            => dec(src);

        [MethodImpl(Inline)]
        public static S operator ++ (S src)
            => inc(src);

        /// <summary>
        /// Queries the state of an index-identified bit
        /// </summary>
        public BitState this[byte pos]
        {
            [MethodImpl(Inline)]
            get => test(this, pos);
        }

        public K Kind
        {
            [MethodImpl(Inline)]
            get => (K) data;
        }

        public T Content
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public bool IsZero
        {
            [MethodImpl(Inline)]
            get => data == 0;
        }

        public bool IsNonZero
        {
            [MethodImpl(Inline)]
            get => data != 0;
        }

        /// <summary>
        /// Specifies whether the current value is the maximum value
        /// </summary>
        public bool IsMax
        {
            [MethodImpl(Inline)]
            get => data == MaxLiteral;
        }

        /// <summary>
        /// Specifies whether the current value is the minimum value
        /// </summary>
        public bool IsMin
        {
            [MethodImpl(Inline)]
            get => data == MinLiteral;
        }


        [MethodImpl(Inline)]
        static S wrap(int x)
            => new S((byte)x);

        [MethodImpl(Inline)]
        public bool Equals(S y)
            => data == y.data;

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object y)
            => data.Equals(y);
        public string Format()
            => data.FormatAsmHex();

        public override string ToString()
            => data.ToString();
    }
}