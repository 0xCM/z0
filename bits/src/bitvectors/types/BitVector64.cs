//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    /// <summary>
    /// Defines a 64-bit bitvector
    /// </summary>
    public struct BitVector64 
    {    
        internal ulong data;

        public static BitVector64 Zero => default;

        public static BitVector64 One => 1;                

        public static BitVector64 Ones => uint.MaxValue;

        public static N64 N => default;

        [MethodImpl(Inline)]
        public static implicit operator BitCells<N64,ulong>(BitVector64 src)
            => BitCells.literal(src.data, N);

        [MethodImpl(Inline)]
        public static implicit operator BitVector<ulong>(BitVector64 src)
            => src.data;

        /// <summary>
        /// Implicitly converts an unsigned 64-bit integer to a 64-bit bitvector
        /// </summary>
        /// <param name="src">The source integer</param>
        [MethodImpl(Inline)]
        public static implicit operator BitVector64(ulong src)
            => new BitVector64(src);

        /// <summary>
        /// Implicitly converts a bitvector to a 64-bit unsigned integer
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator ulong(BitVector64 src)
            => src.data;        

        /// <summary>
        /// Explicitly converts a a 64-bit bitvector to an 8-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator BitVector4(BitVector64 src)
            => BitVector.from(n4,(byte)src.data);        

        /// <summary>
        /// Explicitly converts a a 64-bit bitvector to an 8-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator BitVector8(BitVector64 src)
            => (byte)src.data;

        /// <summary>
        /// Explicitly converts a a 64-bit bitvector to a 16-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator BitVector16(BitVector64 src)
            => (ushort)src.data;

        /// <summary>
        /// Explicitly converts a a 64-bit bitvector to a 32-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static explicit operator BitVector32(BitVector64 src)
            => BitVector.from(n32, (uint)src.data);        

        /// <summary>
        /// Implicitly converts a scalar value to a 64-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector64(byte src)
            => BitVector.from(N,src);

        /// <summary>
        /// Implicitly converts a scalar value to a 64-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector64(ushort src)
            => BitVector.from(N,src);

        /// <summary>
        /// Implicitly converts a scalar value to a 64-bit bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]    
        public static implicit operator BitVector64(uint src)
            => BitVector.from(N,src);

        /// <summary>
        /// Computes the bitwise XOR of the source operands
        /// Note that the XOR operator is equivalent to the (+) operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator ^(BitVector64 x, BitVector64 y)
            => BitVector.xor(x,y);
        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator &(BitVector64 x, BitVector64 y)
            => BitVector.and(x,y);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator |(BitVector64 x, BitVector64 y)
            => BitVector.or(x,y);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %(BitVector64 x, BitVector64 y)
            => BitVector.dot(x,y);

        /// <summary>
        /// Computes the arithmetic sum of the source operands. 
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator +(BitVector64 x, BitVector64 y)
            => BitVector.add(x,y);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator ~(BitVector64 src)
            => BitVector.not(src);

        /// <summary>
        /// Negates the operand via two's complement
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator -(BitVector64 src)
            => BitVector.negate(src);

        /// <summary>
        /// Arithmetically subtracts the second operand from the first. 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator - (BitVector64 x, BitVector64 y)
            => BitVector.sub(x,y);

        /// <summary>
        /// Shifts the source bits leftwards
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator <<(BitVector64 x, int shift)
            => BitVector.sll(x,shift);

        /// <summary>
        /// Shifts the source bits rightwards
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator >>(BitVector64 x, int shift)
            => BitVector.srl(x,shift);

        /// <summary>
        /// Increments the vector arithmetically
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator ++(BitVector64 x)
            => BitVector.inc(x);

        /// <summary>
        /// Decrements the vector arithmetically
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 operator --(BitVector64 x)
            => BitVector.dec(x);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector64 x)
            => x.NonEmpty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector64 x)
            => !x.NonEmpty;

        /// <summary>
        /// Computes the operand's logical negation: if x = 0 then 1 else 0
        /// </summary>
        /// <param name="src">The ource operand</param>
        [MethodImpl(Inline)]
        public static bit operator !(BitVector64 src)
            => src.Empty;

        /// <summary>
        /// Determines whether operand content is identical
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator ==(BitVector64 x, BitVector64 y)
            => x.data == y.data;

        /// <summary>
        /// Determines whether operand content is non-identical
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator !=(BitVector64 x, BitVector64 y)
            => math.neq(x,y);

        /// <summary>
        /// Determines whether the left operand is arithmetically less than the second
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator <(BitVector64 x, BitVector64 y)
            => math.lt(x,y);

        /// <summary>
        /// Determines whether the left operand is arithmetically greater than the second
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator >(BitVector64 x, BitVector64 y)
            => math.gt(x,y);

        /// <summary>
        /// Determines whether the left operand is arithmetically less than or equal to the second
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator <=(BitVector64 x, BitVector64 y)
            => math.lteq(x,y);

        /// <summary>
        /// Determines whether the left operand is arithmetically greater than or equal to the second
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator >=(BitVector64 x, BitVector64 y)
            => math.gteq(x,y);

        /// <summary>
        /// Initializes a vector with the primal source value it represents
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public BitVector64(ulong data)
            => this.data = data;

        /// <summary>
        /// Extracts the scalar represented by the vector
        /// </summary>
        public readonly ulong Scalar
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// The actual number of bits represented by the vector
        /// </summary>
        public readonly int Width
        {
            [MethodImpl(Inline)]
            get => 64;
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
        public readonly bit Empty
        {
            [MethodImpl(Inline)]
            get => data == 0;
        }

        /// <summary>
        /// Returns true if the vector has at least one enabled bit; false otherwise
        /// </summary>
        public readonly bit NonEmpty
        {
            [MethodImpl(Inline)]
            get => data != 0;
        }

        /// <summary>
        /// Tests whether all bits are on
        /// </summary>
        public readonly bool AllOn
        {
            [MethodImpl(Inline)]
            get => (UInt64.MaxValue & data) == UInt64.MaxValue;
        }

        /// <summary>
        /// The vector's 32 least significant bits
        /// </summary>
        public readonly BitVector32 Lo
        {
            [MethodImpl(Inline)]
            get => BitVector.from(n32, (uint)data);
        }

        /// <summary>
        /// The vector's 32 most significant bits
        /// </summary>
        public readonly BitVector32 Hi
        {
            [MethodImpl(Inline)]
            get => BitVector.from(n32,(uint)(data >> 32));
        }        

        /// <summary>
        /// Reads/Manipulates a source bit at a specified position
        /// </summary>
        public bit this[int index]
        {
            [MethodImpl(Inline)]
            get => BitMask.testbit(data, index);
            
            [MethodImpl(Inline)]
            set => data = BitMask.set(data, (byte)index, value);
        }

        /// <summary>
        /// Selects a contiguous range of bits
        /// </summary>
        /// <param name="first">The position of the first bit</param>
        /// <param name="last">The position of the last bit</param>
        public BitVector64 this[int first, int last]
        {
            [MethodImpl(Inline)]
            get => BitVector.between(this,first, last);
        }

        /// <summary>
        /// Selects an index-identified byte where index = 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7
        /// </summary>
        /// <param name="index">The 0-based byte-relative position</param>
        [MethodImpl(Inline)]
        public ref byte Byte(int index)        
            => ref Bytes[index];
                                    
        [MethodImpl(Inline)]
        public readonly bool Equals(BitVector64 y)
            => data == y.data;

        public override bool Equals(object obj)
            => obj is BitVector64 x && Equals(x); 
        
        public override int GetHashCode()
            => data.GetHashCode();
 
        public override string ToString()
            => this.Format(); 
    }
}