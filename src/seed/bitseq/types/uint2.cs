//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using static BitSeqD;

    using S = uint2;
    using W = W2;
    using K = BitSeq2;
    using T = System.Byte;
    using N = N2;

    /// <summary>
    /// Represents the value of a type-level duet and thus has domain {00,01,10,11}
    /// </summary>
    public struct uint2 : IBitSeq<S,W,K,T>
    {    
        internal byte data;

        /// <summary>
        /// Specifies the inclusive lower bound of the <see cref='S'/> data type as a literal value
        /// </summary>
        public const byte MinVal = 0;

        /// <summary>
        /// Specifies the inclusive upper bound of the <see cref='S'/> data type as a literal value
        /// </summary>
        public const byte MaxVal = 3;

        /// <summary>
        /// Specifies the bit-width of the <see cref='S'/> data type
        /// </summary>
        public const byte Width = 2;        

        /// <summary>
        /// Specifies the count of unique values representable by a <see cref='S'/>
        /// </summary>
        public const uint Count = MaxVal + 1;

        /// <summary>
        /// Specifies a <see cref='S'/> bitwidth <see ref='W'/> representative
        /// </summary>
        public static W W => default;

        /// <summary>
        /// Specifies the minimum <see cref='S'/> value
        /// </summary>
        public static S Min => MinVal;

        /// <summary>
        /// Specifies the maximum <see cref='S'/> value
        /// </summary>
        public static S Max => MaxVal;

        /// <summary>
        /// Specifies the <see cref='S'/> zero value
        /// </summary>
        public static S Zero => 0;

        /// <summary>
        /// Specifies the <see cref='S'/> one value
        /// </summary>
        public static S One => 1;

        /// <summary>
        /// Specifies the <see cref='S'/> bit-width as a natural number
        /// </summary>
        public static N N => default;


        [MethodImpl(Inline)]
        public static implicit operator S(octet src)
            => new S(src);

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
        public static implicit operator S(K src)
            => new S(src);

        [MethodImpl(Inline)]
        public static implicit operator K(S src)
            => (K)src.data;

        [MethodImpl(Inline)]
        public static implicit operator S(Hex2Kind src) 
            => (byte)src;

        [MethodImpl(Inline)]
        public static implicit operator S(X00 src) 
            => (byte)src;

        [MethodImpl(Inline)]
        public static implicit operator S(X01 src) 
            => (byte)src;

        [MethodImpl(Inline)]
        public static implicit operator S(X02 src) 
            => (byte)src;

        [MethodImpl(Inline)]
        public static implicit operator S(X03 src) 
            => (byte)src;

        /// <summary>
        /// Implicitly promotes a <see cref='S'> value to a <see cref='byte'/> value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator byte(S src)
            => (byte)src.data;

        /// <summary>
        /// Implicitly promotes a <see cref='S'> value to a <see cref='ushort'/> value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator ushort(S src)
            => (ushort)src.data;

        /// <summary>
        /// Implicitly promotes a <see cref='S'> value to a <see cref='uint'/> value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator uint(S src)
            => src.data;

        /// <summary>
        /// Implicitly promotes a <see cref='S'> value to a <see cref='ulong'/> value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator ulong(S src)
            => src.data;

        /// <summary>
        /// Implicitly promotes a <see cref='S'> value to a <see cref='int'/> value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator int(S src)
            => (int)src.data;

        /// <summary>
        /// Converts a <see cref='byte'> value to a <see cref='S'/> value, truncating as necessary
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator S(byte src)
            => uint2(src);

        /// <summary>
        /// Creates a 3-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator S(uint src)
            => uint2(src);

        /// <summary>
        /// Creates a 3-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator S(ulong src)
            => uint2(src);

        [MethodImpl(Inline)]    
        public static S @bool(bool x)
            => uint2(x);

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
        public static S operator >>(S lhs, int rhs)
            => srl(lhs,rhs);

        [MethodImpl(Inline)]
        public static S operator <<(S lhs, int rhs)
            => sll(lhs,rhs);

        [MethodImpl(Inline)]
        public static S operator ~(S src)
            => wrap2(~src.data & MaxVal);

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
        internal uint2(octet src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal uint2(byte src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal uint2(sbyte src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal uint2(short src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal uint2(ushort src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]    
        internal uint2(int x)
            => data = (byte)((uint)x & MaxVal);
        
        [MethodImpl(Inline)]
        internal uint2(uint src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal uint2(long src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal uint2(uint src, bool safe)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal uint2(K src)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal uint2(Bit src)
            => data = (byte)src;

        /// <summary>
        /// Queries an index-identified bit
        /// </summary>
        public Bit this[byte pos]
        {
            [MethodImpl(Inline)]
            get => BitSeqD.test(this, pos);            
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