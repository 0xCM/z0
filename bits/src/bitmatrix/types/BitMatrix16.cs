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
    /// Defines a 16x16 matrix of bits
    /// </summary>
    public struct BitMatrix16  : IBitSquare<BitMatrix16,ushort>
    {   
        ushort[] data;

        /// <summary>
        /// The matrix order
        /// </summary>
        public const uint N = 16;

        /// <summary>
        /// The number of bits per row
        /// </summary>
        public const uint RowBitCount = N;

        /// <summary>
        /// The number of bits per column
        /// </summary>
        public const uint ColBitCount = N;

        /// <summary>
        /// The number of bits apprehended by the matrix
        /// </summary>
        public const uint TotalBitCount = RowBitCount * ColBitCount;
                        
        /// <summary>
        /// The number of bytes needed for a row
        /// </summary>
        public const uint RowByteCount = RowBitCount >> 3;

        /// <summary>
        /// The number of bytes needed for a column
        /// </summary>
        public const uint ColByteCount = ColBitCount >> 3;

        /// <summary>
        /// To total number of bytes required to store the matrix data
        /// </summary>
        public const uint TotalByteCount = TotalBitCount >> 3;
                                
        /// <summary>
        /// Defines the 16x16 identity bitmatrix
        /// </summary>
        public static BitMatrix16 Identity 
            => From(Identity16x16.ToSpan());

        /// <summary>
        /// Defines the 16x16 zero bitmatrix
        /// </summary>
        public static BitMatrix16 Zero 
            => Alloc();

        [MethodImpl(Inline)]
        public static BitMatrix16 Alloc()        
            => From(new ushort[N]);

        /// <summary>
        /// Allocates a matrix with a fill value
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix16 Alloc(bit fill)                
            => new BitMatrix16(fill);

        [MethodImpl(Inline)]
        public static BitMatrix16 From(params ushort[] src)        
            => src.Length == 0 ? Alloc() : new BitMatrix16(src);

        [MethodImpl(Inline)]
        public static BitMatrix16 From(Span<ushort> src)        
            => new BitMatrix16(src);

        [MethodImpl(Inline)]
        public static BitMatrix16 From(BitMatrix<N16,ushort> src)        
            => From(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix16 From(Span<byte> src)        
            => new BitMatrix16(src.AsUInt16());

        /// <summary>
        /// Loads a bitmatrix from the bits in cpu vector
        /// </summary>
        /// <param name="src">The matrix bits</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 From(in Vec256<ushort> src)
        {
            Span<ushort> dst = new ushort[Vec256<short>.Length];
            vstore(src, ref dst[0]);
            return new BitMatrix16(dst);
        }

        /// <summary>
        /// Loads a bitmatrix from the bits in cpu vector
        /// </summary>
        /// <param name="src">The matrix bits</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 From(Vector256<ushort> src)
        {
            Span<ushort> dst = new ushort[Vec256<short>.Length];
            vstore(src, ref dst[0]);
            return new BitMatrix16(dst);
        }

        /// <summary>
        /// Computes the bitwise and of the operands
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix16 operator & (BitMatrix16 A, BitMatrix16 B)
            => BitMatrix.and(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator | (BitMatrix16 A, BitMatrix16 B)
            => BitMatrix.or(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator ^ (BitMatrix16 A, BitMatrix16 B)
            => BitMatrix.xor(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator ~ (BitMatrix16 A)
            => BitMatrix.not(A);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator - (BitMatrix16 A, BitMatrix16 B)
            => BitMatrix.xornot(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator * (BitMatrix16 A, BitMatrix16 B)
            => BitMatrix.mul(A, B);

        [MethodImpl(Inline)]
        public static BitVector16 operator * (BitMatrix16 A, BitVector16 B)
            => BitMatrix.mul(A, B);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix16 A, BitMatrix16 B)
            => A.Equals(B);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix16 A, BitMatrix16 B)
            => !A.Equals(B);

        [MethodImpl(Inline)]
        BitMatrix16(ushort[] src)
        {                        
            require(src.Length == Pow2.T04);
            this.data = src;
        }

        [MethodImpl(Inline)]
        BitMatrix16(Span<ushort> src)
        {                        
            require(src.Length == Pow2.T04);
            this.data = src.ToArray();
        }

        BitMatrix16(bit fill)
        {
            this.data = new ushort[N];
            if(fill)
                Array.Fill(data, ushort.MaxValue);
        }

        /// <summary>
        /// The underlying matrix presented as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => data.AsSpan().AsBytes();
        }

        /// <summary>
        /// The underlying matrix data
        /// </summary>
        public Span<ushort> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// The data enclosed by the matrix
        /// </summary>
        public ushort[] Rows
        {
            [MethodImpl(Inline)] 
            get => data;
        }

        /// <summary>
        /// A reference to the first row of the matrix
        /// </summary>
        public ref ushort Head
        {
            [MethodImpl(Inline)] 
            get => ref data[0];
        }

        /// <summary>
        /// Reads the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public readonly Bit GetBit(int row, int col)
            => BitMask.test(data[row], col);

        /// <summary>
        /// Sets the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public void SetBit(int row, int col, Bit src)
            => BitMask.set(ref data[row], (byte)col, src);

        /// <summary>
        /// Reads/manipulates the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        /// <param name="src">The source value</param>
        public Bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => GetBit(row,col);

            [MethodImpl(Inline)]
            set => SetBit(row,col,value);
        }            

        public readonly int RowCount
        {
            [MethodImpl(Inline)]
            get => (int)N;
        }

        public readonly int ColCount
        {
            [MethodImpl(Inline)]
            get => (int)N;
        }

        public readonly ushort ColData(int index)
        {
            ushort col = 0;
            for(var r = 0; r < N; r++)
                BitMask.setif(in data[r], index, ref col, r);
            return col;
        }
        
        [MethodImpl(Inline)]
        public readonly BitVector16 ColVector(int index)
            => ColData(index);

        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 16
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public void RowSwap(int i, int j)
            => data.Swap(i,j);

        /// <summary>
        /// Applies a permutation to the matrix by swapping the rows
        /// as indicated by permutation transpositions
        /// </summary>
        /// <param name="spec">The permutation definition</param>
        [MethodImpl(Inline)]
        public BitMatrix16 Apply(Perm<N16> perm)
            => BitMatrix.apply(perm, ref this);

        [MethodImpl(Inline)]
        public readonly BitVector16 RowVector(int index)
            => data[index];

        /// <summary>
        /// Returns a mutable reference for an index-identified matrix row
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref ushort RowData(int row)
            => ref data[row];

        /// <summary>
        /// A mutable indexer, functionally equivalent to <see cref='RowData' /> function
        /// </summary>
        /// <param name="row">The row index</param>
        public ref ushort this[int row]
        {
            [MethodImpl(Inline)]
            get => ref RowData(row);
        }

        [MethodImpl(Inline)]
        public BitMatrix16 AndNot(in BitMatrix16 rhs)
            => BitMatrix.andnot(this, rhs, ref this);

        [MethodImpl(Inline)]
        public readonly BitVector16 Diagonal()
            => BitMatrix.diagonal(this);

        public readonly BitMatrix16 Transpose()
        {
            var dst = Replicate();
            for(var i=0; i<N; i++)
                dst.data[i] = ColData(i);
            return dst;
        }

        [MethodImpl(Inline)] 
        public readonly BitMatrix16 Replicate()
            => From(data.ToArray());
        
        /// <summary>
        /// Counts the number of enabled bits in the matrix
        /// </summary>
        [MethodImpl(Inline)] 
        public readonly BitSize Pop()
        {
            var count = 0u;
            for(var i=0; i<data.Length; i++)
                count += Popcnt.PopCount(data[i]);
            return count;
        }

        /// <summary>
        /// Extracts the bits that comprise the matrix in row-major order
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> Unpack()
            => Bytes.Unpack();

        [MethodImpl(Inline)]
        public bool IsZero()
            => BitMatrix.testz(this);

        [MethodImpl(Inline)]
        public string Format()
            => Bytes.FormatMatrixBits(16);

        [MethodImpl(Inline)]
        public bool Equals(BitMatrix16 rhs)
            => BitMatrix.eq(this,rhs);

        [MethodImpl(Inline)]
        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();

        /// <summary>
        /// Loads a cpu vector with the full content of the matrix
        /// </summary>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public void Load(out Vector256<ushort> dst)
            => dinx.vloadu(in Head, out dst);

        /// <summary>
        /// Creates a generic matrix from the primal source data
        /// </summary>
        [MethodImpl(Inline)]
        public BitMatrix<ushort> ToGeneric()
            => new BitMatrix<ushort>(data);

        /// <summary>
        /// Loads a cpu vector with the full content of the matrix; the row parameter is ignored
        /// </summary>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public void Load(int row, out Vector256<ushort> dst)
            => dinx.vloadu(in Head, out dst);

        static ReadOnlySpan<byte> Identity16x16 => new byte[]
        {
            Pow2.T00, 0,
            Pow2.T01, 0,
            Pow2.T02, 0,
            Pow2.T03, 0,
            Pow2.T04, 0,
            Pow2.T05, 0,
            Pow2.T06, 0,
            Pow2.T07, 0,
            0, Pow2.T00,
            0, Pow2.T01,
            0, Pow2.T02,
            0, Pow2.T03,
            0, Pow2.T04,
            0, Pow2.T05,
            0, Pow2.T06,
            0, Pow2.T07,
        };

        public unsafe ushort* HeadPtr
        {
            [MethodImpl(Inline)]
            get => refptr(ref Head);
        }

   }
}