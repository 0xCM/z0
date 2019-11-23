// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines a 64x64 matrix of bits
    /// </summary>
    public readonly ref struct BitMatrix64
    {                
        readonly Span<ulong> data;

        /// <summary>
        /// The matrix order
        /// </summary>
        public const uint N = 64;

        /// <summary>
        /// Defines the 64x64 identity bitmatrix
        /// </summary>
        public static BitMatrix64 Identity => BitMatrix.identity(n64);

        /// <summary>
        /// Defines the 64x64 zero bitmatrix
        /// </summary>
        public static BitMatrix64 Zero => new BitMatrix64(new ulong[N]);
        
        [MethodImpl(Inline)]
        public static BitMatrix64 Alloc()        
            => new BitMatrix64(new ulong[N]);

        /// <summary>
        /// Allocates a matrix with a fill value
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix64 Alloc(bit fill)                
            => new BitMatrix64(fill);

        /// <summary>
        /// Allocates a matrix where each row is initialized to a common vector
        /// </summary>
        /// <param name="fill">The fill vector</param>
        [MethodImpl(Inline)]
        internal static BitMatrix64 Alloc(BitVector64 fill)
        {
            var data = new ulong[N];
            data.Fill(fill);
            return new BitMatrix64(data);
        }

        [MethodImpl(Inline)]
        public static BitMatrix64 From(ulong[] src)        
            => new BitMatrix64(src);

        [MethodImpl(Inline)]
        public static BitMatrix64 From(BitMatrix<N64,ulong> src)        
            => From(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix64 From(Span<ulong> src)        
            => new BitMatrix64(src);

        [MethodImpl(Inline)]
        public static BitMatrix64 From(in NatSpan<N64,ulong> src)        
            => new BitMatrix64(src);

        [MethodImpl(Inline)]
        public static BitMatrix64 From(Span<byte> src)        
            => new BitMatrix64(src.AsUInt64());

        [MethodImpl(Inline)]
        public static BitMatrix64 operator & (BitMatrix64 A, BitMatrix64 B)
            => BitMatrix.and(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator | (BitMatrix64 A, BitMatrix64 B)
            => BitMatrix.or(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator ^ (BitMatrix64 A, BitMatrix64 B)
            => BitMatrix.xor(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator ~ (BitMatrix64 A)
            => BitMatrix.not(A);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator - (BitMatrix64 A, BitMatrix64 B)
            => BitMatrix.xornot(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator * (BitMatrix64 A, BitMatrix64 B)
            => BitMatrix.mul(A,B);

        [MethodImpl(Inline)]
        public static BitVector64 operator * (BitMatrix64 A, BitVector64 B)
            => BitMatrix.mul(A,B);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix64 A, BitMatrix64 B)
            => A.Equals(B);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix64 A, BitMatrix64 B)
            => !A.Equals(B);


        [MethodImpl(Inline)]
        internal BitMatrix64(Span<ulong> src)
        {                        
            this.data = src;
        }

        [MethodImpl(Inline)]
        internal BitMatrix64(bit fill)
        {
            this.data = new ulong[N];
            if(fill)
                data.Fill(ulong.MaxValue);
        }

        /// <summary>
        /// Specifies the number of rows in the matrix
        /// </summary>
        public readonly int Order
        {
            [MethodImpl(Inline)]
            get => (int)N;
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
        public Span<ulong> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// A reference to the first row of the matrix
        /// </summary>
        public ref ulong Head
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
            get => GetBit(row, col);

            [MethodImpl(Inline)]
            set => SetBit(row,col,value);
        }            

        /// <summary>
        /// Gets or sets the data for a specified row
        /// </summary>
        /// <param name="row">The row index</param>
        public ref BitVector64 this[int row]
        {
            [MethodImpl(Inline)]
            get => ref Row(row);
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
            => data[row] = BitMask.set(data[row], (byte)col, src);

        /// <summary>
        /// Presents the data at a specified offset as a bitvector
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref BitVector64 Row(int row)
            => ref Unsafe.As<ulong,BitVector64>(ref seek(ref Head, row));

        [MethodImpl(Inline)]
        public readonly BitVector64 Column(int index)
        {
            var col = 0ul;
            for(var r = 0; r < N; r++)
                col = BitMask.setif(data[r], index, col, r);
            return col;
        }        

        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 64
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public void RowSwap(int i, int j)
            => data.Swap(i,j);

        [MethodImpl(Inline)] 
        public BitVector64 Diagonal()
            => BitMatrix.diagonal(this);

        public BitMatrix64 Transpose()
        {
            var dst = Replicate();
            for(var i=0; i<N; i++)
                dst.data[i] = Column(i);
            return dst;
        }

        [MethodImpl(Inline)] 
        public readonly BitMatrix64 Replicate()
            => From(data.ToArray()); 

        [MethodImpl(Inline)]
        public bool Equals(BitMatrix64 rhs)
            => BitMatrix.same(this,rhs);

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
        
        public override string ToString()
            => throw new NotSupportedException();       
    }
}