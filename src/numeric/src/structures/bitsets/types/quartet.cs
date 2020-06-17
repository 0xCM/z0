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

    using analog = quartet;
    using BK = Quartet;
    using N = N4;

    /// <summary>
    /// Represents the value of a type-level quartet and thus is an integer in the range [0,15]
    /// </summary>
    public struct quartet : IEquatable<analog>
    {
        internal byte data;

        public static analog MinValue => MinVal;

        public static analog MaxValue => MaxVal;

        public static N N => default;

        public static analog Zero => 0;

        public static analog One => 1;

        internal const byte MinVal = 0;

        internal const byte MaxVal = 0xF;

        internal const int BitWidth = 4;        

        internal const byte Base = (byte)MaxVal + 1;

        [MethodImpl(Inline)]
        public static implicit operator octet(analog src)
            => new octet(src.data);

        [MethodImpl(Inline)]
        public static implicit operator quintet(analog src)
            => new quintet(src.data);

        [MethodImpl(Inline)]
        public static implicit operator analog(octet src)
            => new analog(src);

        [MethodImpl(Inline)]
        public static implicit operator analog(BK src)
            => new analog(src);

        [MethodImpl(Inline)]
        public static implicit operator BK(analog src)
            => (BK)src.data;

        /// <summary>
        /// Converts a 4-bit integer to an unsigned 8-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator byte(analog src)
            => (byte)src.data;

        /// <summary>
        /// Converts a 4-bit integer to an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator ushort(analog src)
            => (ushort)src.data;

        /// <summary>
        /// Converts a 4-bit integer to an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator uint(analog src)
            => src.data;

        /// <summary>
        /// Converts a 4-bit integer to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator ulong(analog src)
            => src.data;

        /// <summary>
        /// Converts a 4-bit integer to a signed 32-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator int(analog src)
            => (int)src.data;

        /// <summary>
        /// Creates a 4-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator analog(byte src)
            => uint4(src);

        /// <summary>
        /// Creates a 4-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator analog(uint src)
            => uint4(src);

        /// <summary>
        /// Creates a 4-bit integer from the least four bits of the source operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator analog(ulong src)
            => uint4(src);

        [MethodImpl(Inline)]    
        public static analog @bool(bool x)
            => x ? One : Zero;

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
            => reduce((uint)lhs.data * (uint)rhs.data);

        [MethodImpl(Inline)]
        public static analog operator / (analog lhs, analog rhs) 
            => wrap4((uint)lhs.data / (uint)rhs.data);

        [MethodImpl(Inline)]
        public static analog operator % (analog lhs, analog rhs)
            => wrap4((uint)lhs.data % (uint)rhs.data);

        [MethodImpl(Inline)]
        public static analog operator |(analog lhs, analog rhs)
            => wrap4((uint)lhs.data | (uint)rhs.data);

        [MethodImpl(Inline)]
        public static analog operator &(analog lhs, analog rhs)
            => wrap4((uint)lhs.data & (uint)rhs.data);

        [MethodImpl(Inline)]
        public static analog operator ^(analog lhs, analog rhs)
            => wrap4((uint)(lhs.data & rhs.data) & (uint)MaxVal);

        [MethodImpl(Inline)]
        public static analog operator >>(analog lhs, int rhs)
            => uint4(lhs.data >> rhs);

        [MethodImpl(Inline)]
        public static analog operator <<(analog lhs, int rhs)
            => uint4(lhs.data << rhs);

        [MethodImpl(Inline)]
        public static analog operator ~(analog src)
            => wrap4((uint)(~src.data & MaxVal));

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
        static byte crop(int x) 
            => (byte)(0xF & x);

        [MethodImpl(Inline)]
        static byte crop(uint x) 
            => (byte)(0xF & x);

        [MethodImpl(Inline)]
        quartet(octet src)
            => data = (byte)(src & MaxVal);

        [MethodImpl(Inline)]
        internal quartet(byte src)
            => data = crop(src);

        [MethodImpl(Inline)]
        internal quartet(sbyte src)
            => data = crop(src);

        [MethodImpl(Inline)]
        internal quartet(short src)
            => data = crop(src);

        [MethodImpl(Inline)]
        internal quartet(ushort src)
            => data = crop(src);

        [MethodImpl(Inline)]    
        internal quartet(int src)
            => data = crop(src);
        
        [MethodImpl(Inline)]
        internal quartet(uint src)
            => data = crop(src);

        [MethodImpl(Inline)]
        internal quartet(long src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal quartet(uint src, bool safe)
            => data = (byte)src;

        [MethodImpl(Inline)]
        internal quartet(BK src)
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
        /// Queries and manipulates the lower two bits
        /// </summary>
        public analog Lo
        {
            [MethodImpl(Inline)]
            get => lo(this);
            
            [MethodImpl(Inline)]
            set 
            {
                var src = value.Lo;
                BitSet.bit(ref this, 0, src[0]);
                BitSet.bit(ref this, 1, src[1]);
            }
        }

        /// <summary>
        /// Queries and manipulates the upper two bits
        /// </summary>
        public analog Hi
        {
            [MethodImpl(Inline)]
            get => BitSet.hi(this);

            [MethodImpl(Inline)]
            set
            {
                var src = value.Lo;
                BitSet.bit(ref this, 2, src[0]);
                BitSet.bit(ref this, 3, src[1]);
            }
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
 
        [MethodImpl(Inline)]
        internal static uint reduce(uint x) 
            => BitSet.reduce4(x);

        [MethodImpl(Inline)]
        internal static analog Wrap(uint src) 
            => BitSet.wrap4(src);
    }
}