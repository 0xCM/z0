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

        /// <summary>
        /// The number of bits per row
        /// </summary>
        public static int RowBitCount  => natval<M>();

        /// <summary>
        /// The number of bits per column
        /// </summary>
        public static int ColBitCount => natval<N>();

        /// <summary>
        /// The number of bits apprehended by the matrix
        /// </summary>
        public static int TotalBitCount => NatMath.mul<M,N>();
        
        static readonly BitGridSpec GridSpec = new BitGridSpec(Unsafe.SizeOf<T>()*8, RowBitCount, ColBitCount);
        
        public static readonly BitGridLayout Layout = GridSpec.CalcLayout<T>();

        /// <summary>
        /// Allocates a Zero-filled mxn matrix
        /// </summary>
        [MethodImpl(NotInline)]
        public static BitMatrix<M,N,T> Alloc()
            => new BitMatrix<M, N, T>(new T[Layout.TotalCellCount]);

        /// <summary>
        /// Loads a matrix from an array of appopriate length
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Load(Span<T> src)
        {
            require(src.Length == Layout.TotalCellCount);
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
            get => RowBitCount;
        }

        /// <summary>
        /// The number of columns in the matrix
        /// </summary>
        public readonly int ColCount
        {
            [MethodImpl(Inline)]
            get => ColBitCount;
        }

        /// <summary>
        /// Queries/manipulates a bit at a specified row/col
        /// </summary>
        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get 
            {
                var cell = Layout.Row(row)[col];
                return BitMask.testbit(Data[cell.Segment], cell.Offset);                    
            }

            [MethodImpl(Inline)]
            set 
            {
                var cell = Layout.Row(row)[col];
                data[cell.Segment] = gbits.set(data[cell.Segment], (byte)cell.Offset, value);
            }
        }            

        /// <summary>
        /// Queries mainpulates a row
        /// </summary>
        public BitCells<N,T> this[int row]
        {
            [MethodImpl(Inline)]
            get => GetRow(row);
            
            [MethodImpl(Inline)]
            set => value.Data.CopyTo(Data.Slice(RowOffset(row), Layout.RowCellCount));     
        }

        [MethodImpl(Inline)]
        readonly int RowOffset(int row)        
            => Layout.Row(row)[0].Segment;
                
        /// <summary>
        /// Retrives an identified row of bits
        /// </summary>
        /// <param name="index">The 0-based row index</param>
        [MethodImpl(Inline)]
        public BitCells<N,T> GetRow(int index)                    
            => new BitCells<N,T>(data.Slice(RowOffset(index), Layout.RowCellCount));                

        [MethodImpl(Inline)]
        public readonly BitCells<N,T> CopyRow(int index)                    
            => new BitCells<N,T>(data.Slice(RowOffset(index), Layout.RowCellCount).Replicate());

        /// <summary>
        /// Replaces an index-identied column of data with the content of a column vector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public void SetCol(int col, BitCells<M,T> src)
        {
            for(var row=0; row < RowCount; row++)
                this[row,col] = src[row];
        }

        /// <summary>
        /// Retrieves an index-identied column of data presented as a bitvector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public BitCells<M,T> GetCol(int col)
        {
            var cidx = ColCount - col - 1;
            var cv = BitCells.alloc<M,T>();
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
            var sb = text();
            for(var i=0; i< RowCount; i++)
                 sb.AppendLine(GetRow(i).Format(blockWidth:1));
            return sb.ToString();
        }

        public bool Equals(BitMatrix<M,N,T> rhs)        
        {
            var eq = mathspan.eq<T>(Data, rhs.Data);
            for(var i = 0; i< eq.Length; i++)
                if(!eq[i])
                    return false;
            return true;
        }

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}