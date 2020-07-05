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

    using S = uint4;
    using W = W4;
    using K = BitSeq4;
    using T = System.Byte;
    using N = N4;

    /// <summary>
    /// Represents the value of a type-level quartet and thus is an integer in the range [0,15]
    /// </summary>
    public struct uint4 : IBitSeq<S,W,K,T>
    {
        internal byte data;

        public const byte MinVal = 0;

        public const byte MaxVal = 0xF;

        public const byte Count = (byte)MaxVal + 1;

        public const int Width = 4;        

        public static W W => default;

        public static S Min => MinVal;

        public static S Max => MaxVal;

        public static S Zero => 0;

        public static S One => 1;

        public static N N => default;

        [MethodImpl(Inline)]
        public static implicit operator octet(S src)
            => new octet(src.data);

        [MethodImpl(Inline)]
        public static implicit operator uint5(S src)
            => new uint5(src.data);

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
        /// Converts a 4-bit integer to an unsigned 8-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator byte(S src)
            => (byte)src.data;

        /// <summary>
        /// Converts a 4-bit integer to an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator ushort(S src)
            => (ushort)src.data;

        /// <summary>
        /// Converts a 4-bit integer to an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator uint(S src)
            => src.data;

        /// <summary>
        /// Converts a 4-bit integer to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator ulong(S src)
            => src.data;

        /// <summary>
        /// Converts a 4-bit integer to a signed 32-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator int(S src)
            => (int)src.data;

        /// <summary>
        /// Creates a 4-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator S(byte src)
            => uint4(src);

        /// <summary>
        /// Creates a 4-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator S(uint src)
            => uint4(src);

        /// <summary>
        /// Creates a 4-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator S(ulong src)
            => uint4(src);

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
        public static S operator + (S x, S y)
            => add(x,y);

        [MethodImpl(Inline)]
        public static S operator - (S x, S y)
            => sub(x,y);

        [MethodImpl(Inline)]
        public static S operator * (S lhs, S rhs)
            => reduce((uint)lhs.data * (uint)rhs.data);

        [MethodImpl(Inline)]
        public static S operator / (S lhs, S rhs) 
            => wrap4((uint)lhs.data / (uint)rhs.data);

        [MethodImpl(Inline)]
        public static S operator % (S lhs, S rhs)
            => wrap4((uint)lhs.data % (uint)rhs.data);

        [MethodImpl(Inline)]
        public static S operator |(S lhs, S rhs)
            => wrap4((uint)lhs.data | (uint)rhs.data);

        [MethodImpl(Inline)]
        public static S operator &(S lhs, S rhs)
            => wrap4((uint)lhs.data & (uint)rhs.data);

        [MethodImpl(Inline)]
        public static S operator ^(S lhs, S rhs)
            => wrap4((uint)(lhs.data & rhs.data) & (uint)MaxVal);

        [MethodImpl(Inline)]
        public static S operator >>(S lhs, int rhs)
            => uint4(lhs.data >> rhs);

        [MethodImpl(Inline)]
        public static S operator <<(S lhs, int rhs)
            => uint4(lhs.data << rhs);

        [MethodImpl(Inline)]
        public static S operator ~(S src)
            => wrap4((uint)(~src.data & MaxVal));

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

        /// <summary>
        /// Queries an index-identifed bit
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
        /// Queries and manipulates the lower two bits
        /// </summary>
        public S Lo
        {
            [MethodImpl(Inline)]
            get => lo(this);
            
            [MethodImpl(Inline)]
            set 
            {
                BitSeqD.set(this, 0, BitSeqD.test(this, 0));
                BitSeqD.set(this, 1, BitSeqD.test(this, 1));
            }
        }

        /// <summary>
        /// Queries and manipulates the upper two bits
        /// </summary>
        public S Hi
        {
            [MethodImpl(Inline)]
            get => BitSeqD.hi(this);

            [MethodImpl(Inline)]
            set
            {
                BitSeqD.set(this, 2, BitSeqD.test(this, 2));
                BitSeqD.set(this, 3, BitSeqD.test(this, 3));
            }
        }

        [MethodImpl(Inline)]
        internal uint4(octet src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal uint4(byte src)
            => data = crop4(src);

        [MethodImpl(Inline)]
        internal uint4(sbyte src)
            => data = crop4(src);

        [MethodImpl(Inline)]
        internal uint4(short src)
            => data = crop4(src);

        [MethodImpl(Inline)]
        internal uint4(ushort src)
            => data = crop4(src);

        [MethodImpl(Inline)]    
        internal uint4(int src)
            => data = crop4(src);
        
        [MethodImpl(Inline)]
        internal uint4(uint src)
            => data = crop4(src);

        [MethodImpl(Inline)]
        internal uint4(long src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal uint4(uint src, bool safe)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal uint4(K src)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal uint4(bool src)
            => data = (byte)As.bit(src);

        [MethodImpl(Inline)]
        internal uint4(Bit src)
            => data = (byte)src;

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

        [MethodImpl(Inline)]
        internal static uint reduce(uint x) 
            => BitSeqD.reduce4(x);

        [MethodImpl(Inline)]
        internal static S Wrap(uint src) 
            => BitSeqD.wrap4(src);
    }
}