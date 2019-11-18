//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
    public struct BitVector32 
    {
        internal uint data;

        /// <summary>
        /// The vector bit-width
        /// </summary>
        public const int Width = 32;

        /// <summary>
        /// Allocates a vector with all bits disabled
        /// </summary>
        public static BitVector32 Zero => default;

        /// <summary>
        /// Allocates a vector that has the least bit enabled and all others disabled
        /// </summary>
        public static BitVector32 One => 1;

        /// <summary>
        /// Allocates a vector with all bits enabled
        /// </summary>
        public static BitVector32 Ones => uint.MaxValue;

        public static N32 N => default;

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N32,uint>(BitVector32 src)
            => BitVector<N32,uint>.FromArray(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector<uint>(BitVector32 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector64(BitVector32 src)
            => BitVector.from(n64,src.data);

        [MethodImpl(Inline)]
        public static explicit operator BitVector4(BitVector32 src)
            => BitVector4.FromScalar((byte)src.data);

        [MethodImpl(Inline)]
        public static explicit operator BitVector8(BitVector32 src)
            => BitVector8.FromScalar((byte)src.data);

        [MethodImpl(Inline)]
        public static explicit operator BitVector16(BitVector32 src)
            => BitVector16.FromScalar((ushort)src.data);

        [MethodImpl(Inline)]
        public static implicit operator uint(BitVector32 src)
            => src.data;        

        /// <summary>
        /// Implicitly converts a scalar value to a 32-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector32(byte src)
            => BitVector.from(N,src);

        /// <summary>
        /// Implicitly converts a scalar value to a 32-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector32(ushort src)
            => BitVector.from(N,src);

        /// <summary>
        /// Implicitly converts a scalar value to a 32-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator BitVector32(uint src)
            => new BitVector32(src);

        /// <summary>
        /// Computes the bitwise XOR of the source operands
        /// Note that the XOR operator is equivalent to the (+) operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator ^(in BitVector32 x, in BitVector32 y)
            => BitVector.xor(x,y);

        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator &(in BitVector32 x, in BitVector32 y)
            => BitVector.and(x,y);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %(in BitVector32 x, in BitVector32 y)
            => BitVector.dot(x,y);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator |(in BitVector32 x, in BitVector32 y)
            => BitVector.or(x,y);

        /// <summary>
        /// Computes the bitwise complement of the operand. 
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator ~(BitVector32 src)
            => BitVector.not(src);

        /// <summary>
        /// Computes the arithmetic sum of the source operands. 
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator +(BitVector32 x, BitVector32 y)
            => BitVector.add(x,y);

        /// <summary>
        /// Arithmetically increments the source vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator ++(BitVector32 src)
            => BitVector.inc(src);

        /// <summary>
        /// Arithmetically decrements the source vector 
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator --(BitVector32 src)
            => BitVector.dec(src);

        /// <summary>
        /// Subtracts the second operand from the first. 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator - (BitVector32 x, BitVector32 y)
            => BitVector.sub(x,y);

        /// <summary>
        /// Negates the operand. Note that this operator is equivalent to the 
        /// complement operator (~)
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator -(BitVector32 src)
            => BitVector.negate(src);

        /// <summary>
        /// Left-shifts the bits in the source
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator <<(BitVector32 x, int offset)
            => BitVector.sll(x,offset);

        /// <summary>
        /// Right-shifts the bits in the source
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector32 operator >>(BitVector32 x, int offset)
            => BitVector.srl(x,offset);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector32 src)
            => src.Nonempty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector32 src)
            => !src.Nonempty;

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector32 x, in BitVector32 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector32 x, in BitVector32 y)
            => !x.Equals(y);

        /// <summary>
        /// Initializes the vector with the source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public BitVector32(uint src)
            : this() => this.data = src;

        public BitVector16 Lo
        {
            [MethodImpl(Inline)]
            get => Bits.lo(data);
        }

        public BitVector16 Hi
        {
            [MethodImpl(Inline)]
            get => Bits.hi(data);
        }
        
        /// <summary>
        /// Presents bitvector content as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(data);
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
        public readonly bool Nonempty
        {
            [MethodImpl(Inline)]
            get => data != 0;
        }

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
        public readonly int Length
        {
            [MethodImpl(Inline)]
            get => Width;
        }

        /// <summary>
        /// Queries/Manipulates index-identified bits
        /// </summary>
        public bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => Get(pos);
            
            [MethodImpl(Inline)]
            set => Set(pos, value);
       }

        /// <summary>
        /// Selects a contiguous range of bits defined by an inclusive 0-based index range
        /// </summary>
        /// <param name="first">The position of the first bit</param>
        /// <param name="last">The position of the last bit</param>
        /// <remarks>Unfortuantely, the range spec/select syntanx [a..b] results in about 50 extra bytes
        /// of assembly (!) of the jmp/cmp/test variety. So, defining a range operator for
        /// performance-sensitive types is hard no-go </remarks>
        public BitVector32 this[int first, int last]
        {
            [MethodImpl(Inline)]
            get => Between(first, last);
        }

        /// <summary>
        /// Selects an index-identified byte where index = 0 | 1 | 2 | 3
        /// </summary>
        /// <param name="index">The 0-based byte-relative position</param>
        [MethodImpl(Inline)]
        public ref byte Byte(int index)        
            => ref Bytes[index];

        /// <summary>
        /// Enables a bit if it is disabled
        /// </summary>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        public void Enable(int pos)
            => data = BitMask.enable(ref data, pos);

        /// <summary>
        /// Disables a bit if it is enabled
        /// </summary>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]
        public void Disable(int pos)
            => data = BitMask.disable(ref data, pos);

        /// <summary>
        /// Gets the value of an index-identified bit
        /// </summary>
        /// <param name="pos">The bit index</param>
        [MethodImpl(Inline)]
        public readonly bit Get(int pos)
            => BitMask.test(data, pos);

        /// <summary>
        /// Sets the state of an index-identified bit
        /// </summary>
        /// <param name="pos">The bit index</param>
        /// <param name="value">The bit value</param>
        [MethodImpl(Inline)]
        public void Set(int pos, bit value)
            => data = BitMask.set(ref data, (byte)pos, value);

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        [MethodImpl(Inline)]
        public readonly BitVector32 Between(int first, int last)
            => Bits.between(data, (byte)first,(byte)last);

        [MethodImpl(Inline)]
        public bool Equals(BitVector32 y)
            => data == y.data;

        public override bool Equals(object obj)
            => obj is BitVector32 x ? Equals(x) : false;
        
        public override int GetHashCode()
            => data.GetHashCode();
 
        public override string ToString()
            => this.Format();
    }
}