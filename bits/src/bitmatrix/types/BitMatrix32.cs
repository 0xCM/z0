//-----------------------------------------------------------------------------
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
    /// Defines a 32x32 matrix of bits
    /// </summary>
    
    public ref struct BitMatrix32
    {                
        Span<uint> data;        

        /// <summary>
        /// The matrix order
        /// </summary>
        public const uint N = 32;

        /// <summary>
        /// Allocates a 32x32 identity bitmatrix
        /// </summary>
        public static BitMatrix32 Identity => BitMatrix.identity(n32);

        /// <summary>
        /// Allocates a 32x32 zero bitmatrix
        /// </summary>
        public static BitMatrix32 Zero => new BitMatrix32(new uint[N]);
                
        /// <summary>
        /// Allocates a matrix with a fill value
        /// </summary>
        [MethodImpl(Inline)]
        internal static BitMatrix32 Alloc(bit fill)                
            => new BitMatrix32(fill);

        /// <summary>
        /// Allocates a matrix where each row is initialized to a common vector
        /// </summary>
        /// <param name="fill">The fill vector</param>
        [MethodImpl(Inline)]
        internal static BitMatrix32 Alloc(BitVector32 fill)
        {
            var data = new uint[N];
            data.Fill(fill);
            return new BitMatrix32(data);
        }

        [MethodImpl(Inline)]
        public static BitMatrix32 From(uint[] src)        
            => new BitMatrix32(src);

        [MethodImpl(Inline)]
        public static BitMatrix32 From(BitMatrix<N32,uint> src)        
            => new BitMatrix32(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix32 From(Span<uint> src)        
            => new BitMatrix32(src);

        [MethodImpl(Inline)]
        public static BitMatrix32 From(Span<byte> src)        
            => new BitMatrix32(src.AsUInt32());

        [MethodImpl(Inline)]
        public static BitMatrix32 operator & (BitMatrix32 lhs, BitMatrix32 rhs)
            => BitMatrix.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator | (BitMatrix32 lhs, BitMatrix32 rhs)
            => BitMatrix.or(lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator ^ (BitMatrix32 lhs, BitMatrix32 rhs)
            => BitMatrix.xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator ~ (BitMatrix32 src)
            => BitMatrix.not(src);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator - (BitMatrix32 A, BitMatrix32 B)
            => BitMatrix.xornot(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator * (BitMatrix32 A, BitMatrix32 B)
            => BitMatrix.mul(A, B);

        [MethodImpl(Inline)]
        public static BitVector32 operator * (BitMatrix32 A, BitVector32 B)
            => BitMatrix.mul(A, B);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix32 lhs, BitMatrix32 rhs)
            => BitMatrix.same(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix32 lhs, BitMatrix32 rhs)
            => !BitMatrix.same(lhs,rhs);

        [MethodImpl(Inline)]
        BitMatrix32(Span<uint> src)
        {                        
            this.data = src;
        }        

        [MethodImpl(Inline)]
        BitMatrix32(bit fill)
        {
            this.data = new uint[N];
            if(fill)
                data.Fill(uint.MaxValue);
        }

        public readonly int Order
        {
            [MethodImpl(Inline)]
            get => (int)N;
        }

        /// <summary>
        /// Reads the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public readonly bit GetBit(int row, int col)
            => BitMask.test(data[row], col);

        /// <summary>
        /// Sets the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public void SetBit(int row, int col, bit src)
            => BitMask.set(ref data[row], (byte)col, src);

        /// <summary>
        /// Queries/manipulates a bit in an identified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => GetBit(row,col);

            [MethodImpl(Inline)]
            set => SetBit(row,col,value);
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
        /// The underlying matrix data
        /// </summary>
        public Span<uint> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// A reference to the first row of the matrix
        /// </summary>
        public unsafe ref uint Head
        {
            [MethodImpl(Inline)] 
            get => ref head(data);
        }

        /// <summary>
        /// Queries/manipulates row data
        /// </summary>
        /// <param name="row">The row index</param>
        public ref BitVector32 this[int row]
        {
            [MethodImpl(Inline)]
            get => ref RowVector(row);
        }

        [MethodImpl(Inline)] 
        public readonly BitVector32 Diagonal()
            => BitMatrix.diagonal(this);

        [MethodImpl(NotInline)] 
        public readonly BitMatrix32 Replicate()
            => new BitMatrix32(data.ToArray());

        /// <summary>
        /// Presents the data at a specified offset as a bitvector
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref BitVector32 RowVector(int row)
            => ref Unsafe.As<uint,BitVector32>(ref seek(ref Head, row));

        /// <summary>
        /// Presents the data at a specified offset as an unsigned integer
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref uint RowData(int row)
            => ref seek(ref Head, row);

        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 32
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public void RowSwap(int i, int j)
            => data.Swap(i,j);

        public readonly uint ColData(int index)
        {
            uint col = 0;
            for(var r = 0; r < N; r++)
                BitMask.setif(in data[r], index, ref col, r);
            return col;
        }
        
        [MethodImpl(Inline)]
        public readonly BitVector32 ColVec(int index)
            => ColData(index);

        
        public readonly BitMatrix32 Transpose()
        {
            var dst = Replicate();
            for(var i=0; i<N; i++)
                dst.data[i] = ColData(i);
            return dst;
        }
    
        [MethodImpl(Inline)]
        public string Format()
            => data.FormatMatrixBits(32);

        [MethodImpl(Inline)]
        public bool Equals(BitMatrix32 rhs)
            => BitMatrix.same(this,rhs);

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
        
        public override string ToString()
            => throw new NotSupportedException();
    }
}