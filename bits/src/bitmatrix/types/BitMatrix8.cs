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
    using System.Runtime.Intrinsics.X86;

    using static As;

    using static zfunc;
    using System.Runtime.Intrinsics;

    /// <summary>
    /// Defines an 8x8 matrix of bits
    /// </summary>
    public struct BitMatrix8 : IBitSquare<BitMatrix8, byte>
    {        
        byte[] data;
                    
        /// <summary>
        /// The matrix order
        /// </summary>
        public const uint N = 8;

        /// <summary>
        /// The number of bits per row
        /// </summary>
        public const uint RowBitCount = N;

        /// <summary>
        /// The number of bits per column
        /// </summary>
        public const uint ColBitCount = N;

        /// <summary>
        /// The number of bits apprehended by the matrix = 64
        /// </summary>
        public const uint TotalBitCount = RowBitCount * ColBitCount;
                        
        /// <summary>
        /// The (aligned) number of bytes needed for a row
        /// </summary>
        public const uint RowByteCount = RowBitCount >> 3;

        /// <summary>
        /// The (aligned) number of bytes needed for a column
        /// </summary>
        public const uint ColByteCount = ColBitCount >> 3;

        public const uint TotalByteCount = TotalBitCount >> 3;

        /// <summary>
        /// Defines the 8x8 identity bitmatrix
        /// </summary>
        public static BitMatrix8 Identity => From(Identity8x8.ToSpan());

        /// <summary>
        /// Defines the 8x8 zero bitmatrix
        /// </summary>
        public static BitMatrix8 Zero => Alloc();

        /// <summary>
        /// Allocates a matrix, optionally assigning each element to the
        /// specified bit value
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix8 Alloc(Bit? fill = null)                
            => fill == Bit.On ? new BitMatrix8(UInt64.MaxValue) : new BitMatrix8(0ul);

        /// <summary>
        /// Loads a matrix from the source value
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 From(ulong src)        
            => new BitMatrix8(src);

        /// <summary>
        /// Creates an 8x8 bitmatrix from a span of length 8
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 From(Span<byte> src)        
            => new BitMatrix8(src);

        /// <summary>
        /// Creates an 8x8 bitmatrix from a memory segment of length 8
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 From(byte[] src)        
            => new BitMatrix8(src);

        /// <summary>
        /// Defines a matrix by the explicit specification of 8 bytes
        /// </summary>
        /// <param name="row0">Specifies the bits in row0</param>
        /// <param name="row1">Specifies the bits in row1</param>
        /// <param name="row2">Specifies the bits in row2</param>
        /// <param name="row3">Specifies the bits in row3</param>
        /// <param name="row4">Specifies the bits in row4</param>
        /// <param name="row5">Specifies the bits in row5</param>
        /// <param name="row6">Specifies the bits in row6</param>
        /// <param name="row7">Specifies the bits in row7</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 From(byte row0, byte row1, byte row2, byte row3, byte row4, byte row5, byte row6, byte row7)        
            => new BitMatrix8(MemorySpan.From(row0,row1,row2,row3,row4,row5,row6, row7));

        /// <summary>
        /// Defifines a matrix from two 32-bit unsigned integers; the upper value contains
        /// the data for rows 0...3 and the lower value contains the dat for rows [4 ... 7]
        /// </summary>
        /// <param name="lo">The upper row data</param>
        /// <param name="hi">The lower row data</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 From(uint lo, uint hi)
            => From(Z0.Bits.pack(lo, hi));


        [MethodImpl(Inline)]
        public static BitMatrix8 operator & (BitMatrix8 lhs, BitMatrix8 rhs)
            =>  BitMatrix.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator | (BitMatrix8 lhs, BitMatrix8 rhs)
            => BitMatrix.or(lhs,rhs);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator ^ (BitMatrix8 lhs, BitMatrix8 rhs)
            => BitMatrix.xor(lhs,rhs);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator ~ (BitMatrix8 src)
            => BitMatrix.not(src);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator - (BitMatrix8 A, BitMatrix8 B)
            => BitMatrix.sub(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator * (BitMatrix8 lhs, BitMatrix8 rhs)
            => BitMatrix.mul(lhs,rhs);

        [MethodImpl(Inline)]
        public static BitVector8 operator * (BitMatrix8 lhs, BitVector8 rhs)
            => BitMatrix.mul(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix8 lhs, BitMatrix8 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix8 lhs, BitMatrix8 rhs)
            => !(lhs.Equals(rhs));

        [MethodImpl(Inline)]
        public static explicit operator ulong(BitMatrix8 src)
            => BitConverter.ToUInt64(src.data);

        [MethodImpl(Inline)]
        public static explicit operator BitMatrix8(ulong src)
            => From(src);

        [MethodImpl(Inline)]
        BitMatrix8(Span<byte> src)
        {
            require(src.Length == Pow2.T03);
            this.data = src.ToArray();
        }

        [MethodImpl(Inline)]
        BitMatrix8(byte[] src)
        {
            require(src.Length == Pow2.T03);
            this.data = src;
        }

        [MethodImpl(Inline)]
        BitMatrix8(ulong src)
        {
            this.data = src.ToBytes();
        }

        /// <summary>
        /// The number of rows in the matrix
        /// </summary>
        public readonly int RowCount
        {
            [MethodImpl(Inline)]
            get => (int)N;
        }

        /// <summary>
        /// The number of columns in the matrix
        /// </summary>
        public readonly int ColCount
        {
            [MethodImpl(Inline)]
            get => (int)N;
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => data;            
        }

        /// <summary>
        /// The underlying matrix data
        /// </summary>
        public Span<byte> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// The data enclosed by the matrix
        /// </summary>
        public byte[] Rows
        {
            [MethodImpl(Inline)] 
            get => data;
        }

        /// <summary>
        /// A reference to the first row of the matrix
        /// </summary>
        public ref byte Head
        {
            [MethodImpl(Inline)] 
            get => ref data[0];
        }


        /// <summary>
        /// Constructs an 8-node graph via the adjacency matrix interpretation
        /// </summary>
        public Graph<byte> ToGraph()
            => BitGraph.FromMatrix<byte,N8,byte>(BitMatrix<N8,N8,byte>.Load(data));            

        /// <summary>
        /// Packs the matrix into an unsigned 64-bit integer
        /// </summary>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public ulong Pack()
            => BitConverter.ToUInt64(data);

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

        /// <summary>
        /// A mutable indexer, functionally equivalent to <see cref='RowData' /> function
        /// </summary>
        /// <param name="row">The row index</param>
        public ref byte this[int row]
        {
            [MethodImpl(Inline)]
            get => ref RowData(row);
        }

        [MethodImpl(Inline)]
        public readonly bool IsZero()
            => BitMatrix.testz(this);

        [MethodImpl(Inline)]
        public BitMatrix8 AndNot(in BitMatrix8 rhs)
            => BitMatrix.andnot(ref this, rhs);

        /// <summary>
        /// Retrives the bitvector determined by the matrix diagonal
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitVector8 Diagonal()
            => BitMatrix.diagonal(this);

        /// <summary>
        /// Returns a mutable reference for an index-identified matrix row
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref byte RowData(int row)
            => ref data[row];

        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 32
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public void RowSwap(int i, int j)
            => data.Swap(i,j);

        /// <summary>
        /// Queries the matrix for the data in an index-identified row and returns
        /// the bitvector representative
        /// </summary>
        /// <param name="index">The row index</param>
        [MethodImpl(Inline)]
        public readonly BitVector8 RowVector(int index)
            => data[index];

        /// <summary>
        /// Replaces the data in an index-identified row with the data
        /// represented by a bitvector source
        /// </summary>
        /// <param name="index">The row index</param>
        [MethodImpl(Inline)]
        public BitVector8 RowVector(int index, BitVector8 src)
            => data[index] = (byte)src;

        /// <summary>
        /// Transposes a copy of the matrix
        /// </summary>
        public readonly BitMatrix8 Transpose()
            => BitMatrix.transpose(this);

        [MethodImpl(Inline)]
        public void Load(int row, out Vector256<byte> dst)
            => dst = Vector256.CreateScalar(Pack()).AsByte();

        /// <summary>
        /// Queries the matrix for the data in an index-identified column 
        /// </summary>
        /// <param name="index">The row index</param>
        public readonly byte ColData(int index)
        {
            byte col = 0;
            for(var r = 0; r < N; r++)
                if(BitMask.test(data[r], index))
                    BitMask.enable(ref col, r);
            return col;
        }

        /// <summary>
        /// Queries the matrix for the data in an index-identified column and returns
        /// the bitvector representative
        /// </summary>
        /// <param name="index">The row index</param>
        [MethodImpl(Inline)]
        public readonly BitVector8 ColVector(int index)
            => ColData(index);

        /// <summary>
        /// Applies a permutation to the matrix by swapping the rows
        /// as indicated by permutation transpositions
        /// </summary>
        /// <param name="spec">The permutation definition</param>
        [MethodImpl(Inline)]
        public BitMatrix8 Apply(Perm<N8> perm)    
            => BitMatrix.apply(perm, ref this);

        /// <summary>
        /// Creates a new matrix by cloning the existing matrix or allocating
        /// a matrix with the same structure
        /// </summary>
        /// <param name="structureOnly">Specifies whether the replication reproduces
        /// only structure and is thus equivalent to an allocation</param>
        [MethodImpl(Inline)] 
        public readonly BitMatrix8 Replicate(bool structureOnly = false)
            => structureOnly ? Alloc() : From(data.Replicate());

        /// <summary>
        /// Counts the number of enabled bits in the matrix
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Pop()
            => Z0.Bits.pop((ulong)this);

        [MethodImpl(Inline)]
        public readonly string Format()
            => data.FormatMatrixBits(8);

        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitVector64 ToBitVector()
            => BitVector64.FromScalar((ulong)this);

        [MethodImpl(Inline)]
        public readonly bool Equals(BitMatrix8 rhs)
            => BitMatrix.eq(this,rhs);

        [MethodImpl(Inline)]

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode() 
            => throw new NotSupportedException();


        static ReadOnlySpan<byte> Identity8x8 => new byte[]
        {
            1 << 0, 1 << 1, 1 << 2, 1 << 3, 1 << 4, 1 << 5, 1 << 6, 1 << 7
        };

    }
}