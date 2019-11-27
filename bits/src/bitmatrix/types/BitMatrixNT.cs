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

        static readonly BitGridLayout<T> GridLayout = BitMatrix.layout<N,T>();

        public static int RowWidth = natval<N>();

        /// <summary>
        /// Computes the length of a primal span/array that is required to store a row of data
        /// </summary>
        public static int RowCellCount
        {
            [MethodImpl(Inline)]
            get => bitsize<T>() >= natval<N>() ? 1 : (natval<N>() % bitsize<T>()) == 0 ? (natval<N>() / bitsize<T>()) : (natval<N>() / bitsize<T>()) + 1;
        }

        public static int TotalCellCount => RowCellCount * RowWidth;
    
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

        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => GetBit(row, col);

            [MethodImpl(Inline)]
            set => SetBit(row, col, value);
        }            

        /// <summary>
        /// Queries/Specifies a row
        /// </summary>
        public BitCells<N,T> this[int row]
        {
            [MethodImpl(Inline)]
            get => RowVector(row);
            
            [MethodImpl(Inline)]
            set => ReplaceRow(row,value);
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

        [MethodImpl(Inline)]
        readonly bit GetBit(int row, int col)
        {
            var cell = GridLayout.Row(row)[col];
            return gbits.test(Data[cell.Segment], cell.Offset);                    
        }

        [MethodImpl(Inline)]
        void SetBit(int row, int col, bit value)
        {
            var cell = GridLayout.Row(row)[col];
            gbits.set(ref Data[cell.Segment], (byte)cell.Offset, value);
        }
                
        /// <summary>
        /// Retrives an identified row of bits
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        [MethodImpl(Inline)]
        public BitCells<N,T> RowVector(int row)                    
            => new BitCells<N,T>(Data.Slice(row*RowCellCount, RowCellCount));

        /// <summary>
        /// Replaces an index-identied column of data with the content of a row vector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public void ReplaceRow(int row, BitCells<N,T> src)
            => src.Data.CopyTo(Data.Slice(row*RowCellCount, RowCellCount));     

        /// <summary>
        /// Replaces an index-identied column of data with the content of a column vector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public void SetCol(int col, BitCells<N,T> src)
        {
            for(var row=0; row < Order; row++)
                this[row,col] = src[row];
        }

        /// <summary>
        /// Retrieves an index-identied column of data presented as a bitvector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public BitCells<N,T> GetCol(int col)
        {
            var cv = default(BitCells<N,T>);
            for(var row=0; row < Order; row++)
                cv[row] = this[row, col];
            return cv;
        }

        /// <summary>
        /// Sets all the bits to align with the source value
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public void Fill(Bit value)
        {            
            if(value)
                Data.Fill(maxval<T>());
            else
                Data.Fill(zero<T>());
        }

        [MethodImpl(Inline)]
        public string Format()
        {
            var sb = sbuild();
            for(var i=0; i< Order; i++)
                 sb.AppendLine(RowVector(i).Format());
            return sb.ToString();
        }
 
        public BitMatrix<N,T> Transpose()
        {
            var dst = BitMatrix.alloc<N,T>();
            for(var row = 0; row < Order; row++)
                dst.SetCol(row, RowVector(row));            
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