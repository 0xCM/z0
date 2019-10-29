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
    /// Defines a sequence of generic bitvectors, interpreted as rows, for which the width is determined by 
    /// the bitvector primal type
    /// </summary>
    public ref struct RowBits<T>
        where T : unmanaged
    {
        internal Span<T> data;

        public static int Width 
        {
            [MethodImpl(Inline)]
            get => bitsize<T>();
        }
        
        [MethodImpl(Inline)]
        public static RowBits<T> From(T[] src)        
            => new RowBits<T>(src);

        [MethodImpl(Inline)]
        public static RowBits<T> From(Span<T> src)        
            => new RowBits<T>(src);

        [MethodImpl(Inline)]
        public static RowBits<T> From(Span<byte> src)        
            => new RowBits<T>(ByteSpan.Cast<T>(src));

        [MethodImpl(NotInline)]
        public static RowBits<T> Alloc(int rows)        
            => new RowBits<T>(new T[rows]);

        /// <summary>
        /// Computes the bitwise AND between the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static RowBits<T> operator &(RowBits<T> A, RowBits<T> B)
            => RowBits.and(A, B);

        /// <summary>
        /// Computes the bitwise OR between the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static RowBits<T> operator |(RowBits<T> A, RowBits<T> B)
            => RowBits.or(A, B);

        /// <summary>
        /// Computes the bitwise XOR between the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static RowBits<T> operator ^(RowBits<T> A, RowBits<T> B)
            => RowBits.xor(A, B);

        /// <summary>
        /// Computes the bitwise complement of the source matrix
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]
        public static RowBits<T> operator ~(RowBits<T> src)
            => RowBits.not(src);

        [MethodImpl(Inline)]
        RowBits(Span<T> rows)
            => data = rows;

        [MethodImpl(Inline)]
        RowBits(T[] rows)
            => data = rows;

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
        /// A reference to the first storage cell allocated to the matrix
        /// </summary>
        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref head(data);
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
        ///  Specifies the size of the matrix in bytes
        /// </summary>
        public ByteSize Allocation
        {
            [MethodImpl(Inline)]
            get => size<T>()*RowCount;
        }

        /// <summary>
        /// Gets the the value of bit identified by row/col indices
        /// </summary>
        /// <param name="row">The zero-based row index</param>
        /// <param name="col">The zero-based col index</param>
        [MethodImpl(Inline)]
        public Bit GetBit(int row, int col)            
            => gbits.test(data[row], col);                    

        /// <summary>
        /// Sets the the value of bit identified by row/col indices
        /// </summary>
        /// <param name="row">The zero-based row index</param>
        /// <param name="col">The zero-based col index</param>
        [MethodImpl(Inline)]
        public void SetBit(int row, int col, bit value)           
            => gbits.set(ref data[row], (byte)col, value);

        /// <summary>
        /// Queries/manipulates index-identified row data
        /// </summary>
        public ref BitVector<T> this[int row]
        {
            [MethodImpl(Inline)]
            get => ref Row(row);
        }

        [MethodImpl(Inline)]
        ref BitVector<T> Row(int offset)
            => ref AsBitVector(ref tail(data, offset));

        [MethodImpl(Inline)]
        static ref BitVector<T> AsBitVector(ref T src)
            => ref Unsafe.As<T,BitVector<T>>(ref src);

        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => GetBit(row,col);

            [MethodImpl(Inline)]
            set => SetBit(row,col,value);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Bytes.FormatMatrixBits(RowWidth);
    
        [MethodImpl(Inline)]
        public RowBits<T> Fill(T value)
        {
            data.Fill(value);
            return this;
        }

        [MethodImpl(Inline)]
        public RowBits<T> Replicate(bool structureOnly = false)
            => new RowBits<T>(data.Replicate(structureOnly));
        
        [MethodImpl(Inline)]
        public RowBits<S> As<S>()
            where S : unmanaged
                => new RowBits<S>(data.As<T,S>());

    }

}