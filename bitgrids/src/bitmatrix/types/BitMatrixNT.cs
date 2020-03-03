//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;

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

        static N NatRep => default;

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
            get =>  BitCalcs.mincells(bitsize<T>(),natval<N>()); 
        }

        public static int TotalCellCount
        {
            [MethodImpl(Inline)]
            get => RowCellCount * RowWidth;
        }

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
            get => this[row][col];
            

            [MethodImpl(Inline)]
            set
            {
                var index = BitMatrix.tableindex(row, col, NatRep, NatRep, default(T));
                data[index.CellIndex] = gbits.set(data[index.CellIndex], index.BitOffset, value);                
            }
        }            

        /// <summary>
        /// Queries/Specifies a row
        /// </summary>
        public BitBlock<N,T> this[int row]
        {
            [MethodImpl(Inline)]
            get => new BitBlock<N,T>(GetRowData(row), true);
            
            [MethodImpl(Inline)]
            set => value.Data.CopyTo(GetRowData(row));     
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
        public void SetCol(int col, BitBlock<N,T> src)
        {
            for(var row=0; row < Order; row++)
                this[row,col] = src[row];
        }

        /// <summary>
        /// Retrieves an index-identied column of data presented as a bitvector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public BitBlock<N,T> GetCol(int col)
        {
            var cv = default(BitBlock<N,T>);
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
            var sb = text.factory.Builder();
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
            for(var row = 0; row < Order; row++)
                if(!this[row].Equals(rhs[row]))
                    return false;
                    
            return true;            
        }

        [MethodImpl(Inline)]
        Span<T> GetRowData(int row)
            => Data.Slice(row*RowCellCount, RowCellCount);

        public override int GetHashCode()
            => 0;

        public override bool Equals(object rhs)
            => throw new NotSupportedException();        
    }
}