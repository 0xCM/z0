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

    /// <summary>
    /// Defines a generic bitvector over a primal type
    /// </summary>
    /// <typeparam name="T">The type over which the vector is defined</typeparam>
    public struct BitVector<T>
        where T : unmanaged
    {
        internal T data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector<T>(T src)
            => new BitVector<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(BitVector<T> src)
            => src.data;

        /// <summary>
        /// Computes the bitwias AND between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector<T> operator &(BitVector<T> x, BitVector<T> y)
            => BitVector.and(x,y);

        /// <summary>
        /// Computes the bitwias AND between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector<T> operator |(BitVector<T> x, BitVector<T> y)
            => BitVector.or(x,y);

        /// <summary>
        /// Computes the bitwise XOR between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector<T> operator ^(BitVector<T> x, BitVector<T> y)
            => BitVector.xor(x,y);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %(BitVector<T> x, BitVector<T> y)
            => BitVector.dot(x,y);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<T> operator ~(BitVector<T> src)
            => BitVector.not(src);

        /// <summary>
        /// Computes the two's complement negation of the operand
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<T> operator -(BitVector<T> src)
            => BitVector.negate(src);

        /// <summary>
        /// Computes the arithmetic sum of the source operands. 
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector<T> operator +(BitVector<T> x, BitVector<T> y)
            => BitVector.add(x,y);

        /// <summary>
        /// Arithmetically subtracts the second operand from the first. 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector<T> operator - (BitVector<T> x, BitVector<T> y)
            => BitVector.sub(x,y);

        /// <summary>
        /// Shifts the source bits leftwards
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<T> operator <<(BitVector<T> x, int offset)
            => BitVector.sll(x,offset);

        /// <summary>
        /// Shifts the source bits rightwards
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<T> operator >>(BitVector<T> x, int offset)
            => BitVector.srl(x,offset);

        /// <summary>
        /// Increments the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<T> operator ++(BitVector<T> src)
            => BitVector.inc(src);

        /// <summary>
        /// Decrements the vector arithmetically
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<T> operator --(BitVector<T> src)
            => BitVector.dec(src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector<T> src)
            => src.NonEmpty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector<T> src)
            => !src.NonEmpty;

        [MethodImpl(Inline)]
        public static bool operator ==(BitVector<T> x, BitVector<T> y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(BitVector<T> x, BitVector<T> y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        internal BitVector(T src)
            => this.data = src;

        /// <summary>
        /// Specifies the data over which the vector is defined
        /// </summary>
        public readonly T Scalar
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
            get => bitsize<T>();
        }

        /// <summary>
        /// Converts the encapsulated data to a bytespan
        /// </summary>
        public readonly Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(data);
        }

        /// <summary>
        /// Specifies whether all bits are disabled
        /// </summary>
        public bool Empty
        {
            [MethodImpl(Inline)]
            get => BitVector.pop(this) == 0;
        }

        /// <summary>
        /// Specifies whether at least one bit is enabled
        /// </summary>
        public readonly bool NonEmpty
        {
            [MethodImpl(Inline)]
            get => BitVector.pop(this) != 0;
        }

        /// <summary>
        /// Reads/Manipulates a single bit
        /// </summary>
        public bit this[int index]
        {
            [MethodImpl(Inline)]
            get => gbits.test(data, index);
            
            [MethodImpl(Inline)]
            set => data = gbits.set(data, index, value);
        }

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        public BitVector<T> this[int first, int last]
        {
            [MethodImpl(Inline)]
            get => BitVector.between(this, first, last);
        }

        /// <summary>
        /// Clones the vector
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitVector<T> Replicate()
            => new BitVector<T>(data);

        [MethodImpl(Inline)]
        public readonly bool Equals(BitVector<T> y)
            => gmath.eq(data, y.data);

        public readonly override bool Equals(object obj)
            => obj is BitVector<T> x && Equals(x);
        
        public readonly override int GetHashCode()
            => data.GetHashCode();
    
        public override string ToString()
            => this.Format();
    }
}
