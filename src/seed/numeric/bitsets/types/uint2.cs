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

        /// <summary>
        /// Specifies the inclusive lower bound of the <see cref='analog'/> data type as a literal value
        /// </summary>
        public const byte MinVal = 0;

        /// <summary>
        /// Specifies the inclusive upper bound of the <see cref='analog'/> data type as a literal value
        /// </summary>
        public const byte MaxVal = 3;

        /// <summary>
        /// Specifies the bit-width of the <see cref='analog'/> data type
        /// </summary>
        public const byte Width = 2;        

        /// <summary>
        /// Specifies the count of unique values representable by a <see cref='analog'/>
        /// </summary>
        public const uint Count = MaxVal + 1;

        /// <summary>
        /// Specifies the minimum <see cref='analog'/> value
        /// </summary>
        public static analog Min => MinVal;

        /// <summary>
        /// Specifies the maximum <see cref='analog'/> value
        /// </summary>
        public static analog Max => MaxVal;

        /// <summary>
        /// Specifies the <see cref='analog'/> zero value
        /// </summary>
        public static analog Zero => 0;

        /// <summary>
        /// Specifies the <see cref='analog'/> one value
        /// </summary>
        public static analog One => 1;

        /// <summary>
        /// Specifies the <see cref='analog'/> bit-width as a natural number
        /// </summary>
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
        public static implicit operator analog(Hex2Kind src) 
            => (byte)src;

        [MethodImpl(Inline)]
        public static implicit operator analog(X00 src) 
            => (byte)src;

        [MethodImpl(Inline)]
        public static implicit operator analog(X01 src) 
            => (byte)src;

        [MethodImpl(Inline)]
        public static implicit operator analog(X02 src) 
            => (byte)src;

        [MethodImpl(Inline)]
        public static implicit operator analog(X03 src) 
            => (byte)src;

        /// <summary>
        /// Implicitly promotes a <see cref='analog'> value to a <see cref='byte'/> value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator byte(analog src)
            => (byte)src.data;

        /// <summary>
        /// Implicitly promotes a <see cref='analog'> value to a <see cref='ushort'/> value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator ushort(analog src)
            => (ushort)src.data;

        /// <summary>
        /// Implicitly promotes a <see cref='analog'> value to a <see cref='uint'/> value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator uint(analog src)
            => src.data;

        /// <summary>
        /// Implicitly promotes a <see cref='analog'> value to a <see cref='ulong'/> value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator ulong(analog src)
            => src.data;

        /// <summary>
        /// Implicitly promotes a <see cref='analog'> value to a <see cref='int'/> value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator int(analog src)
            => (int)src.data;

        /// <summary>
        /// Converts a <see cref='byte'> value to a <see cref='analog'/> value, truncating as necessary
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
            => wrap2(~src.data & MaxVal);

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
        internal duet(octet src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal duet(byte src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal duet(sbyte src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal duet(short src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal duet(ushort src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]    
        internal duet(int x)
            => data = (byte)((uint)x & MaxVal);
        
        [MethodImpl(Inline)]
        internal duet(uint src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal duet(long src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal duet(uint src, bool safe)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal duet(BK src)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal duet(Bit src)
            => data = (byte)src;

        /// <summary>
        /// Queries an index-identified bit
        /// </summary>
        public Bit this[byte pos]
        {
            [MethodImpl(Inline)]
            get => BitSet.test(this, pos);            
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