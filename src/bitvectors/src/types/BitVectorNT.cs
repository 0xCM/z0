//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Numeric;

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
    public struct BitVector<N,T> : IBitVector<BitVector<N,T>,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        T Data;

        /// <summary>
        /// Initializes a bitvector with the lo N bits of a scalar source
        /// </summary>
        /// <param name="data">The scalar source value</param>
        [MethodImpl(Inline)]
        internal BitVector(T data)
            => Data = gmath.and(BitMasks.lo<N,T>(), data);

        [MethodImpl(Inline)]
        internal BitVector(T data, bit inject)
            => this.Data = data;

        /// <summary>
        /// The physical width of the vector
        /// </summary>
        public static int MaxWidth
            => BitWidth.measure<T>();

        /// <summary>
        /// The maximum arithmetic value of the vector, constrained by the natural width
        /// </summary>
        public static T MaxValue
        {
            [MethodImpl(Inline)]
            get => force<ulong,T>(NatCalc.pow2m1<N>());
        }

        public static T Zero => default;

        /// <summary>
        /// Directly assigns a value to a vector storage cell, bypassing masked initialization
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        internal static BitVector<N,T> Inject(T src)
            => new BitVector<N,T>(src, true);

        /// <summary>
        /// The scalar representation of the vector
        /// </summary>
        public T State
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        /// <summary>
        /// The bitvector width
        /// </summary>
        public int Width
        {
            [MethodImpl(Inline)]
            get => (int)TypeNats.value<N>();
        }

        /// <summary>
        /// Specifies whether all bits are disabled
        /// </summary>
        public bit Empty
        {
            [MethodImpl(Inline)]
            get => !gmath.nonz(Data);
        }

        /// <summary>
        /// Specifies whether at least one bit is enabled
        /// </summary>
        public readonly bit NonEmpty
        {
            [MethodImpl(Inline)]
            get => gmath.nonz(Data);
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(Data);
        }

        /// <summary>
        /// Reads/Manipulates a single bit
        /// </summary>
        public bit this[int index]
        {
            [MethodImpl(Inline)]
            get => gbits.testbit(Data, (byte)index);

            [MethodImpl(Inline)]
            set => Data = gbits.setbit(Data, (byte)index, value);
        }

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        public BitVector<N,T> this[byte first, byte last]
        {
            [MethodImpl(Inline)]
            get => gbits.segment(Data, first, last);
        }

        [MethodImpl(Inline)]
        public readonly bool Equals(BitVector<N,T> y)
            => gmath.eq(Data, y.Data);

        /// <summary>
        /// Creates a new vector by converting the underlying cell to the target type
        /// </summary>
        /// <typeparam name="U">The target type</typeparam>
        [MethodImpl(Inline)]
        public BitVector<N,U> As<U>()
            where U : unmanaged
                => force<T,U>(Data);

        public readonly override bool Equals(object obj)
            => obj is BitVector<N,T> x && Equals(x);

        public readonly override int GetHashCode()
            => Data.GetHashCode();

        public string Format(BitFormat config)
            => BitVector.format(this,config);

        public string Format()
            => BitVector.format(this);

        public override string ToString()
            => Format();

        /// <summary>
        /// Implicitly convers a scalar to a bitvector
        /// </summary>
        /// <param name="src">The scalar value</param>
        [MethodImpl(Inline)]
        public static implicit operator BitVector<N,T>(T src)
            => new BitVector<N,T>(src);

        /// <summary>
        /// Implicitly convers a bitvector to its scalar representation
        /// </summary>
        /// <param name="src">The scalar value</param>
        [MethodImpl(Inline)]
        public static implicit operator T(BitVector<N,T> src)
            => src.Data;

        /// <summary>
        /// Implicitly convers a bitvector to its scalar representation
        /// </summary>
        /// <param name="src">The scalar value</param>
        [MethodImpl(Inline)]
        public static implicit operator BitVector<T>(BitVector<N,T> src)
            => new BitVector<T>(src.Data);

        /// <summary>
        /// Computes the bitwise AND between the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator &(BitVector<N,T> x, BitVector<N,T> y)
            => BitVector.and(x,y);

        /// <summary>
        /// Computes the bitwise AND between the operands
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
            =>  gmath.eq(src.Data,MaxValue) ? core.zero<T>() : gmath.inc(src.Data);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator --(BitVector<N,T> src)
            => gmath.nonz(src.Data) ? gmath.dec(src.Data) : MaxValue;

        /// <summary>
        /// Computes the N-modular arithmetic sum between the operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator +(BitVector<N,T> x,BitVector<N,T> y)
            => gmath.mod(gmath.add(x.Data,y.Data), MaxValue);

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
            => BitVector.sll(x,(byte)offset);

        /// <summary>
        /// Shifts the source bits rightwards
        /// </summary>
        /// <param name="x">The source operand</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> operator >>(BitVector<N,T> x, int offset)
            => BitVector.srl(x,(byte)offset);

        /// <summary>
        /// Computes the arithmetic less than between the operands
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        [MethodImpl(Inline)]
        public static bit operator <(BitVector<N,T> x, BitVector<N,T> y)
            => gmath.lt(x.Data, y.Data);

        /// <summary>
        /// Computes the arithmetic greater than between the operands
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        [MethodImpl(Inline)]
        public static bit operator >(BitVector<N,T> x, BitVector<N,T> y)
            => gmath.gt(x.Data, y.Data);

        /// <summary>
        /// Computes the arithmetic less than or equal between the operands
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        [MethodImpl(Inline)]
        public static bit operator <=(BitVector<N,T> x, BitVector<N,T> y)
            => gmath.lteq(x.Data, y.Data);

        /// <summary>
        /// Computes the arithmetic greater than or equal between the operands
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        [MethodImpl(Inline)]
        public static bit operator >=(BitVector<N,T> x, BitVector<N,T> y)
            => gmath.gteq(x.Data, y.Data);

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
            => gmath.eq(x.Data,y.Data);

        /// <summary>
        /// Determines whether operand content is non-identical
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bit operator !=(BitVector<N,T> x, BitVector<N,T> y)
            => gmath.neq(x.Data,y.Data);
    }
}