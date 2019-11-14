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
    public ref struct BitMatrix16 
    {   
        Span<ushort> data;

        /// <summary>
        /// The matrix order
        /// </summary>
        public const uint N = 16;
                                
        /// <summary>
        /// Defines the 16x16 identity bitmatrix
        /// </summary>
        public static BitMatrix16 Identity => BitMatrix.identity(n16);

        /// <summary>
        /// Allocates a 16x16 zero bitmatrix
        /// </summary>
        public static BitMatrix16 Zero => new BitMatrix16(new ushort[N]);

        [MethodImpl(Inline)]
        public static BitMatrix16 Alloc()        
            => From(new ushort[N]);

        /// <summary>
        /// Allocates a matrix where each row is initialized to a common vector
        /// </summary>
        /// <param name="fill">The fill vector</param>
        public static BitMatrix16 Alloc(BitVector16 fill)
        {
            var data = new ushort[N];
            data.Fill(fill);
            return new BitMatrix16(data);
        }

        /// <summary>
        /// Allocates a matrix with a fill value
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix16 Alloc(bit fill)                
            => new BitMatrix16(fill);

        [MethodImpl(Inline)]
        public static BitMatrix16 From(ushort[] src)        
            => new BitMatrix16(src);

        [MethodImpl(Inline)]
        public static BitMatrix16 From(Span<ushort> src)        
            => new BitMatrix16(src);

        [MethodImpl(Inline)]
        public static BitMatrix16 From(Span<byte> src)        
            => new BitMatrix16(src.AsUInt16());

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
        BitMatrix16(Span<ushort> src)
        {                        
            this.data = src;
        }

        BitMatrix16(bit fill)
        {
            this.data = new ushort[N];
            if(fill)
                data.Fill(ushort.MaxValue);
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
        public Span<ushort> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// A reference to the first row of the matrix
        /// </summary>
        public unsafe ref ushort Head
        {
            [MethodImpl(Inline)] 
            get => ref head(data);
        }

        /// <summary>
        /// Reads/manipulates the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        /// <param name="src">The source value</param>
        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => GetBit(row,col);

            [MethodImpl(Inline)]
            set => SetBit(row,col,value);
        }            

        /// <summary>
        /// Gets/sets an identified row
        /// </summary>
        /// <param name="row">The row index</param>
        public ref BitVector16 this[int row]
        {
            [MethodImpl(Inline)]
            get => ref RowVector(row);
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

        /// <summary>
        /// Presents the data at a specified offset as a bitvector
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref BitVector16 RowVector(int row)
            => ref Unsafe.As<ushort,BitVector16>(ref seek(ref Head, row));

        /// <summary>
        /// Returns a mutable reference for an index-identified matrix row
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref ushort RowData(int row)
            => ref data[row];

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
        /// Reads the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public bit GetBit(int row, int col)
            => BitMask.test(skip(in Head, row), col);

        /// <summary>
        /// Sets the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public void SetBit(int row, int col, bit src)
            => BitMask.set(ref seek(ref Head, row), (byte)col, src);


        [MethodImpl(Inline)]
        public BitMatrix16 AndNot(in BitMatrix16 rhs)
            => BitMatrix.cnotimply(this, rhs, ref this);

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

        [MethodImpl(NotInline)] 
        public readonly BitMatrix16 Replicate()
            => From(data.ToArray());        

        /// <summary>
        /// Extracts the bits that comprise the matrix in row-major order
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> Unpack()
            => Bytes.Unpack();

        [MethodImpl(Inline)]
        public string Format()
            => Bytes.FormatMatrixBits(16);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(BitMatrix16 rhs)
            => BitMatrix.same(this,rhs);

        [MethodImpl(Inline)]
        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
   }
}