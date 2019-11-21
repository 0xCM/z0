// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    /// <summary>
    /// Defines a sequence of generic bitvectors, interpreted as rows, for which the width is determined by the bitvector primal type 
    /// </summary>
    public readonly ref struct RowBits<T>
        where T : unmanaged
    {
        readonly internal Span<T> data;

        public static int Width => bitsize<T>();

        [MethodImpl(Inline)]
        public static RowBits<T> From(T[] src)        
            => new RowBits<T>(src);

        [MethodImpl(Inline)]
        public static RowBits<T> From(Span<T> src)        
            => new RowBits<T>(src);

        [MethodImpl(Inline)]
        public static RowBits<T> From(Span<byte> src)        
            => new RowBits<T>(cast<T>(src));

        [MethodImpl(NotInline)]
        public static RowBits<T> Alloc(int rows)        
            => new RowBits<T>(new T[rows]);

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
        public bool IsSquare
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
        public RowBits<T> Fill(T value)
        {
            data.Fill(value);
            return this;
        }

        [MethodImpl(Inline)]
        public RowBits<S> As<S>()
            where S : unmanaged
                => new RowBits<S>(data.As<T,S>());
    }

}