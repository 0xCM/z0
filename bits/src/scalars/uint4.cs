//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    

    public struct UInt4 : IEquatable<UInt4>
    {
        uint data;

        public static readonly UInt4 MinValue = MinDataVal;

        public static readonly UInt4 MaxValue = MaxDataVal;

        const uint MinDataVal = 0;

        const uint MaxDataVal = 0xF;

        const uint Modulus = MaxDataVal + 1;

        const int BitCount = 4;        

        /// <summary>
        /// Defines a mapping from possible UInt4 values to their hex code representations
        /// </summary>
        static readonly char[] HexMap 
            = new char[]{'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};

        /// <summary>
        /// Constructs a <see cref='UInt4'/> from a byte value in the range [0, 15]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        UInt4(byte src)
        {            
            data = (uint)(src & 0xF);
        }

        [MethodImpl(Inline)]
        UInt4(uint src)
        {
            
            data = src & 0xF;
        }

        [MethodImpl(Inline)]
        UInt4(uint src, bool safe)
        {            
            data = src;
        }

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
        public static explicit operator UInt4(sbyte src)
            => From(src);

        /// <summary>
        /// Creates a 4-bit integer from the least four bits of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator UInt4(ushort src)
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
        public static explicit operator UInt4(int src)
            => From(src);

        /// <summary>
        /// Creates a 4-bit integer from the least four bits of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static explicit operator UInt4(ulong src)
            => From(src);

        /// <summary>
        /// Constructs a <see cref='UInt4'/> from a sequence of bits ranging from low to high
        /// </summary>
        /// <param name="x0">The first/least bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x1">The second bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x2">The third bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x3">The fourth/highest bit value, if specified; otherwise, defaults to 0</param>
        [MethodImpl(Inline)]
        public static UInt4 FromBits(bit x0, bit x1, bit x2, bit x3)
        {
            var data = 0u;
            if(x0) data |= (1 << 0);
            if(x1) data |= (1 << 1);
            if(x2) data |= (1 << 2);
            if(x3) data |= (1 << 3);
            return data;
        }

        [MethodImpl(Inline)]
        public static UInt4 FromBitSeq(ReadOnlySpan<byte> src, int offset = 0)
        {
            var available = src.Length - offset;
            var dst = default(UInt4);
            
            if(available > 0 && src[0] != 0)
                dst.data |= (1 << 0);
            if(available > 1 && src[1] != 0)
                dst.data |= (1 << 1);
            if(available > 2 && src[2] != 0)
                dst.data |= (1 << 2);
            if(available > 3 && src[3] != 0)
                dst.data |= (1 << 3);
            return dst;
        }


        /// <summary>
        /// Constructs a uint4 value from the 4 least significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 From(sbyte src)        
            => new UInt4((byte)((byte)src & MaxDataVal));

        [MethodImpl(Inline)]
        public static UInt4 From(byte src)
            => new UInt4(src);

        /// <summary>
        /// Constructs a <see cref='UInt4'> value from the 4 least significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 From(int src)        
            => new UInt4((byte)((byte)src & MaxDataVal));

        [MethodImpl(Inline)]
        public static UInt4 From(uint src)
            => new UInt4(src);

        /// <summary>
        /// Constructs a uint4 value from the 4 least significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 From(long src)        
            => new UInt4((byte)((byte)src & MaxDataVal));

        /// <summary>
        /// Constructs a uint4 value from the 4 least significant bits of a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static UInt4 From(ulong src)        
            => new UInt4((byte)((byte)src & MaxDataVal));

        [MethodImpl(Inline)]
        public static UInt4 operator + (UInt4 x, UInt4 y)
        {
            var sum = x.data + y.data;
            return Wrap((sum >= Modulus) 
                ? sum - Modulus
                : sum);
        }

        [MethodImpl(Inline)]
        public static UInt4 operator - (UInt4 x, UInt4 y)
        {
            var diff = (int)x - (int)y;
            return Wrap(diff < 0 
                ? (uint)(diff + Modulus) 
                : (uint)diff);
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
            if(x.data != MaxDataVal)
                return ++x.data;
            else
                return  MinDataVal;
        }
            
        [MethodImpl(Inline)]
        public static UInt4 operator --(UInt4 src)
        {
            if(src.data != MinDataVal)
                src.data--;
            else
                src.data = MaxDataVal;
            return src;
        }



        /// <summary>
        /// Returns true if an index-identified bit is enabled; false otherwise
        /// </summary>
        /// <param name="pos">The 0-based absolute bit position</param>
        [MethodImpl(Inline)]
        public bit TestBit(byte pos)
            => pos < BitCount ? BitMask.test(data, pos) : bit.Off;

        /// <summary>
        /// Multiplies the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        static UInt4 Mul(UInt4 lhs, UInt4 rhs)
            => Wrap(reduce(lhs * rhs));

        /// <summary>
        /// Multiplies the current value by a source value
        /// </summary>
        /// <param name="rhs">The source value</param>
        [MethodImpl(Inline)]
        public UInt4 MulBy(UInt4 rhs)
        {
            data = reduce(data * rhs.data);
            return this;
        }

        /// <summary>
        /// Enables an index-identified bit if its not already enabled
        /// </summary>
        /// <param name="pos">The 0-based absolute bit position</param>
        [MethodImpl(Inline)]
        public void Enable(byte pos)
        {
            if(pos < BitCount)
                data |= (byte)(1 << pos);
        }

        /// <summary>
        /// Disables an index-identified bit if its not already disabled
        /// </summary>
        /// <param name="pos">The 0-based absolute bit position</param>
        [MethodImpl(Inline)]
        public void DisableBit(byte pos)
        {
            if(pos < BitCount)
                BitMask.disable(ref data, pos);
        }

        /// <summary>
        /// Specifies the status an index-identified bit
        /// </summary>
        /// <param name="pos">The 0-based absolute bit position</param>
        [MethodImpl(Inline)]
        public void SetBit(byte pos, Bit bit)
        {
            if(pos < BitCount)
                BitMask.set(ref data, pos, bit);
        }

        /// <summary>
        /// Queries and manipulates a bit identified by its 0-based index
        /// </summary>
        public Bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => TestBit((byte)pos);
            
            [MethodImpl(Inline)]
            set => SetBit((byte)pos, value);
        }

        /// <summary>
        /// Queries and manipulates the lower two bits
        /// </summary>
        public UInt4 Lo
        {
            [MethodImpl]
            get => From(Bits.between(data,0, 1));
            
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
            get => From(Bits.between(data,2, 3));

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

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public BitString ToBitString()
            => BitString.FromBitSeq(gbits.bitseq(data).Slice(0,BitCount));

        [MethodImpl(Inline)]
        public bool Equals(UInt4 rhs)
            => data == rhs.data;

        public override bool Equals(object rhs)
            => rhs is UInt4 x ? Equals(x) : false;
       
        public override int GetHashCode()
            => data.GetHashCode();
 
        [MethodImpl(Inline)]
        static uint reduce(uint x)
            => Mod16.mod(x);

        [MethodImpl(Inline)]
        static UInt4 Wrap(uint src)
            => new UInt4(src,false);

         [MethodImpl(Inline)]
        UInt4 RotL(int offset)
            => (data << offset) | data >> (BitCount - offset);

    }
}