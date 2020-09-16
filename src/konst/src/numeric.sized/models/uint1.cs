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

    using S = uint1;
    using K = BitSeq1;
    using W = W1;
    using T = System.Byte;

    /// <summary>
    /// Represents the value of a type-level single and thus has domain {0,1}
    /// </summary>
    public readonly struct uint1 : ISizedInt<S,W,K,T>
    {
        internal readonly byte data;

        public const byte MinVal = 0;

        public const byte MaxVal = 1;

        public const uint Count = MaxVal + 1;

        public const byte Width = 1;

        public static W W => default;

        /// <summary>
        /// Specifies the minimum <see cref='S'/> value
        /// </summary>
        public static S Min
        {
            [MethodImpl(Inline)]
            get => new S(MinVal,true);
        }

        /// <summary>
        /// Specifies the maximum <see cref='S'/> value
        /// </summary>
        public static S Max
        {
            [MethodImpl(Inline)]
            get => new S(MaxVal,true);
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
        public static implicit operator uint2(S src)
            => new uint2(src.data);

        [MethodImpl(Inline)]
        public static implicit operator uint3(S src)
            => new uint3(src.data);

        [MethodImpl(Inline)]
        public static implicit operator uint4(S src)
            => new uint4(src.data);

        [MethodImpl(Inline)]
        public static implicit operator uint5(S src)
            => new uint5(src.data);

        [MethodImpl(Inline)]
        public static implicit operator uint6(S src)
            => new uint6(src.data);

        [MethodImpl(Inline)]
        public static implicit operator octet(S src)
            => new octet(src.data);

        [MethodImpl(Inline)]
        public static implicit operator S(octet src)
            => new S(src);

        [MethodImpl(Inline)]
        public static implicit operator S(BitState src)
            => new S(src);

        [MethodImpl(Inline)]
        public static implicit operator bool(S src)
            => src.data == 1;

        [MethodImpl(Inline)]
        public static implicit operator S(bit src)
            => new S((uint)src);

        /// <summary>
        /// Converts a 1-bit integer to an unsigned 8-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator byte(S src)
            => (byte)src.data;

        [MethodImpl(Inline)]
        public static implicit operator S(X00 src)
            => (byte)src;

        [MethodImpl(Inline)]
        public static implicit operator S(X01 src)
        => (byte)src;

        /// <summary>
        /// Converts a 1-bit integer to an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator ushort(S src)
            => (ushort)src.data;

        /// <summary>
        /// Converts a 1-bit integer to an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator uint(S src)
            => src.data;

        /// <summary>
        /// Converts a 1-bit integer to an unsigned 61-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator ulong(S src)
            => src.data;

        /// <summary>
        /// Converts a 1-bit integer to a signed 32-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator int(S src)
            => (int)src.data;

        /// <summary>
        /// Creates a 1-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator S(byte src)
            => uint1(src);

        /// <summary>
        /// Creates a 1-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator S(uint src)
            => uint1(src);

        /// <summary>
        /// Creates a 1-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator S(ulong src)
            => uint1(src);

        [MethodImpl(Inline)]
        public static implicit operator S(bool src)
            => uint1(src);

        [MethodImpl(Inline)]
        public static S @bool(bool x)
            => uint1(x);

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
            => wrap1(~src.data & MaxVal);

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
        internal uint1(octet src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal uint1(byte src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal uint1(byte src, bool @unchecked)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal uint1(sbyte src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal uint1(short src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal uint1(ushort src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal uint1(int x)
            => data = (byte)((uint)x & MaxVal);

        [MethodImpl(Inline)]
        internal uint1(uint src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal uint1(long src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal uint1(uint src, bool safe)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal uint1(BitState src)
            => data = (byte)src;

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
            get => data == MaxVal;
        }

        /// <summary>
        /// Specifies whether the current value is the minimum value
        /// </summary>
        public bool IsMin
        {
            [MethodImpl(Inline)]
            get => data == MinVal;
        }

        /// <summary>
        /// Renders the source value as as hexadecimal string
        /// </summary>
        [MethodImpl(Inline)]
        public string Format()
            => data == 0 ? "0" : "1";

        [MethodImpl(Inline)]
        public bool Equals(S y)
            => eq(this,y);

        public override bool Equals(object y)
            => y is S x && Equals(x);

        [MethodImpl(Inline)]
        public char ToChar()
            => data != 0 ? '1' : '0';

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public override int GetHashCode()
            => (int)Hash;
   }
}