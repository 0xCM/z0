// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static As;

    using static zfunc;


    /// <summary>
    /// Defines a bitmatrix with rows of primal type
    /// </summary>
    public ref struct BitMatrix<T>
        where T : unmanaged
    {
        Span<T> data;

        public static readonly BitSize ColumnBitCount = bitsize<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> From(T[] src)        
            => new BitMatrix<T>(src);

        [MethodImpl(Inline)]
        public static BitMatrix<T> From(Span<T> src)        
            => new BitMatrix<T>(src);

        [MethodImpl(Inline)]
        public static BitMatrix<T> From(Span<byte> src)        
            => new BitMatrix<T>(ByteSpan.Cast<T>(src));

        [MethodImpl(Inline)]
        public static BitMatrix<T> Alloc(int rows)        
            => new BitMatrix<T>(new T[rows]);


        /// <summary>
        /// Computes the bitwise AND between the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix<T> operator &(BitMatrix<T> A, BitMatrix<T> B)
            => BitMatrix.and(A, B);

        /// <summary>
        /// Computes the bitwise OR between the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix<T> operator |(BitMatrix<T> A, BitMatrix<T> B)
            => BitMatrix.or(A, B);

        /// <summary>
        /// Computes the bitwise XOR between the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix<T> operator ^(BitMatrix<T> A, BitMatrix<T> B)
            => BitMatrix.xor(A, B);

        /// <summary>
        /// Computes the bitwise complement of the source matrix
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix<T> operator ~(BitMatrix<T> src)
            => BitMatrix.not(src);

        [MethodImpl(Inline)]
        BitMatrix(Span<T> rows)
            => data = rows;

        [MethodImpl(Inline)]
        BitMatrix(T[] rows)
            => data = rows;

        public int RowCount
        {
            [MethodImpl(Inline)]
            get  => data.Length;
        }

        public int ColCount
        {
            [MethodImpl(Inline)]
            get => ColumnBitCount;
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
        /// A reference to the first storage cell allocated to the matrix
        /// </summary>
        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref data[0];
        }

        [MethodImpl(Inline)]
        public BitVector<T> GetRow(int row)
            => data[row];

        [MethodImpl(Inline)]
        public void SetRow(int row, BitVector<T> src)
            => this.data[row] = src.Data[0];

        /// <summary>
        /// Queries/manipulates index-identified row data
        /// </summary>
        public BitVector<T> this[int row]
        {
            [MethodImpl(Inline)]
            get => GetRow(row);

            [MethodImpl(Inline)]
            set => SetRow(row, value);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Bytes.FormatMatrixBits(ColCount);

    }

}