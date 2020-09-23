//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Sized;

    using S = uint6;
    using W = W6;
    using K = BitSeq6;
    using T = System.Byte;
    using N = N6;

    /// <summary>
    /// Represents the value of a type-level sextet and thus is an integer in the range [0,63]
    /// </summary>
    public readonly struct uint6 : ISizedInt<S,W,K,T>
    {
        internal readonly T data;

        public const T MinLiteral = 0;

        /// <summary>
        /// Specifies the inclusive upper bound of the <see cref='S'/> data type as a literal value
        /// </summary>
        public const byte MaxLiteral = 63;

        /// <summary>
        /// Specifies the count of unique values representable by a <see cref='S'/>
        /// </summary>
        public const byte Count = MaxLiteral + 1;

        /// <summary>
        /// Specifies the represented data type bit-width
        /// </summary>
        public const byte Width = 6;

        public static W W => default;

        /// <summary>
        /// Specifies the <see cref='Width'/> values as a type-level natural
        /// </summary>
        public static N N => default;

        /// <summary>
        /// Specifies the minimum <see cref='S'/> value
        /// </summary>
        public static S Min
        {
            [MethodImpl(Inline)]
            get => new S(MinLiteral,true);
        }

        /// <summary>
        /// Specifies the maximum <see cref='S'/> value
        /// </summary>
        public static S Max
        {
            [MethodImpl(Inline)]
            get => new S(MaxLiteral,true);
        }

        /// <summary>
        /// Specifies the <see cref='S'/> zero value
        /// </summary>
        public static S Zero
        {
            [MethodImpl(Inline)]
            get => new S(0,true);
        }

        /// <summary>
        /// Specifies the <see cref='S'/> one value
        /// </summary>
        public static S One
        {
            [MethodImpl(Inline)]
            get => new S(1,true);
        }

        [MethodImpl(Inline)]
        public static implicit operator octet(S src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator S(octet src)
            => new S(src);

        [MethodImpl(Inline)]
        public static implicit operator S(K src)
            => new S(src);

        [MethodImpl(Inline)]
        public static implicit operator K(S src)
            => (K)src.data;

        /// <summary>
        /// Converts a 5-bit integer to an unsigned 8-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator byte(S src)
            => (byte)src.data;

        /// <summary>
        /// Converts a 5-bit integer to an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator ushort(S src)
            => (ushort)src.data;

        /// <summary>
        /// Converts a 5-bit integer to an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator uint(S src)
            => src.data;

        /// <summary>
        /// Converts a 5-bit integer to an unsigned 65-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator ulong(S src)
            => src.data;

        /// <summary>
        /// Converts a 5-bit integer to a signed 32-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator int(S src)
            => (int)src.data;

        /// <summary>
        /// Creates a 5-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator S(byte src)
            => uint6(src);

        /// <summary>
        /// Creates a 5-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator S(uint src)
            => uint6(src);

        /// <summary>
        /// Creates a 5-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator S(ulong src)
            => uint6(src);

        [MethodImpl(Inline)]
        public static S @bool(bool x)
            => uint6(x);

        [MethodImpl(Inline)]
        public static bool operator true(S x)
            => x.data != 0;

        [MethodImpl(Inline)]
        public static bool operator false(S x)
            => x.data == 0;

        [MethodImpl(Inline)]
        public static S operator + (S x, S y)
            => add(x,y);

        [MethodImpl(Inline)]
        public static S operator - (S x, S y)
            => sub(x,y);

        [MethodImpl(Inline)]
        public static S operator * (S x, S y)
            => mul(x,y);

        [MethodImpl(Inline)]
        public static S operator / (S x, S y)
            => div(x,y);

        [MethodImpl(Inline)]
        public static S operator % (S x, S y)
            => mod(x,y);

        [MethodImpl(Inline)]
        public static S operator &(S x, S y)
            => and(x,y);

        [MethodImpl(Inline)]
        public static S operator |(S x, S y)
            => or(x,y);

        [MethodImpl(Inline)]
        public static S operator ^(S x, S y)
            => xor(x,y);

        [MethodImpl(Inline)]
        public static S operator >>(S x, int count)
            => srl(x, (byte)count);

        [MethodImpl(Inline)]
        public static S operator <<(S x, int count)
            => sll(x, (byte)count);

        [MethodImpl(Inline)]
        public static S operator ~(S src)
            => wrap6((byte)(~src.data & MaxLiteral));

        [MethodImpl(Inline)]
        public static S operator ++(S x)
            => inc(x);

        [MethodImpl(Inline)]
        public static S operator --(S x)
            => dec(x);

        [MethodImpl(Inline)]
        public static bool operator ==(S x, S y)
            => eq(x,y);

        [MethodImpl(Inline)]
        public static bool operator !=(S x, S y)
            => !x.Equals(y);

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
        internal uint6(octet src)
            => data = (byte)(src & MaxLiteral);

        [MethodImpl(Inline)]
        internal uint6(byte src)
            => data = (byte)(src & MaxLiteral);

        [MethodImpl(Inline)]
        internal uint6(byte src, bool @unchecked)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal uint6(sbyte src)
            => data = (byte)((uint)src & MaxLiteral);

        [MethodImpl(Inline)]
        internal uint6(short src)
            => data = (byte)((uint)src & MaxLiteral);

        [MethodImpl(Inline)]
        internal uint6(ushort src)
            => data = (byte)(src & MaxLiteral);

        [MethodImpl(Inline)]
        internal uint6(int x)
            => data = (byte)((uint)x & MaxLiteral);

        [MethodImpl(Inline)]
        internal uint6(uint src)
            => data = (byte)(src & MaxLiteral);

        [MethodImpl(Inline)]
        internal uint6(long src)
            => data = (byte)((uint)src & MaxLiteral);

        [MethodImpl(Inline)]
        internal uint6(uint src, bool safe)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal uint6(K src)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal uint6(BitState src)
            => data = (byte)src;

        /// <summary>
        /// Queries and manipulates a bit identified by its 0-based index
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

        public T Value
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
        public string Format(N2 b)
            => BitFormatter.format(data,Width);

        [MethodImpl(Inline)]
        public string Format(N16 b)
            => data.FormatHex(false, false);

        [MethodImpl(Inline)]
        public string Format()
             => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(S y)
            => eq(this,y);

        public override bool Equals(object y)
            => y is S x && Equals(x);

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public override int GetHashCode()
            => (int)Hash;
   }
}