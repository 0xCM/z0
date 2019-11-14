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
    public ref struct BitMatrix8
    {        
        Span<byte> data;
                                        
        /// <summary>
        /// The matrix order
        /// </summary>
        public const uint N = 8;


        /// <summary>
        /// Allocates an 8x8 identity bitmatrix
        /// </summary>
        public static BitMatrix8 Identity => BitMatrix.identity(n8);

        /// <summary>
        /// Allocates an 8x8 zero bitmatrix
        /// </summary>
        public static BitMatrix8 Zero => new BitMatrix8(new byte[N]);

        /// <summary>
        /// Allocates an 8x8 1-filled bitmatrix
        /// </summary>
        public static BitMatrix8 Ones => new BitMatrix8(AllOnes.Replicate());

        /// <summary>
        /// Allocates a matrix with an optional fill value
        /// </summary>
        public static BitMatrix8 Alloc(bit fill = default)                
            => fill ? new BitMatrix8(UInt64.MaxValue) : new BitMatrix8(0ul);

        /// <summary>
        /// Allocates a matrix where each row is initialized to a common vector
        /// </summary>
        /// <param name="fill">The fill vector</param>
        public static BitMatrix8 Alloc(BitVector8 fill)
        {
            var data = new byte[N];
            data.Fill(fill);
            return new BitMatrix8(data);
        }

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
        [MethodImpl(Inline)]
        public static BitMatrix8 From(byte row0, byte row1, byte row2, byte row3, byte row4, byte row5, byte row6, byte row7)        
            => new BitMatrix8(array(row0,row1,row2,row3,row4,row5,row6, row7));

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
            => BitMatrix.xornot(A,B);

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
            => BitConvert.ToUInt64(src.data);

        [MethodImpl(Inline)]
        public static explicit operator BitMatrix8(ulong src)
            => new BitMatrix8(src);

        [MethodImpl(Inline)]
        BitMatrix8(Span<byte> src)
        {
            this.data = src;
        }


        [MethodImpl(Inline)]
        BitMatrix8(ulong src)
        {
            this.data = BitConvert.GetBytes(src);
        }

        /// <summary>
        /// The number of rows in the matrix
        /// </summary>
        public readonly int Order
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
        public BitView<ulong> Data
        {
            [MethodImpl(Inline)]
            get => BitView.Over(ref uint64(ref Head));
        }

        /// <summary>
        /// A reference to the first row of the matrix
        /// </summary>
        public unsafe ref byte Head
        {
            [MethodImpl(Inline)] 
            get => ref head(data);
        }

        /// <summary>
        /// Reads the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        readonly Bit GetBit(int row, int col)
            => BitMask.test(data[row], col);

        /// <summary>
        /// Sets the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        void SetBit(int row, int col, Bit src)
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
        public ref BitVector8 this[int row]
        {
            [MethodImpl(Inline)]
            get => ref RowVector(row);
        }

        [MethodImpl(Inline)]
        public BitMatrix8 AndNot(in BitMatrix8 rhs)
            => BitMatrix.cnotimply(this, rhs, ref this);

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
            => ref seek(ref Head, row);

        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 32
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public void RowSwap(int i, int j)
            => data.Swap(i,j);

        /// <summary>
        /// Presents the data at a specified offset as a bitvector
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref BitVector8 RowVector(int row)
            => ref Unsafe.As<byte,BitVector8>(ref seek(ref Head, row));


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

        static ReadOnlySpan<byte> AllOnes
            => new byte[8]{0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};

        /// <summary>
        /// Queries the matrix for the data in an index-identified column and returns
        /// the bitvector representative
        /// </summary>
        /// <param name="index">The row index</param>
        [MethodImpl(Inline)]
        public readonly BitVector8 ColVector(int index)
            => ColData(index);


        public override string ToString()
            => this.Format();

        [MethodImpl(Inline)]
        public readonly bool Equals(BitMatrix8 rhs)
            => BitMatrix.same(this,rhs);

        [MethodImpl(Inline)]

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode() 
            => throw new NotSupportedException();
    }
}