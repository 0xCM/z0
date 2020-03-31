//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;    

    /// <summary>
    /// Defines a 16-bit bitvector
    /// </summary>
    public struct BitVector16 : IBitVector<BitVector16,ushort>
    {
        internal ushort data;            

        public static BitVector16 Zero => 0;

        public static BitVector16 One => 1;

        public static BitVector16 Ones => ushort.MaxValue;

        public static N16 N => default;

        [MethodImpl(Inline)]
        public static implicit operator BitVector<ushort>(BitVector16 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector16(ushort src)
            => new BitVector16(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort(BitVector16 src)
            => src.data;        

        [MethodImpl(Inline)]
        public static implicit operator BitVector32(BitVector16 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector64(BitVector16 src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator BitVector8(BitVector16 src)
            => (byte)src.data;

        /// <summary>
        /// Computes the bitwise AND of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator &(BitVector16 x, BitVector16 y)
            => BitVector.and(x,y);

        /// <summary>
        /// Computes the bitwise OR of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator |(BitVector16 x, BitVector16 y)
            => BitVector.or(x,y);

        /// <summary>
        /// Computes the bitwise XOR of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator ^(BitVector16 x, BitVector16 y)
            => BitVector.xor(x,y);

        /// <summary>
        /// Computes the bitwise complement of the operand. 
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator ~(BitVector16 src)
            => BitVector.not(src);

        /// <summary>
        /// Computes the arithmetic sum of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator +(BitVector16 x, BitVector16 y)
            => BitVector.add(x,y);

        /// <summary>
        /// Computes the two's complement of the operand
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator -(BitVector16 x)
            => BitVector.negate(x);

        /// <summary>
        /// Computes the arithmetic difference between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator - (BitVector16 x, BitVector16 y)
            => BitVector.sub(x,y);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %(BitVector16 x, BitVector16 y)
            => BitVector.dot(x,y);

        /// <summary>
        /// Left-shifts the bits in the source
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator <<(BitVector16 x, int shift)
            => BitVector.sll(x,(byte)shift);

        /// <summary>
        /// Right-shifts the bits in the source
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator >>(BitVector16 x, int shift)
            => BitVector.srl(x,(byte)shift);

        /// <summary>
        /// Arithmetically increments the source vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator ++(BitVector16 src)
            => BitVector.inc(src);

        /// <summary>
        /// Arithmetically decrements the source vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 operator --(BitVector16 src)
            => BitVector.dec(src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector16 src)
            => src.NonEmpty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector16 src)
            => src.Empty;

        /// <summary>
        /// Computes the operand's logical negation: if x = 0 then 1 else 0
        /// </summary>
        /// <param name="src">The ource operand</param>
        [MethodImpl(Inline)]
        public static bit operator !(BitVector16 src)
            => src.Empty;

        /// <summary>
        /// Determines whether operand content is identical
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator ==(BitVector16 x, BitVector16 y)
            => math.eq(x,y);

        /// <summary>
        /// Determines whether operand content is non-identical
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator !=(BitVector16 x, BitVector16 y)
            => math.neq(x,y);

        /// <summary>
        /// Determines whether the left operand is arithmetically less than the second
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator <(BitVector16 x, BitVector16 y)
            => math.lt(x,y);

        /// <summary>
        /// Determines whether the left operand is arithmetically greater than the second
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator >(BitVector16 x, BitVector16 y)
            => math.gt(x,y);

        /// <summary>
        /// Determines whether the left operand is arithmetically less than or equal to the second
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator <=(BitVector16 x, BitVector16 y)
            => math.lteq(x,y);

        [MethodImpl(Inline)]
        public static bit operator >=(BitVector16 x, BitVector16 y)
            => math.gteq(x,y);

        /// <summary>
        /// Initializes the vector with the source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public BitVector16(ushort src)
            => this.data = src;

        /// <summary>
        /// Extracts the scalar represented by the vector
        /// </summary>
        public ushort Scalar
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
            get => 16;
        }

        /// <summary>
        /// Returns true if no bits are enabled, false otherwise
        /// </summary>
        public bit Empty
        {
            [MethodImpl(Inline)]
            get => data == 0;
        }

        /// <summary>
        /// Returns true if the vector has at least one enabled bit; false otherwise
        /// </summary>
        public bit NonEmpty
        {
            [MethodImpl(Inline)]
            get => data != 0;
        }

        public bit AllOn
        {
            [MethodImpl(Inline)]
            get => (UInt16.MaxValue & data) == UInt16.MaxValue;
        }

        /// <summary>
        /// The vector's 8 least significant bits
        /// </summary>
        public BitVector8 Lo
        {
            [MethodImpl(Inline)]
            get => (byte)data;
        }

        /// <summary>
        /// The vector's 8 most significant bits
        /// </summary>
        public BitVector8 Hi
        {
            [MethodImpl(Inline)]
            get => (byte)(data >> 8);
        }
    
        /// <summary>
        /// Presents bitvector content as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => BitVector.bytes(data);
        }

        /// <summary>
        /// Gets/Sets an identified bit
        /// </summary>
        public bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => bit.test(data, pos);
            
            [MethodImpl(Inline)]
            set => data = bit.set(data, (byte)pos, value);
        }
        
        /// <summary>
        /// Selects a contiguous range of bits
        /// </summary>
        /// <param name="first">The position of the first bit</param>
        /// <param name="last">The position of the last bit</param>
        public BitVector16 this[int first, int last]
        {
            [MethodImpl(Inline)]
            get => BitVector.seg(this, first, last);
        }

        [MethodImpl(Inline)]
        public bool Equals(BitVector16 y)
            => data == y.data;

        public override bool Equals(object obj)
            => obj is BitVector16 x ? Equals(x) : false;
        
        public override int GetHashCode()
            => data.GetHashCode();
        
         public string Format(BitFormatConfig config)
            => BitVector.format(this,config);

        public string Format()
            => BitVector.format(this);

        public override string ToString()
            => Format();
  }

}