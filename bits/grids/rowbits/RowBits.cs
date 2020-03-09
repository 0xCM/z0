// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a sequence of generic bitvectors, interpreted as rows, for which the width is determined by the bitvector primal type 
    /// </summary>
    /// <remarks>The primary use case for this data structure is to faciltate efficient bitwise 
    /// operations over generic scalar sequences where the length of the sequence varies</remarks>
    [IdentityProvider(typeof(RowBItsIdentity))]
    public readonly ref struct RowBits<T>
        where T : unmanaged
    {
        readonly internal Span<T> data;

        public static int Width => bitsize<T>();

        /// <summary>
        /// Computes the bitwise AND between the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static RowBits<T> operator &(in RowBits<T> A, in RowBits<T> B)
            => RowBits.and(A, B);

        /// <summary>
        /// Computes the bitwise OR between the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static RowBits<T> operator |(in RowBits<T> A, in RowBits<T> B)
            => RowBits.or(A, B);

        /// <summary>
        /// Computes the bitwise XOR between the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static RowBits<T> operator ^(in RowBits<T> A, in RowBits<T> B)
            => RowBits.xor(A, B);

        /// <summary>
        /// Computes the bitwise complement of the source matrix
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]
        public static RowBits<T> operator ~(in RowBits<T> src)
            => RowBits.not(src);

        [MethodImpl(Inline)]
        internal RowBits(Span<T> rows)
            => data = rows;

        [MethodImpl(Inline)]
        internal RowBits(T[] rows)
            => data = rows;

        /// <summary>
        /// A reference to the first storage cell allocated to the matrix
        /// </summary>
        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref head(data);
        }

        public int RowCount
        {
            [MethodImpl(Inline)]
            get  => data.Length;
        }

        public int RowWidth
        {
            [MethodImpl(Inline)]
            get => Width;
        }

        /// <summary>
        /// The underlying matrix presented as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => data.AsBytes();
        }

        /// <summary>
        /// Specifies whether the matrix is square; if so, it can be represented by one of the primal matrices
        /// </summary>
        public bit IsSquare
        {
            [MethodImpl(Inline)]
            get => Width == RowCount;
        }

        /// <summary>
        /// Queries/manipulates index-identified row data
        /// </summary>
        public ref BitVector<T> this[int row]
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.As<T,BitVector<T>>(ref head(data, row));
        }

        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => BitGrid.readbit(Width, in Head, row, col); 

            [MethodImpl(Inline)]
            set => BitGrid.setbit(Width, row, col, value, ref Head);
        }

        [MethodImpl(Inline)]
        public RowBits<S> As<S>()
            where S : unmanaged
                => new RowBits<S>(data.As<T,S>());
    }
}