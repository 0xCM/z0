//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    public struct UInt4 : IEquatable<UInt4>
    {
        uint data;

        public static UInt4 MinValue => MinVal;

        public static UInt4 MaxValue => MaxVal;

        const uint MinVal = 0;

        const uint MaxVal = 0xF;

        const uint ModVal = MaxVal + 1;

        const int BitWidth = 4;        


        [MethodImpl(Inline)]
        public static implicit operator byte(UInt4 src)
            => (byte)src.data;

        [MethodImpl(Inline)]
        public static implicit operator ushort(UInt4 src)
            => (ushort)src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint(UInt4 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ulong(UInt4 src)
            => src.data;

        /// <summary>
        /// Creates a 4-bit integer from the least four bits of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator UInt4(byte src)
            => From(src);

        /// <summary>
        /// Creates a 4-bit integer from the least four bits of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator UInt4(uint src)
            => From(src);

        /// <summary>
        /// Creates a 4-bit integer from the least four bits of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator UInt4(ulong src)
            => From(src);

        /// <summary>
        /// Constructs a uint4 value from a sequence of bits ranging from low to high
        /// </summary>
        /// <param name="x0">The first/least bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x1">The second bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x2">The third bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x3">The fourth/highest bit value, if specified; otherwise, defaults to 0</param>
        [MethodImpl(Inline)]
        public static UInt4 FromBits(bit x0 = default, bit x1 = default, bit x2 = default, bit x3 = default)
             => Wrap(((uint)x0 << 0) | ((uint)x1 << 1) | ((uint)x2 << 2) | ((uint)x3 << 3));

        /// <summary>
        /// Creates a uint4 value from the 4 least significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 From(byte src)
            => new UInt4(src);

        /// <summary>
        /// Creates a uint4 value from the 4 least significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 From(ushort src)
            => new UInt4(src);

        /// <summary>
        /// Creates a uint4 value from the 4 least significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 From(uint src)
            => new UInt4(src);

        /// <summary>
        /// Creates a uint4 value from the 4 least significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 From(ulong src)        
            => new UInt4((byte)((byte)src & MaxVal));

        [MethodImpl(Inline)]
        public static UInt4 operator + (UInt4 x, UInt4 y)
        {
            const int modulus = 16;
            var sum = x.data + y.data;
            return Wrap((sum >= modulus) ? sum - modulus: sum);
        }

        [MethodImpl(Inline)]
        public static UInt4 operator - (UInt4 x, UInt4 y)
        {
            const int modulus = 16;
            var diff = (int)x - (int)y;
            return Wrap(diff < 0 ? (uint)(diff + modulus) : (uint)diff);
        }

        [MethodImpl(Inline)]
        public static UInt4 operator * (UInt4 lhs, UInt4 rhs)
            => reduce(lhs.data * rhs.data);

        [MethodImpl(Inline)]
        public static bool operator ==(UInt4 lhs, UInt4 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in UInt4 lhs, in UInt4 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static UInt4 operator |(UInt4 lhs, UInt4 rhs)
            => Wrap(lhs.data | rhs.data);

        [MethodImpl(Inline)]
        public static UInt4 operator &(UInt4 lhs, UInt4 rhs)
            => Wrap(lhs.data & rhs.data);

        [MethodImpl(Inline)]
        public static UInt4 operator ^(UInt4 lhs, UInt4 rhs)
            => Wrap((lhs.data & rhs.data) & 0xF);

        [MethodImpl(Inline)]
        public static UInt4 operator >>(UInt4 lhs, int rhs)
            => new UInt4((byte)(lhs.data >> rhs));

        [MethodImpl(Inline)]
        public static UInt4 operator <<(UInt4 lhs, int rhs)
            => new UInt4((byte)(lhs.data << rhs));

        [MethodImpl(Inline)]
        public static UInt4 operator ~(UInt4 src)
            => Wrap(~src.data & 0xF);

        [MethodImpl(Inline)]
        public static UInt4 operator ++(UInt4 x)
        {
            if(x.data != MaxVal)
                return ++x.data;
            else
                return  MinVal;
        }
            
        [MethodImpl(Inline)]
        public static UInt4 operator --(UInt4 src)
        {
            if(src.data != MinVal)
                src.data--;
            else
                src.data = MaxVal;
            return src;
        }

        [MethodImpl(Inline)]
        UInt4(byte src)
            => data = (uint)(src & MaxVal);

        [MethodImpl(Inline)]
        UInt4(ushort src)
            =>data = (uint)src & MaxVal;

        [MethodImpl(Inline)]
        UInt4(uint src)
            =>data = src & MaxVal;

        [MethodImpl(Inline)]
        UInt4(uint src, bool safe)
            => data = src;

        /// <summary>
        /// Queries and manipulates a bit identified by its 0-based index
        /// </summary>
        public bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => pos < BitWidth ? bit.test(data, pos) : bit.Off;
            
            [MethodImpl(Inline)]
            set => SetBit(pos, value);
        }

        /// <summary>
        /// Queries and manipulates the lower two bits
        /// </summary>
        public UInt4 Lo
        {
            [MethodImpl]
            get => Wrap(data & 0b11);
            
            [MethodImpl(Inline)]
            set 
            {
                var src = value.Lo;
                SetBit(0, src[0]);
                SetBit(1, src[1]);
            }
        }

        /// <summary>
        /// Queries and manipulates the upper two bits
        /// </summary>
        public UInt4 Hi
        {
            [MethodImpl]
            get => Wrap(data >> 2 & 0b11);

            [MethodImpl]
            set
            {
                var src = value.Lo;
                SetBit(2, src[0]);
                SetBit(3, src[1]);
            }
        }

        /// <summary>
        /// Renders the source value as as hexadecimal string
        /// </summary>
        [MethodImpl(Inline)]
        public string Format()
            => HexMap[data].ToString();

 
        [MethodImpl(Inline)]
        public bool Equals(UInt4 rhs)
            => data == rhs.data;

        public override bool Equals(object rhs)
            => rhs is UInt4 x && Equals(x);
       
        public override int GetHashCode()
            => data.GetHashCode();
 
        /// <summary>
        /// Specifies the status an index-identified bit
        /// </summary>
        /// <param name="pos">The 0-based absolute bit position</param>
        [MethodImpl(Inline)]
        void SetBit(int pos, bit bit)
        {
            if(pos < BitWidth)
                data = bit.set(data, (byte)pos, bit);
        }

        [MethodImpl(Inline)]
        static uint reduce(uint x) => x % ModVal;

        [MethodImpl(Inline)]
        static UInt4 Wrap(uint src) => new UInt4(src,false);

        /// <summary>
        /// Defines a mapping from possible UInt4 values to their hex code representations
        /// </summary>
        static char[] HexMap  => new char[]{'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
    }
}