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

    using S = uint3;
    using K = BitSeq3;
    using W = W3;
    using T = System.Byte;

    using N = N3;

    /// <summary>
    /// Represents the value of a type-level triad and thus has domain {000,001,010,011,100,101,110,111}
    /// </summary>
    public readonly struct uint3 : IUnsigned<S,W,K,T>
    {
        internal readonly byte data;

        public const byte MinVal = 0;

        public const byte MaxVal = 7;

        public const int Width = 3;

        public const byte Count = (byte)MaxVal + 1;

        public static N N => default;

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
        public static implicit operator octet(S src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint5(S src)
            => new uint5(src.data);

        [MethodImpl(Inline)]
        public static implicit operator uint4(S src)
            => new uint4(src.data);

        [MethodImpl(Inline)]
        public static implicit operator uint6(S src)
            => new uint6(src.data);

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
        /// Converts a 3-bit integer to an unsigned 8-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator byte(S src)
            => (byte)src.data;

        /// <summary>
        /// Converts a 3-bit integer to an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator ushort(S src)
            => (ushort)src.data;

        /// <summary>
        /// Converts a 3-bit integer to an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator uint(S src)
            => src.data;

        /// <summary>
        /// Converts a 3-bit integer to an unsigned 63-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator ulong(S src)
            => src.data;

        /// <summary>
        /// Converts a 3-bit integer to a signed 32-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator int(S src)
            => (int)src.data;

        /// <summary>
        /// Creates a 3-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator S(byte src)
            => uint3(src);

        /// <summary>
        /// Creates a 3-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator S(uint src)
            => uint3(src);

        /// <summary>
        /// Creates a 3-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator S(ulong src)
            => uint3(src);

        [MethodImpl(Inline)]
        public static S @bool(bool x)
            => uint3(x);

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
        public static S operator * (S lhs, S rhs)
            => mul(lhs,rhs);

        [MethodImpl(Inline)]
        public static S operator / (S lhs, S rhs)
            => div(lhs,rhs);

        [MethodImpl(Inline)]
        public static S operator % (S lhs, S rhs)
            => mod(lhs,rhs);

        [MethodImpl(Inline)]
        public static S operator &(S lhs, S rhs)
            => and(lhs,rhs);

        [MethodImpl(Inline)]
        public static S operator |(S lhs, S rhs)
            => or(lhs,rhs);

        [MethodImpl(Inline)]
        public static S operator ^(S lhs, S rhs)
            => xor(lhs,rhs);

        [MethodImpl(Inline)]
        public static S operator >>(S lhs, int count)
            => srl(lhs, (byte)count);

        [MethodImpl(Inline)]
        public static S operator <<(S lhs, int count)
            => sll(lhs, (byte)count);

        [MethodImpl(Inline)]
        public static S operator ~(S src)
            => wrap3(~src.data & MaxVal);

        [MethodImpl(Inline)]
        public static S operator ++(S x)
            => inc(x);

        [MethodImpl(Inline)]
        public static S operator --(S x)
            => dec(x);

        [MethodImpl(Inline)]
        public static bool operator ==(S lhs, S rhs)
            => eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(S lhs, S rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static S operator < (S lhs, S rhs)
            => @bool(lhs.data < rhs.data);

        [MethodImpl(Inline)]
        public static S operator <= (S lhs, S rhs)
            => @bool(lhs.data <= rhs.data);

        [MethodImpl(Inline)]
        public static S operator > (S lhs, S rhs)
            => @bool(lhs.data > rhs.data);

        [MethodImpl(Inline)]
        public static S operator >= (S lhs, S rhs)
            => @bool(lhs.data >= rhs.data);

        [MethodImpl(Inline)]
        internal uint3(octet src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal uint3(byte src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal uint3(byte src, bool @unchecked)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal uint3(sbyte src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal uint3(short src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal uint3(ushort src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal uint3(int x)
            => data = (byte)((uint)x & MaxVal);

        [MethodImpl(Inline)]
        internal uint3(uint src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal uint3(long src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal uint3(uint src, bool safe)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal uint3(K src)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal uint3(BitState src)
            => data = (byte)src;

        /// <summary>
        /// Queries an index-dentified bit
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
             => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(S rhs)
            => eq(this,rhs);

        public override bool Equals(object rhs)
            => rhs is S x && Equals(x);
        public uint Hash
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public override int GetHashCode()
            => (int)Hash;
   }
}