//---------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines a 4-bit bitvector
    /// </summary>
    public struct BitVector4
    {
        internal byte data;

        public static BitVector4 Zero => default;

        public static BitVector4 One => 1;

        public static BitVector4 Ones => 0xF;

        [MethodImpl(Inline)]
        public static implicit operator BitCells<N4,byte>(BitVector4 src)
            => BitCells<N4,byte>.FromArray(src.data);

        [MethodImpl(Inline)]
        public static implicit operator BitVector4(byte src)
            => new BitVector4(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(BitVector4 src)
            => src.data;

        /// <summary>
        /// Computes the XOR of the source operands. 
        /// Note that this operator is equivalent to the addition operator (+)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator ^(in BitVector4 lhs, in BitVector4 rhs)
            => (byte)(lhs.data ^ rhs.data);

        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// Note that the AND operator is equivalent to the (*) operator
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator &(in BitVector4 lhs, in BitVector4 rhs)
            => (byte)(lhs.data & rhs.data);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator |(in BitVector4 lhs, in BitVector4 rhs)
            => BitVector.or(lhs,rhs);

        /// <summary>
        /// Computes the bitwise complement
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator ~(BitVector4 src)
            => BitVector.not(src);

        /// <summary>
        /// Computes the arithmetic sum of the source operands. 
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator +(BitVector4 x, BitVector4 y)
            => BitVector.add(x,y);

        /// <summary>
        /// Computes the product of the operands. 
        /// Note that this operator is equivalent to the AND operator (&)
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator *(in BitVector4 lhs, in BitVector4 rhs)
            => (byte)(lhs.data & rhs.data);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %(BitVector4 lhs, BitVector4 rhs)
            => BitVector.dot(lhs,rhs);

        [MethodImpl(Inline)]
        public static BitVector4 operator -(in BitVector4 src)
            => BitVector.negate(src);

        /// <summary>
        /// Subtracts the second operand from the first. 
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector4 operator - (BitVector4 lhs, BitVector4 rhs)
            => BitVector.sub(lhs,rhs);

        [MethodImpl(Inline)]
        public static BitVector4 operator >>(BitVector4 lhs, int offset)
            => BitVector.srl(lhs,offset);

        [MethodImpl(Inline)]
        public static BitVector4 operator <<(BitVector4 lhs, int offset)
            => BitVector.sll(lhs,offset);

        [MethodImpl(Inline)]
        public static bool operator ==(in BitVector4 lhs, in BitVector4 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitVector4 lhs, in BitVector4 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        internal BitVector4(byte data, bit direct)
            => this.data = data;

        [MethodImpl(Inline)]
        public BitVector4(byte data)
            => this.data = (byte)(data & 0xF);

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
            get => 4;
        }

        /// <summary>
        /// Returns true if all bits are disabled, false otherwise
        /// </summary>
        public readonly bit Empty
        {
            [MethodImpl(Inline)]
            get => data == 0;
        }

        /// <summary>
        /// Returns true if at least one bit is enabled, false otherwise
        /// </summary>
        public readonly bit NonEmpty
        {
            [MethodImpl(Inline)]
            get => data != 0;
        }

        public bool AllOn
        {
            [MethodImpl(Inline)]
            get => (0xF & data) == 0xF;
        }

        public bit this[int pos]
        {
            [MethodImpl(Inline)]
            get => (data & (1 << pos)) != 0;
            
            [MethodImpl(Inline)]
            set => data = BitMask.set(data, (byte)pos, value);
        }

        public BitVector4 this[int first, int last]
        {
            [MethodImpl(Inline)]
            get => BitVector.between(this,first,last);
        }


        [MethodImpl(Inline)]
        public bool Equals(in BitVector4 rhs)
            => data == rhs.data;


        [MethodImpl(Inline)]
        public bool Equals(BitVector4 other)
            => data == other.data;

        public override bool Equals(object obj)
            => obj is BitVector4 x  && Equals(x);
        
        public override int GetHashCode()
            => data.GetHashCode();
        
        public override string ToString()
            => this.Format();

    }
}