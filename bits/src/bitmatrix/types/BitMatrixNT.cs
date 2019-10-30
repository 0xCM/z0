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
    public ref struct BitMatrix<N,T>
        where N : ITypeNat, new()
        where T : unmanaged
    {        
        Span<T> data;


        public static BitMatrix<N,T> Identity => BitMatrix.identity<N,T>();

        public static BitMatrix<N,T> Ones => BitMatrix.ones<N,T>();

        public static readonly GridLayout<T> GridLayout = BitMatrix.layout<N,T>();

        /// <summary>
        /// Allocates a Zero-filled NxN matrix
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> Alloc()
            => new BitMatrix<N, T>(new T[GridLayout.TotalCellCount]);

        [MethodImpl(Inline)]
        public static BitMatrix<N,T> Load(T[] src)
        {
            require(src.Length == GridLayout.TotalCellCount, 
                $"A span of length {src.Length} was provided which differs from the required segment count of {GridLayout.TotalCellCount}");
            return new BitMatrix<N, T>(src);
        }

        [MethodImpl(Inline)]
        public static BitMatrix<N,T> Load(Span<T> data)
            => new BitMatrix<N, T>(data);

        /// <summary>
        /// Multiplies the left matrix by the right
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> operator *(BitMatrix<N,T> A, BitMatrix<N,T> B)
            => BitMatrix.mul(A, B, ref A);

        /// <summary>
        /// Computes the bitwise XOR between the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> operator ^(BitMatrix<N,T> A, BitMatrix<N,T> B)
            => XOr(ref A, B);

        /// <summary>
        /// Computes the bitwise AND between the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> operator &(BitMatrix<N,T> A, BitMatrix<N,T> B)
            => And(ref A, B);

        /// <summary>
        /// Computes the bitwise Or between the operands
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> operator |(BitMatrix<N,T> A, BitMatrix<N,T> B)
            => Or(ref A, B);

        /// <summary>
        /// Computes the bitwise complement of the source matrix
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> operator ~(BitMatrix<N,T> A)
            => Flip(ref A);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix<N,T> lhs, BitMatrix<N,T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix<N,T> lhs, BitMatrix<N,T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        BitMatrix(T[] src)
        {
            this.data = src;
        }

        [MethodImpl(Inline)]
        BitMatrix(Span<T> src)
        {
            this.data = src;
        }

        [MethodImpl(Inline)]
        readonly Bit GetBit(int row, int col)
        {
            var cell = GridLayout.Row(row)[col];
            return gbits.test(Data[cell.Segment], cell.Offset);                    
        }

        [MethodImpl(Inline)]
        void SetBit(int row, int col, bit value)
        {
            var cell = GridLayout.Row(row)[col];
            gbits.set(ref Data[cell.Segment], cell.Offset, value);
        }

        public Bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => GetBit(row, col);

            [MethodImpl(Inline)]
            set => SetBit(row, col, value);
        }            

        /// <summary>
        /// Specifies the MxN matrix dimension
        /// </summary>
        public int Order => (int)new N().value;

        /// <summary>
        /// The number of rows in the matrix
        /// </summary>
        public readonly int RowCount
        {
            [MethodImpl(Inline)]
            get => GridLayout.RowCount;
        }

        /// <summary>
        /// The (padded) length of a primal span/array required to store a row of grid data.
        /// </summary>
        public readonly int RowSegCount
        {
            [MethodImpl(Inline)]
            get => GridLayout.RowCellCount;
        }
        
        /// <summary>
        /// The number of columns in the matrix
        /// </summary>
        public readonly int ColCount
        {
            [MethodImpl(Inline)]
            get => GridLayout.ColCount;
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
        readonly int RowOffset(int row)        
            => GridLayout.Row(row)[0].Segment;
                
        [MethodImpl(Inline)]
        public Span<T> RowCells(int row)
            => data.Slice(RowOffset(row), GridLayout.RowCellCount);

        /// <summary>
        /// Retrives an identified row of bits
        /// </summary>
        /// <param name="index">The 0-based row index</param>
        [MethodImpl(Inline)]
        public BitVector<N,T> RowVector(int index)                    
            => BitVector<N,T>.FromSpan(RowCells(index));                

        /// <summary>
        /// Replaces an index-identied column of data with the content of a row vector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public readonly void ReplaceRow(int row, BitVector<N,T> src)
            => src.Data.CopyTo(Data.Slice(RowOffset(row), GridLayout.RowCellCount));     

        public readonly BitVector<N,T> Diagonal()
        {
            var dst = BitVector.natural<N,T>();
            for(var i=0; i<RowCount; i++)
                dst[i] = GetBit(i,i);
            return dst;
        }

        /// <summary>
        /// Queries/Specifies a row
        /// </summary>
        public BitVector<N,T> this[int row]
        {
            [MethodImpl(Inline)]
            get => RowVector(row);
            
            [MethodImpl(Inline)]
            set => ReplaceRow(row,value);
        }

        /// <summary>
        /// Replaces an index-identied column of data with the content of a column vector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public void SetCol(int col, BitVector<N,T> src)
        {
            for(var row=0; row < RowCount; row++)
                this[row,col] = src[row];
        }

        /// <summary>
        /// Retrieves an index-identied column of data presented as a bitvector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public BitVector<N,T> GetCol(int col)
        {
            var cv = default(BitVector<N,T>);
            for(var row=0; row < RowCount; row++)
                cv[row] = this[row, col];
            return cv;
        }

        /// <summary>
        /// Extracts the bits that comprise the matrix in row-major order
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> Unpack()
            => data.AsBytes().Unpack().Slice(0, math.square(natval<N>()));

        /// <summary>
        /// Sets all the bits to align with the source value
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public void Fill(Bit value)
        {
            var primal = PrimalInfo.Get<T>();
            if(value)
                Data.Fill(primal.MaxVal);
            else
                Data.Fill(primal.Zero);
        }

        [MethodImpl(Inline)]    
        public BitString ToBitString()
            => Data.ToBitString();
 
        [MethodImpl(Inline)]
        public string Format()
        {
            var sb = sbuild();
            for(var i=0; i< RowCount; i++)
                 sb.AppendLine(RowVector(i).Format());
            return sb.ToString();
        }
 
        public BitMatrix<N,T> Transpose()
        {
            var dst = Alloc();
            for(var row = 0; row < RowCount; row++)
                dst.SetCol(row, RowVector(row));            
            return dst;
        }

        public BitMatrix<N,T> Replicate()
            => new BitMatrix<N, T>(data.ToArray());

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

        static ref BitMatrix<N,T> And(ref BitMatrix<N,T> A, in BitMatrix<N,T> B)        
        {
            mathspan.and(A.Data, B.Data, A.Data);
            return ref A;
        }

        static ref BitMatrix<N,T> Mul(ref BitMatrix<N,T> A, in BitMatrix<N,T> B)
        {
            var x = A;
            var y = B.Transpose();
            ref var dst = ref A;
            var n = (int)new N().value;

            for(var i=0; i< n; i++)
            {
                var r = x.RowVector(i);
                var z = BitVector.natural<N,T>();
                for(var j = 0; j< n; j++)
                    z[j] = r % y.RowVector(j);
                dst[i] = z;
            }
            return ref dst;
        }

        static ref BitMatrix<N,T> XOr(ref BitMatrix<N,T> A, in BitMatrix<N,T> B)        
        {
            mathspan.xor(A.Data, B.Data, A.Data);
            return ref A;
        }

        static ref BitMatrix<N,T> Or(ref BitMatrix<N,T> lhs, in BitMatrix<N,T> rhs)        
        {
            mathspan.or(lhs.Data, rhs.Data, lhs.Data);
            return ref lhs;
        }

        static ref BitMatrix<N,T> Flip(ref BitMatrix<N,T> src)        
        {
            mathspan.not(src.Data);
            return ref src;
        }
        
    }
}