//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using static BitSet;

    using analog = duet;
    using BK = Duet;
    using N = N2;

    /// <summary>
    /// Represents the value of a type-level duet and thus has domain {00,01,10,11}
    /// </summary>
    public struct duet : IEquatable<analog>, ITextual
    {    
        internal byte data;

        public const byte Min8u = 0;

        public const byte Max8u = 3;

        public const int Width = 2;        

        public const byte Base = (byte)Max8u + 1;

        public static analog Min => Min8u;

        public static analog Max => Max8u;

        public static analog Zero => 0;

        public static analog One => 1;

        public static N N => default;

        [MethodImpl(Inline)]
        public static implicit operator analog(octet src)
            => new analog(src);

        [MethodImpl(Inline)]
        public static implicit operator triad(analog src)
            => new triad(src.data);

        [MethodImpl(Inline)]
        public static implicit operator quartet(analog src)
            => new quartet(src.data);

        [MethodImpl(Inline)]
        public static implicit operator quintet(analog src)
            => new quintet(src.data);

        [MethodImpl(Inline)]
        public static implicit operator sextet(analog src)
            => new sextet(src.data);

        [MethodImpl(Inline)]
        public static implicit operator octet(analog src)
            => new octet(src.data);

        [MethodImpl(Inline)]
        public static implicit operator analog(BK src)
            => new analog(src);

        [MethodImpl(Inline)]
        public static implicit operator BK(analog src)
            => (BK)src.data;

        [MethodImpl(Inline)]
        public static implicit operator analog(Hex2Kind src) => (byte)src;

        [MethodImpl(Inline)]
        public static implicit operator analog(X00 src) => (byte)src;

        [MethodImpl(Inline)]
        public static implicit operator analog(X01 src) => (byte)src;

        [MethodImpl(Inline)]
        public static implicit operator analog(X02 src) => (byte)src;

        [MethodImpl(Inline)]
        public static implicit operator analog(X03 src) => (byte)src;

        /// <summary>
        /// Converts a 3-bit integer to an unsigned 8-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator byte(analog src)
            => (byte)src.data;

        /// <summary>
        /// Converts a 3-bit integer to an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator ushort(analog src)
            => (ushort)src.data;

        /// <summary>
        /// Converts a 3-bit integer to an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator uint(analog src)
            => src.data;

        /// <summary>
        /// Converts a 3-bit integer to an unsigned 63-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator ulong(analog src)
            => src.data;

        /// <summary>
        /// Converts a 3-bit integer to a signed 32-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator int(analog src)
            => (int)src.data;

        /// <summary>
        /// Creates a 3-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator analog(byte src)
            => uint2(src);

        /// <summary>
        /// Creates a 3-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator analog(uint src)
            => uint2(src);

        /// <summary>
        /// Creates a 3-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator analog(ulong src)
            => uint2(src);

        [MethodImpl(Inline)]    
        public static analog @bool(bool x)
            => uint2(x);

        [MethodImpl(Inline)]    
        public static bool operator true(analog x)
            => x.data != 0;

        [MethodImpl(Inline)]    
        public static bool operator false(analog x)
            => x.data == 0;

        [MethodImpl(Inline)]
        public static analog operator + (analog x, analog y)
            => add(x,y);

        [MethodImpl(Inline)]
        public static analog operator - (analog x, analog y)
            => sub(x,y);

        [MethodImpl(Inline)]
        public static analog operator * (analog lhs, analog rhs)
            => mul(lhs,rhs);

        [MethodImpl(Inline)]
        public static analog operator / (analog lhs, analog rhs) 
            => div(lhs,rhs);

        [MethodImpl(Inline)]
        public static analog operator % (analog lhs, analog rhs)
            => mod(lhs,rhs);

        [MethodImpl(Inline)]
        public static analog operator &(analog lhs, analog rhs)
            => and(lhs,rhs);

        [MethodImpl(Inline)]
        public static analog operator |(analog lhs, analog rhs)
            => or(lhs,rhs);

        [MethodImpl(Inline)]
        public static analog operator ^(analog lhs, analog rhs)
            => xor(lhs,rhs);

        [MethodImpl(Inline)]
        public static analog operator >>(analog lhs, int rhs)
            => srl(lhs,rhs);

        [MethodImpl(Inline)]
        public static analog operator <<(analog lhs, int rhs)
            => sll(lhs,rhs);

        [MethodImpl(Inline)]
        public static analog operator ~(analog src)
            => wrap2(~src.data & Max8u);

        [MethodImpl(Inline)]
        public static analog operator ++(analog x)
            => inc(x);
            
        [MethodImpl(Inline)]
        public static analog operator --(analog x)
            => dec(x);

        [MethodImpl(Inline)]
        public static bool operator ==(analog lhs, analog rhs)
            => eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(analog lhs, analog rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static analog operator < (analog lhs, analog rhs) 
            => @bool(lhs.data < rhs.data);

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
        duet(octet src)
            => data = (byte)(src & Max8u);

        [MethodImpl(Inline)]
        internal duet(byte src)
            => data = (byte)(src & Max8u);

        [MethodImpl(Inline)]
        internal duet(sbyte src)
            => data = (byte)((uint)src & Max8u);

        [MethodImpl(Inline)]
        internal duet(short src)
            => data = (byte)((uint)src & Max8u);

        [MethodImpl(Inline)]
        internal duet(ushort src)
            => data = (byte)(src & Max8u);

        [MethodImpl(Inline)]    
        internal duet(int x)
            => data = (byte)((uint)x & Max8u);
        
        [MethodImpl(Inline)]
        internal duet(uint src)
            => data = (byte)(src & Max8u);

        [MethodImpl(Inline)]
        internal duet(long src)
            => data = (byte)((uint)src & Max8u);

        [MethodImpl(Inline)]
        internal duet(uint src, bool safe)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal duet(BK src)
            => data = (byte)src;

        /// <summary>
        /// Queries and manipulates a bit identified by its 0-based index
        /// </summary>
        public bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => BitSet.bit(this, pos);
            
            [MethodImpl(Inline)]
            set => BitSet.bit(ref this, pos, value);
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
        public bool Equals(analog rhs)
            => eq(this,rhs);

        public override bool Equals(object rhs)
            => rhs is analog x && Equals(x);
       
        public override int GetHashCode()
            => data.GetHashCode();      
    }
}