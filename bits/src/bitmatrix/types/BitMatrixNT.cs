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
    /// Defines a square bitmatrix of natural order over a primal type
    /// </summary>
    /// <typeparam name="N">The matrix order</typeparam>
    /// <typeparam name="T">The element type</typeparam>
    public readonly ref struct BitMatrix<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {        
        readonly Span<T> data;

        static readonly BitGridLayout GridLayout = BitGridLayout.Define<N,T>();

        /// <summary>
        /// The bit width of each row/column 
        /// </summary>
        public static int RowWidth 
        {
            [MethodImpl(Inline)]
            get => natval<N>();
        }

        /// <summary>
        /// The bit width of a storage cell
        /// </summary>
        public static int CellWidth
        {
            [MethodImpl(Inline)]
            get => bitsize<T>();
        }

        /// <summary>
        /// The (padded) number of cells required for each row of storage
        /// </summary>
        public static int RowCellCount
        {
            [MethodImpl(Inline)]
            get => CellWidth >= RowWidth ? 1 : PaddingRequired ? WholeRowCells + 1 : WholeRowCells;
        }

        public static int TotalCellCount
        {
            [MethodImpl(Inline)]
            get => RowCellCount * RowWidth;
        }

        /// <summary>
        /// The whole number of cells required to store a row of bits
        /// </summary>
        static int WholeRowCells
        {
            [MethodImpl(Inline)]
            get => RowWidth / CellWidth;
        }

        static bit PaddingRequired 
        {
            [MethodImpl(Inline)]
            get => RowWidth % CellWidth != 0;
        }

        [MethodImpl(Inline)]
        static int RowOffset(int row)
            => row*RowCellCount;

        [MethodImpl(Inline)]
        static int ColOffset(int row, int col)
            => row*RowCellCount + col/RowWidth;

        /// <summary>
        /// Multiplies the left matrix by the right
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> operator *(BitMatrix<N,T> A, BitMatrix<N,T> B)
            => BitMatrix.mul(A, B);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix<N,T> lhs, BitMatrix<N,T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix<N,T> lhs, BitMatrix<N,T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        internal BitMatrix(params T[] src)
        {
            this.data = src;
        }

        [MethodImpl(Inline)]
        internal BitMatrix(Span<T> src)
        {
            this.data = src;
        }

        /// <summary>
        /// Returns a reference to the leading segment of the underlying storage
        /// </summary>
        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref head(data);
        }

        [MethodImpl(Inline)]
        Span<T> RowCells(int row)
            => Data.Slice(RowOffset(row), RowCellCount);

        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get
            {
                return this[row][col];
            }
            

            [MethodImpl(Inline)]
            set
            {
                var cell = GridLayout.Row(row)[col];                                
                Data[cell.Segment] = gbits.set(Data[cell.Segment], (byte)cell.Offset, value);

            }
        }            

        /// <summary>
        /// Queries/Specifies a row
        /// </summary>
        public BitSpan<N,T> this[int row]
        {
            [MethodImpl(Inline)]
            get => new BitSpan<N,T>(RowCells(row), true);
            
            [MethodImpl(Inline)]
            set => value.Data.CopyTo(RowCells(row));     
        }

        /// <summary>
        /// The number of rows/cols in the matrix
        /// </summary>
        public readonly int Order
        {
            [MethodImpl(Inline)]
            get => RowWidth;
        }
        
        /// <summary>
        /// Provides direct access to the underlying bitstore
        /// </summary>
        public readonly Span<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Replaces an index-identied column of data with the content of a column vector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public void SetCol(int col, BitSpan<N,T> src)
        {
            for(var row=0; row < Order; row++)
                this[row,col] = src[row];
        }

        /// <summary>
        /// Retrieves an index-identied column of data presented as a bitvector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public BitSpan<N,T> GetCol(int col)
        {
            var cv = default(BitSpan<N,T>);
            for(var row=0; row < Order; row++)
                cv[row] = this[row, col];
            return cv;
        }

        /// <summary>
        /// Sets all the bits to align with the source value
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public void Fill(bit value)
        {            
            if(value)
                Data.Fill(maxval<T>());
            else
                Data.Fill(zero<T>());
        }

        [MethodImpl(Inline)]
        public string Format()
        {
            var sb = text();
            for(var i=0; i< Order; i++)
                 sb.AppendLine(this[i].Format());
            return sb.ToString();
        }
 
        public BitMatrix<N,T> Transpose()
        {
            var dst = BitMatrix.alloc<N,T>();
            for(var row = 0; row < Order; row++)
                dst.SetCol(row, this[row]);            
            return dst;
        }

        public bool Equals(BitMatrix<N,T> rhs)        
        {
            var eq = mathspan.eq<T>(Data, rhs.Data);
            for(var i = 0; i< eq.Length; i++)
                if(!eq[i])
                    return false;
            return true;
        }
        
        public override int GetHashCode()
            => 0;

        public override bool Equals(object rhs)
            => throw new NotSupportedException();        
    }
}