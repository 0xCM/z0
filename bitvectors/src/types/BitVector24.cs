//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    /// <summary>
    /// Defines a 32-bit bitvector
    /// </summary>
    public struct BitVector24 
    {        
        [MethodImpl(Inline)]   
        public static BitVector24 FromEnum<T>(T src)
            where T : unmanaged, Enum
                => Enums.numeric<T,uint>(src);
        const uint MaxValue = uint.MaxValue >> 8;

        internal uint data;

        /// <summary>
        /// Allocates a vector with all bits disabled
        /// </summary>
        public static BitVector24 Zero => default;

        /// <summary>
        /// Allocates a vector that has the least bit enabled and all others disabled
        /// </summary>
        public static BitVector24 One => 1;

        /// <summary>
        /// Allocates a vector with all bits enabled
        /// </summary>
        public static BitVector24 Ones => MaxValue;

        public static N24 N => default;
        

        [MethodImpl(Inline)]
        public static implicit operator BitVector64(BitVector24 src)
            => BitVector.create(n64,src.data);

        [MethodImpl(Inline)]
        public static explicit operator BitVector4(BitVector24 src)
            => new BitVector4((byte)src.data);

        [MethodImpl(Inline)]
        public static explicit operator BitVector8(BitVector24 src)
            => (byte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator BitVector16(BitVector24 src)
            =>(ushort)src.data;

        [MethodImpl(Inline)]
        public static implicit operator uint(BitVector24 src)
            => src.data;        

        /// <summary>
        /// Implicitly converts a scalar value to a 32-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator BitVector24(uint src)
            => new BitVector24(src);

        /// <summary>
        /// Implicitly converts a scalar value to a 32-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector24(byte src)
            => (uint)src;

        /// <summary>
        /// Implicitly converts a scalar value to a 32-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector24(ushort src)
            => (uint)src;

        /// <summary>
        /// Implicitly constructs a bitvector from a tuple
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector24((ushort lo, byte hi) src)
            => new BitVector24(src.lo, src.hi);

        /// <summary>
        /// Computes the bitwise XOR of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector24 operator ^(BitVector24 x, BitVector24 y)
            => x.data ^ y.data;

        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector24 operator &(BitVector24 x, BitVector24 y)
            => x.data & y.data;

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %(BitVector24 x, BitVector24 y)
            => BitVector.dot(x.data, y.data);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector24 operator |(BitVector24 x, BitVector24 y)
            => x.data | y.data;

        /// <summary>
        /// Computes the bitwise complement of the operand. 
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector24 operator ~(BitVector24 src)
            =>  ~ src.data;

        /// <summary>
        /// Computes the two's complement of the operand
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector24 operator -(BitVector24 x)
            => math.negate(x.data);

        /// <summary>
        /// Left-shifts the bits in the source
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector24 operator <<(BitVector24 x, int shift)
            => x.data << shift;

        /// <summary>
        /// Right-shifts the bits in the source
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector24 operator >>(BitVector24 x, int shift)
            => x.data >> shift;

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector24 x)
            => x.NonEmpty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector24 x)
            => x.Empty;

        /// <summary>
        /// Computes the operand's logical negation: if x = 0 then 1 else 0
        /// </summary>
        /// <param name="src">The ource operand</param>
        [MethodImpl(Inline)]
        public static bit operator !(BitVector24 src)
            => src.Empty;

        /// <summary>
        /// Determines whether operand content is identical
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator ==(BitVector24 x, BitVector24 y)
            => x.data == y.data;

        /// <summary>
        /// Determines whether operand content is non-identical
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator !=(BitVector24 x, BitVector24 y)
            => x.data != y.data;

        /// <summary>
        /// Determines whether the left operand is arithmetically less than the second
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator <(BitVector24 x, BitVector24 y)
            => math.lt(x,y);

        /// <summary>
        /// Determines whether the left operand is arithmetically greater than the second
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator >(BitVector24 x, BitVector24 y)
            => math.gt(x,y);

        /// <summary>
        /// Determines whether the left operand is arithmetically less than or equal to the second
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator <=(BitVector24 x, BitVector24 y)
            => math.lteq(x,y);

        /// <summary>
        /// Determines whether the left operand is arithmetically greater than or equal to the second
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator >=(BitVector24 x, BitVector24 y)
            => math.gteq(x,y);

        /// <summary>
        /// Initializes the vector
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public BitVector24(uint src)
            => this.data = src & MaxValue;

        /// <summary>
        /// Initializes the vector
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public BitVector24(ushort lo, byte hi)
            => this.data = (uint)lo | (uint)hi << 16;

        /// <summary>
        /// Extracts the scalar represented by the vector
        /// </summary>
        public readonly uint Scalar
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// The number of bits represented by the vector
        /// </summary>
        public readonly int Width
        {
            [MethodImpl(Inline)]
            get => 24;
        }

        /// <summary>
        /// The first 8 bits of the vector
        /// </summary>
        public BitVector8 Lo8
        {
            [MethodImpl(Inline)]
            get => (byte)data;
        }

        /// <summary>
        /// The middle 8 bits of the vector
        /// </summary>
        public BitVector8 Mid8
        {
            [MethodImpl(Inline)]
            get => (byte)(data >> 8);
        }

        /// <summary>
        /// The upper 8 bits of the vector
        /// </summary>
        public BitVector8 Hi8
        {
            [MethodImpl(Inline)]
            get => (byte)(data >> 16);
        }

        /// <summary>
        /// The first 16 bits of the vector
        /// </summary>
        public BitVector16 Lo16
        {
            [MethodImpl(Inline)]
            get => (ushort)data;
        }

        /// <summary>
        /// The last 16 bits of the vector
        /// </summary>
        public BitVector16 Hi16
        {
            [MethodImpl(Inline)]
            get => (ushort)(data >> 8);
        }
        
        /// <summary>
        /// Presents bitvector content as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(data).Slice(0,3);
        }

        /// <summary>
        /// Returns true if no bits are enabled, false otherwise
        /// </summary>
        public readonly bool Empty
        {
            [MethodImpl(Inline)]
            get => data == 0;
        }

        /// <summary>
        /// Returns true if the vector has at least one enabled bit; false otherwise
        /// </summary>
        public readonly bool NonEmpty
        {
            [MethodImpl(Inline)]
            get => data != 0;
        }

        /// <summary>
        /// Queries/Manipulates index-identified bits
        /// </summary>
        public bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => bit.test(data, pos);
            
            [MethodImpl(Inline)]
            set => data = bit.set(data, (byte)pos, value);
       }

        /// <summary>
        /// Selects a contiguous range of bits defined by an inclusive 0-based index range
        /// </summary>
        /// <param name="first">The position of the first bit</param>
        /// <param name="last">The position of the last bit</param>
        /// <remarks>Unfortuantely, the range spec/select syntanx [a..b] results in about 50 extra bytes
        /// of assembly (!) of the jmp/cmp/test variety. So, defining a range operator for
        /// performance-sensitive types is hard no-go </remarks>
        public BitVector24 this[int first, int last]
        {
            [MethodImpl(Inline)]
            get =>  Bits.between(data, (byte)first,(byte)last);
        }

        [MethodImpl(Inline)]
        public bool Equals(BitVector24 y)
            => data == y.data;

        public override bool Equals(object obj)
            => obj is BitVector24 x ? Equals(x) : false;
        
        public override int GetHashCode()
            => data.GetHashCode();
 
        public override string ToString()
            => data.ToBitString(24).Format();
    }
}