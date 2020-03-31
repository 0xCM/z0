//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;
    using static Literals;

    /// <summary>
    /// Defines bitmatrix of natural dimensions over a primal type
    /// </summary>
    /// <typeparam name="M">The row dimension</typeparam>
    /// <typeparam name="N">The column dimension</typeparam>
    /// <typeparam name="T">The element type</typeparam>
    public readonly ref struct BitMatrix<M,N,T> 
        where M : unmanaged, ITypeNat        
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {        
        readonly Span<T> data;
        
        public static M RowDim => default;

        public static N ColDim => default;

        /// <summary>
        /// Allocates a Zero-filled mxn matrix
        /// </summary>
        [MethodImpl(NotInline)]
        public static BitMatrix<M,N,T> Alloc()
            => new BitMatrix<M, N, T>(new T[BitMatrix.totalcells<M,N,T>()]);

        /// <summary>
        /// Loads a matrix from an array of appopriate length
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Load(Span<T> src)
        {
            require(src.Length == BitMatrix.totalcells<M,N,T>());
            return new BitMatrix<M, N, T>(src);
        }

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
        /// Presents matrix storage as a span of generic cells
        /// </summary>
        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Returns a reference to the leading segment of the underlying storage
        /// </summary>
        public ref T Head
        {
            [MethodImpl(Inline)]
            get => ref head(data);
        }

        /// <summary>
        /// Presents matrix storage as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => data.AsBytes();
        }

        /// <summary>
        /// The number of rows in the matrix
        /// </summary>
        public readonly int RowCount
        {
            [MethodImpl(Inline)]
            get => nati<M>();
        }

        /// <summary>
        /// The number of columns in the matrix
        /// </summary>
        public readonly int ColCount
        {
            [MethodImpl(Inline)]
            get => nati<N>();
        }

        /// <summary>
        /// The number of allocated storage cells
        /// </summary>
        public readonly int CellCount
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        /// <summary>
        /// Queries/manipulates a bit at a specified row/col
        /// </summary>
        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get 
            {
                var index = BitMatrix.tableindex(row, col, RowDim, ColDim, default(T));
                return gbits.testbit(data[index.CellIndex], index.BitOffset);
            }

            [MethodImpl(Inline)]
            set 
            {
                var index = BitMatrix.tableindex(row, col, RowDim, ColDim, default(T));
                data[index.CellIndex] = gbits.set(data[index.CellIndex], index.BitOffset, value);                
           }
        }            

        int RowCellCount
        {
            [MethodImpl(Inline)]
            get => BitCalcs.mincells<N,T>();
        }

        /// <summary>
        /// Queries mainpulates a row
        /// </summary>
        public BitBlock<N,T> this[int row]
        {
            [MethodImpl(Inline)]
            get => ReadRow(row);
            
            [MethodImpl(Inline)]
            set  => value.Data.Slice(0, RowCellCount).CopyTo(data,row);
        }
                
        [MethodImpl(Inline)]
        public BitBlock<N,T> ReadRow(int row)  
            => new BitBlock<N,T>(data.Slice(row*RowCellCount, RowCellCount));

        [MethodImpl(Inline)]
        public readonly BitBlock<N,T> CopyRow(int row)                    
            => new BitBlock<N,T>(data.Slice(row*RowCellCount, RowCellCount).Replicate());

        /// <summary>
        /// Replaces an index-identied column of data with the content of a column vector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public void SetCol(int col, BitBlock<M,T> src)
        {
            for(var row=0; row < RowCount; row++)
                this[row,col] = src[row];
        }

        /// <summary>
        /// Retrieves an index-identied column of data presented as a bitvector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public BitBlock<M,T> GetCol(int col)
        {
            var cidx = ColCount - col - 1;
            var cv = BitBlocks.alloc<M,T>();
            for(var row = 0; row < RowCount; row++)            
                cv[row] = this[row, cidx];                        
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
                Data.Fill(minval<T>());
        }

        /// <summary>
        /// The world's most inefficient bitmatrix transpose
        /// </summary>
        public readonly BitMatrix<N,M,T> Transpose()
        {
            var dst = BitMatrix.alloc<N,M,T>();
            for(var row = 0; row < RowCount; row++)
                dst.SetCol(row, CopyRow(row));            
            return dst;
        }

        [MethodImpl(Inline)]
        public string Format()
        {
            var sb = text.factory.Builder();
            for(var i=0; i< RowCount; i++)
                 sb.AppendLine(ReadRow(i).Format(blockWidth:1));
            return sb.ToString();
        }

        public bool Equals(BitMatrix<M,N,T> rhs)        
        {
            for(var row = 0; row < RowCount; row++)
                if(!this[row].Equals(rhs[row]))
                    return false;
                    
            return true;            
        }

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}