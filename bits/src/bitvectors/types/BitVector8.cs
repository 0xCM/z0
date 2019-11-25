//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static Bits;

    public struct BitVector8
    {
        internal byte data;

        public static BitVector8 Zero => default;

        public static BitVector8 One => 1;

        public static BitVector8 Ones => byte.MaxValue;
                    
        /// <summary>
        /// Enumerates each and every nonmpty 8-bit bitvector exactly once
        /// </summary>
        public static IEnumerable<BitVector8> AllNonempty
        {
           get
           {
                var bv = BitVector8.One;
                do            
                    yield return bv;            
                while(++bv);
           }
        }

        [MethodImpl(Inline)]
        public static implicit operator BitCells<N8,byte>(in BitVector8 src)
            => BitCells<N8,byte>.FromArray(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector<byte>(BitVector8 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector8(byte src)
            => new BitVector8(src);

        /// <summary>
        /// Implicitly converts a byte classifier to a vector
        /// </summary>
        /// <param name="src">The classifier</param>
        [MethodImpl(Inline)]
        public static implicit operator BitVector8(ByteKind src)
            => (byte)src;

        /// <summary>
        /// Implicitly converts a vector to a byte classifier
        /// </summary>
        /// <param name="src">The vector</param>
        [MethodImpl(Inline)]
        public static implicit operator ByteKind(BitVector8 src)
            => (ByteKind)src.data;

        /// <summary>
        /// Converts the source vector to the underlying value it represents
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static implicit operator byte(BitVector8 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector16(BitVector8 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector32(BitVector8 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector64(BitVector8 src)
            => src.data;

        /// <summary>
        /// <summary>
        /// Computes the component-wise AND of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator &(BitVector8 x, BitVector8 y)
            => BitVector.and(x,y);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator |(BitVector8 x, BitVector8 y)
            => BitVector.or(x,y);

        /// Computes the XOR of the source operands. 
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator ^(BitVector8 x, BitVector8 y)
            => BitVector.xor(x,y);

        /// <summary>
        /// Left-shifts the bits in the source
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator <<(BitVector8 x, int offset)
            => BitVector.sll(x,offset);

        /// <summary>
        /// Right-shifts the bits in the source
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator >>(BitVector8 x, int offset)
            => BitVector.srl(x,offset);

        /// <summary>
        /// Computes the one's complement of the operand. 
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator ~(BitVector8 src)
            => BitVector.not(src);

        /// <summary>
        /// Computes the two's complement of the operand
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator -(in BitVector8 src)
            => BitVector.negate(src);

        /// <summary>
        /// Computes the arithmetic sum of the source operands. 
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator +(BitVector8 x, BitVector8 y)
            => BitVector.add(x,y);

        /// <summary>
        /// Computes the product of the operands. 
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator *(BitVector8 x, BitVector8 y)
            => BitVector.gfmul(x,y);

        /// <summary>
        /// Subtracts the second operand from the first. 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator - (BitVector8 x, BitVector8 y)
            => BitVector.sub(x,y);

        /// <summary>
        /// Raises a vector b to a power n where n >= 0
        /// </summary>
        /// <param name="b">The base vector</param>
        /// <param name="n">The power</param>
        [MethodImpl(Inline)]        
        public static BitVector8 operator ^(BitVector8 b, int n)
            => BitVector.pow(b,n);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %(BitVector8 x, BitVector8 y)
            => BitVector.dot(x,y);

        /// <summary>
        /// Arithmetically increments the bitvector
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator ++(BitVector8 src)
            => BitVector.inc(src);

        /// <summary>
        /// Arithmetically decrements the bitvector
        /// </summary>
        /// <param name="lhs">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector8 operator --(BitVector8 src)
            => BitVector.dec(src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector8 src)
            => src.NonEmpty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector8 src)
            => src.Empty;

        [MethodImpl(Inline)]
        public static Bit operator !(BitVector8 src)
            => src.Empty;

        [MethodImpl(Inline)]
        public static bool operator ==(BitVector8 x, BitVector8 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(BitVector8 x, BitVector8 y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static bit operator <(BitVector8 x, BitVector8 y)
            => x.data < y.data ? bit.On : bit.Off;

        [MethodImpl(Inline)]
        public static bit operator >(BitVector8 x, BitVector8 y)
            => x.data > y.data ? bit.On : bit.Off;

        [MethodImpl(Inline)]
        public static bit operator <=(BitVector8 x, BitVector8 y)
            => x.data <= y.data ? bit.On : bit.Off;

        [MethodImpl(Inline)]
        public static bit operator >=(BitVector8 x, BitVector8 y)
            => x.data >= y.data ? bit.On : bit.Off;

        [MethodImpl(Inline)]
        public BitVector8(byte src)
            => this.data = src;        

        /// <summary>
        /// Extracts the scalar represented by the vector
        /// </summary>
        public byte Scalar
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
            get => 8;
        }        

        public bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => BitMask.test(data, pos);
            
            [MethodImpl(Inline)]
            set => data = BitMask.set(data, (byte)pos, value);
        }

        /// <summary>
        /// The vector's 4 most significant bits
        /// </summary>
        public readonly BitVector4 Hi
        {
            [MethodImpl(Inline)]
            get => hi(data);        
        }        

        /// <summary>
        /// The vector's 4 least significant bits
        /// </summary>
        public readonly BitVector4 Lo
        {
            [MethodImpl(Inline)]
            get => lo(data);        
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
        /// Selects a contiguous range of bits
        /// </summary>
        /// <param name="first">The position of the first bit</param>
        /// <param name="last">The position of the last bit</param>
        public BitVector8 this[int first, int last]
        {
            [MethodImpl(Inline)]
            get => BitVector.between(this,first,last);
        }
            
        /// <summary>
        /// Returns true if all bits are enabled, false otherwise
        /// </summary>
        public readonly bit AllOn
        {
            [MethodImpl(Inline)]
            get => (0xFF & data) == 0xFF;
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
            get => !Empty;
        }

        [MethodImpl(Inline)]
        public readonly bool Equals(BitVector8 y)
            => data == y.data;

        public override bool Equals(object obj)
            => obj is BitVector8 x ? Equals(x) : false;
        
        public override int GetHashCode()
            => data.GetHashCode();
        
        public override string ToString()
            => this.Format();

    }
}