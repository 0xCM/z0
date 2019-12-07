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
    /// Defines a natural bitvector over a primal cell
    /// </summary>
    /// <typeparam name="T">The cell type</typeparam>
    /// <typeparam name="N">The bit-width type</typeparam>
    /// <remarks>There are three notions of width that are applicable to this data structure.
    /// First, the bit width of the primal cell which determines the maximum number of
    /// bits that can be covered. Next is the natural parametric width that defines an
    /// upper bound for the effective width. Finally, is the effective bitvector width, a value
    /// which is bounded above by the the natural width
    /// </remarks>
    public struct BitVector<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        internal T data;

        /// <summary>
        /// The physical width of the vector
        /// </summary>
        public static int MaxWidth => bitsize<T>();

        /// <summary>
        /// The maximum arithmetic value of the vector, constrained by the natural width
        /// </summary>
        public static T MaxValue 
        {
            [MethodImpl(Inline)]
            get => convert<ulong,T>(NatMath.pow2m1<N>());
        }

        public static T Zero => default;

        /// <summary>
        /// Directly assigns a value to a vector storage cell, bypassing masked initialization
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        internal static BitVector<N,T> Inject(T src)
            => new BitVector<N, T>(src, true);

        /// <summary>
        /// Implicitly convers a scalar to a bitvector
        /// </summary>
        /// <param name="src">The scalar value</param>
        [MethodImpl(Inline)]
        public static implicit operator BitVector<N,T>(T src)
            => new BitVector<N, T>(src);

        /// <summary>
        /// Implicitly convers a bitvector to its scalar representation
        /// </summary>
        /// <param name="src">The scalar value</param>
        [MethodImpl(Inline)]
        public static implicit operator T(BitVector<N,T> src)
            => src.data;

        /// <summary>
        /// Computes the bitwias AND between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator &(BitVector<N,T> x, BitVector<N,T> y)
            => BitVector.and(x,y);

        /// <summary>
        /// Computes the bitwias AND between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator |(BitVector<N,T> x, BitVector<N,T> y)
            => BitVector.or(x,y);

        /// <summary>
        /// Computes the bitwise XOR between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator ^(BitVector<N,T> x, BitVector<N,T> y)
            => BitVector.xor(x,y);

        /// <summary>
        /// Computes the scalar product of the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static bit operator %(BitVector<N,T> x, BitVector<N,T> y)
            => BitVector.dot(x,y);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator ~(BitVector<N,T> src)
            => BitVector.not(src);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator ++(BitVector<N,T> src)
            => gmath.eq(src.data,MaxValue) ? gmath.zero<T>() : gmath.inc(src.data);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator --(BitVector<N,T> src)
            => gmath.nonzero(src.data) ? gmath.dec(src.data) : MaxValue;

        /// <summary>
        /// Computes the N-modular arithmetic sum between the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator +(BitVector<N,T> x,BitVector<N,T> y) 
            => gmath.mod(gmath.add(x.data,y.data), MaxValue);
        
        /// <summary>
        /// Computes the N-modular arithmetic difference between the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator -(BitVector<N,T> x,BitVector<N,T> y) 
            => x + -y;

        /// <summary>
        /// Computes the two's complement negation of the operand
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator -(BitVector<N,T> src)
            => BitVector.negate(src);

        /// <summary>
        /// Shifts the source bits leftwards
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator <<(BitVector<N,T> x, int offset)
            => BitVector.sll(x,offset);

        /// <summary>
        /// Shifts the source bits rightwards
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator >>(BitVector<N,T> x, int offset)
            => BitVector.srl(x,offset);

        /// <summary>
        /// Computes the arithmetic less than between the operands
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        [MethodImpl(Inline)]
        public static bit operator <(BitVector<N,T> x, BitVector<N,T> y)
            => gmath.lt(x.data, y.data);

        /// <summary>
        /// Computes the arithmetic greater than between the operands
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        [MethodImpl(Inline)]
        public static bit operator >(BitVector<N,T> x, BitVector<N,T> y)
            => gmath.gt(x.data, y.data);

        /// <summary>
        /// Computes the arithmetic less than or equal between the operands
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        [MethodImpl(Inline)]
        public static bit operator <=(BitVector<N,T> x, BitVector<N,T> y)
            => gmath.lteq(x.data, y.data);

        /// <summary>
        /// Computes the arithmetic greater than or equal between the operands
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        [MethodImpl(Inline)]
        public static bit operator >=(BitVector<N,T> x, BitVector<N,T> y)
            => gmath.gteq(x.data, y.data);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator true(BitVector<N,T> src)
            => src.NonEmpty;

        /// <summary>
        /// Returns false if the source vector is the zero vector, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool operator false(BitVector<N,T> src)
            => src.Empty;

        /// <summary>
        /// Determines whether operand content is identical
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator ==(BitVector<N,T> x, BitVector<N,T> y)
            => gmath.eq(x.data,y.data);

        /// <summary>
        /// Determines whether operand content is non-identical
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator !=(BitVector<N,T> x, BitVector<N,T> y)
            => gmath.neq(x.data,y.data);

        /// <summary>
        /// Intializes a bitvector with the lo N bits of a scalar source
        /// </summary>
        /// <param name="data">The scalar source value</param>
        [MethodImpl(Inline)]
        internal BitVector(T data)
            => this.data = gmath.and(gbits.lomask<N,T>(), data);

        [MethodImpl(Inline)]
        BitVector(T data, bit inject)
            => this.data = data;

        /// <summary>
        /// The scalar representation of the vector
        /// </summary>
        public T Scalar
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// The bitvector width
        /// </summary>
        public int Width
        {
            [MethodImpl(Inline)]
            get => natval<N>();
        }

        /// <summary>
        /// Specifies whether all bits are disabled
        /// </summary>
        public bit Empty
        {
            [MethodImpl(Inline)]
            get => !gmath.nonzero(data);
        }

        /// <summary>
        /// Specifies whether at least one bit is enabled
        /// </summary>
        public readonly bit NonEmpty
        {
            [MethodImpl(Inline)]
            get => gmath.nonzero(data);
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
        public BitVector<N,T> this[int first, int last]
        {
            [MethodImpl(Inline)]
            get => gbits.between(data, first, last);
        }
 
        [MethodImpl(Inline)]
        public readonly bool Equals(BitVector<N,T> y)
            => gmath.eq(data, y.data);

        /// <summary>
        /// Creates a new vector by converting the underlying cell to the target type 
        /// </summary>
        /// <typeparam name="U">The target type</typeparam>
        [MethodImpl(Inline)]
        public BitVector<N,U> As<U>()
            where U : unmanaged
                => convert<T,U>(data);

        public readonly override bool Equals(object obj)
            => obj is BitVector<N,T> x && Equals(x);
        
        public readonly override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => this.Format();
    }
}