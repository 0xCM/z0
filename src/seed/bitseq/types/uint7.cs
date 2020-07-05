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

    using S = uint7;
    using W = W7;
    using K = BitSeq7;
    using T = System.Byte;
    using N = N7;

    /// <summary>
    /// Represents the value of a type-level sextet and thus is an integer in the range [0,63]
    /// </summary>
    public readonly struct uint7 : IBitSeq<S,W,K,T>
    {
        internal readonly byte data;

        public const byte MinVal = 0;

        public const byte MaxVal = 127;

        public const byte Count = MaxVal + 1;

        public const byte Width = 7;        

        public static W W => default;

        public static N N => default;

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
            => uint7(src);

        /// <summary>
        /// Creates a 5-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator S(uint src)
            => uint7(src);

        /// <summary>
        /// Creates a 5-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator S(ulong src)
            => uint7(src);

        [MethodImpl(Inline)]    
        public static S @bool(bool x)
            => uint7(x);

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
            => wrap7((byte)(~src.data & MaxVal));

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
        internal uint7(octet src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal uint7(byte src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal uint7(byte src, bool @unchecked)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal uint7(sbyte src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal uint7(short src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal uint7(ushort src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]    
        internal uint7(int x)
            => data = (byte)((uint)x & MaxVal);
        
        [MethodImpl(Inline)]
        internal uint7(uint src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal uint7(long src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal uint7(uint src, bool safe)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal uint7(K src)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal uint7(Bit src)
            => data = (byte)src;

        /// <summary>
        /// Queries the state of an index-identified bit
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