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

    using analog = single;
    using BK = Singleton;
    using N = N1;

    /// <summary>
    /// Represents the value of a type-level single and thus has domain {0,1}
    /// </summary>
    public struct single : IEquatable<analog>
    {
        internal byte data;

        public static analog MinValue => MinVal;

        public static analog MaxValue => MaxVal;

        public static N N => default;        

        public static analog Zero => 0;

        public static analog One => 1;

        internal const byte MinVal = 0;

        internal const byte MaxVal = 1;

        internal const int BitWidth = 1;        

        internal const byte Base = (byte)MaxVal + 1;

        [MethodImpl(Inline)]
        public static implicit operator duet(analog src)
            => new duet(src.data);

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
        public static implicit operator analog(octet src)
            => new analog(src);

        [MethodImpl(Inline)]
        public static implicit operator analog(BK src)
            => new analog(src);

        [MethodImpl(Inline)]
        public static implicit operator BK(analog src)
            => (BK)src.data;

        [MethodImpl(Inline)]
        public static implicit operator bit(analog src)
            => src.data == 1;

        [MethodImpl(Inline)]
        public static implicit operator analog(bit src)
            => new analog((uint)src);

        /// <summary>
        /// Converts a 1-bit integer to an unsigned 8-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator byte(analog src)
            => (byte)src.data;

        [MethodImpl(Inline)]
        public static implicit operator analog(X00 src) => (byte)src;

        [MethodImpl(Inline)]
        public static implicit operator analog(X01 src) => (byte)src;

        /// <summary>
        /// Converts a 1-bit integer to an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator ushort(analog src)
            => (ushort)src.data;

        /// <summary>
        /// Converts a 1-bit integer to an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator uint(analog src)
            => src.data;

        /// <summary>
        /// Converts a 1-bit integer to an unsigned 61-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator ulong(analog src)
            => src.data;

        /// <summary>
        /// Converts a 1-bit integer to a signed 32-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator int(analog src)
            => (int)src.data;

        /// <summary>
        /// Creates a 1-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator analog(byte src)
            => uint1(src);

        /// <summary>
        /// Creates a 1-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator analog(uint src)
            => uint1(src);

        /// <summary>
        /// Creates a 1-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator analog(ulong src)
            => uint1(src);

        [MethodImpl(Inline)]    
        public static analog @bool(bool x)
            => uint1(x);

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
            => wrap1(~src.data & MaxVal);

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
        single(octet src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal single(byte src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal single(sbyte src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal single(short src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal single(ushort src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]    
        internal single(int x)
            => data = (byte)((uint)x & MaxVal);
        
        [MethodImpl(Inline)]
        internal single(uint src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal single(long src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal single(uint src, bool safe)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal single(BK src)
            => data = (byte)src;

        /// <summary>
        /// Renders the source value as as hexadecimal string
        /// </summary>
        [MethodImpl(Inline)]
        public string Format()
            => data == 0 ? "0" : "1";

        [MethodImpl(Inline)]
        public bool Equals(analog rhs)
            => eq(this,rhs);

        public override bool Equals(object rhs)
            => rhs is analog x && Equals(x);
       
        public override int GetHashCode()
            => data.GetHashCode();        
    }
}