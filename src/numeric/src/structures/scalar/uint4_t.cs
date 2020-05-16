//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Analogs;

    using analog = uint4_t;

    public struct uint4_t : IEquatable<analog>
    {
        internal uint data;

        public static analog MinValue => MinVal;

        public static analog MaxValue => MaxVal;

        public static analog Zero => 0;

        public static analog One => 1;

        internal const uint MinVal = 0;

        internal const uint MaxVal = 0xF;

        internal const int BitWidth = 4;        

        internal const byte Base = (byte)MaxVal + 1;

        /// <summary>
        /// Converts a 4-bit integer to an unsigned 8-bit integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator byte(analog src)
            => (byte)src.data;

        /// <summary>
        /// Converts an unsigned 4-bit integer to its equivalent b4 classification
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator BinaryKind4(analog src)
            => (BinaryKind4)src;

        /// <summary>
        /// Converts a b4 classification to its equivalent unisigned 4-bit integral representation
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator analog(BinaryKind4 src)
            => wrap4((byte)src);

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
            => reduce(lhs.data * rhs.data);

        [MethodImpl(Inline)]
        public static analog operator / (analog lhs, analog rhs) 
            => wrap4(lhs.data / rhs.data);

        [MethodImpl(Inline)]
        public static analog operator % (analog lhs, analog rhs)
            => wrap4(lhs.data % rhs.data);

        [MethodImpl(Inline)]
        public static analog operator |(analog lhs, analog rhs)
            => wrap4(lhs.data | rhs.data);

        [MethodImpl(Inline)]
        public static analog operator &(analog lhs, analog rhs)
            => wrap4(lhs.data & rhs.data);

        [MethodImpl(Inline)]
        public static analog operator ^(analog lhs, analog rhs)
            => wrap4((lhs.data & rhs.data) & MaxVal);

        [MethodImpl(Inline)]
        public static analog operator >>(analog lhs, int rhs)
            => uint4(lhs.data >> rhs);

        [MethodImpl(Inline)]
        public static analog operator <<(analog lhs, int rhs)
            => uint4(lhs.data << rhs);

        [MethodImpl(Inline)]
        public static analog operator ~(analog src)
            => wrap4(~src.data & MaxVal);

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
        internal uint4_t(byte src)
            => data = (uint)(src & MaxVal);

        [MethodImpl(Inline)]
        internal uint4_t(sbyte src)
            => data = (uint)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal uint4_t(short src)
            => data = (uint)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal uint4_t(ushort src)
            => data = (uint)src & MaxVal;

        [MethodImpl(Inline)]    
        internal uint4_t(int x)
            => data = (byte)((uint)x & MaxVal);
        
        [MethodImpl(Inline)]
        internal uint4_t(uint src)
            => data = src & MaxVal;

        [MethodImpl(Inline)]
        internal uint4_t(long src)
            => data = (byte)((uint)src & MaxVal);

        [MethodImpl(Inline)]
        internal uint4_t(uint src, bool safe)
            => data = src;

        /// <summary>
        /// Queries and manipulates a bit identified by its 0-based index
        /// </summary>
        public bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => Analogs.bit(this, pos);
            
            [MethodImpl(Inline)]
            set => Analogs.bit(ref this, pos, value);
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
                Analogs.bit(ref this, 0, src[0]);
                Analogs.bit(ref this, 1, src[1]);
            }
        }

        /// <summary>
        /// Queries and manipulates the upper two bits
        /// </summary>
        public analog Hi
        {
            [MethodImpl(Inline)]
            get => Analogs.hi(this);

            [MethodImpl(Inline)]
            set
            {
                var src = value.Lo;
                Analogs.bit(ref this, 2, src[0]);
                Analogs.bit(ref this, 3, src[1]);
            }
        }

        /// <summary>
        /// Renders the source value as as hexadecimal string
        /// </summary>
        [MethodImpl(Inline)]
        public string Format()
            => HexMap[data].ToString();

        [MethodImpl(Inline)]
        public bool Equals(analog rhs)
            => eq(this,rhs);

        public override bool Equals(object rhs)
            => rhs is analog x && Equals(x);
       
        public override int GetHashCode()
            => data.GetHashCode();
 
        [MethodImpl(Inline)]
        internal static uint reduce(uint x) 
            => Analogs.reduce4(x);

        [MethodImpl(Inline)]
        internal static analog Wrap(uint src) 
            => Analogs.wrap4(src);

        /// <summary>
        /// Defines a mapping from possible UInt4 values to their hex code representations
        /// </summary>
        static char[] HexMap  => new char[]{'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
    }
}