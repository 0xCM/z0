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
    /// Defines a 64x64 matrix of bits
    /// </summary>
    public struct BitMatrix64 : IBitSquare<BitMatrix64,ulong>
    {                
        ulong[] data;

        /// <summary>
        /// The matrix order
        /// </summary>
        public const uint N = 64;

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
        /// Defines the 64x64 identity bitmatrix
        /// </summary>
        public static BitMatrix64 Identity => From(Identity64x64.ToArray());

        /// <summary>
        /// Defines the 64x64 zero bitmatrix
        /// </summary>
        public static BitMatrix64 Zero  => Alloc();
        
        [MethodImpl(Inline)]
        public static BitMatrix64 Alloc()        
            => new BitMatrix64(new ulong[N]);

        [MethodImpl(Inline)]
        public static BitMatrix64 From(params ulong[] src)        
            => src.Length == 0 ? Alloc() : new BitMatrix64(src);

        [MethodImpl(Inline)]
        public static BitMatrix64 From(BitMatrix<N64,ulong> src)        
            => From(src.Data.AsBytes());

        [MethodImpl(Inline)]
        public static BitMatrix64 From(Span<ulong> src)        
            => new BitMatrix64(src.ToArray());

        [MethodImpl(Inline)]
        public static BitMatrix64 From(in Span<N64,ulong> src)        
            => new BitMatrix64(src.ToArray());

        [MethodImpl(Inline)]
        public static BitMatrix64 From(Span<byte> src)        
            => new BitMatrix64(src.AsUInt64().ToArray());

        [MethodImpl(Inline)]
        public static BitMatrix64 operator & (BitMatrix64 A, BitMatrix64 B)
        {
            var C = BitMatrix64.Alloc();
            BitMatrix.and(A,B, ref C);
            return C;
        }

        [MethodImpl(Inline)]
        public static BitMatrix64 operator | (BitMatrix64 A, BitMatrix64 B)
            => BitMatrix.or(ref A,B);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator ^ (BitMatrix64 A, BitMatrix64 B)
            => BitMatrix.xor(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator ~ (BitMatrix64 A)
            => BitMatrix.not(A);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator - (BitMatrix64 A, BitMatrix64 B)
            => BitMatrix.sub(A,B);

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
        BitMatrix64(ulong[] src)
        {                        
            require(src.Length == Pow2.T06);
            this.data = src;
        }

        // [MethodImpl(Inline)]
        // BitMatrix64(Span<ulong> src)
        // {                        
        //     require(src.Length == Pow2.T06);
        //     this.data = src;
        // }

        // [MethodImpl(Inline)]
        // BitMatrix64(Span<N64,ulong> src)
        // {                        
        //     this.data = src;
        // }

        /// <summary>
        /// Specifies the number of rows in the matrix
        /// </summary>
        public readonly int RowCount
        {
            [MethodImpl(Inline)]
            get => (int)N;
        }

        /// <summary>
        /// Specifies the number of columns in the matrix
        /// </summary>
        public readonly int ColCount
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
            get => data.AsSpan().AsBytes();
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
            get => GetBit(row, col);

            [MethodImpl(Inline)]
            set => SetBit(row,col,value);
        }            

        /// <summary>
        /// Creates a bitvector from the content of an index-identified row
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public readonly BitVector64 RowVector(int row)
            => data[row];

        /// <summary>
        /// Returns a mutable reference for an index-identified matrix row
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref ulong RowData(int row)
            => ref data[row];

        /// <summary>
        /// A mutable indexer, functionally equivalent to <see cref='RowData' /> function
        /// </summary>
        /// <param name="row">The row index</param>
        public ref ulong this[int row]
        {
            [MethodImpl(Inline)]
            get => ref RowData(row);
        }

        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 64
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
        public BitMatrix64 Apply(Perm<N64> perm)
            => BitMatrix.apply(perm, ref this);

        /// <summary>
        /// Returns the data for an index-identified column
        /// </summary>
        public readonly ulong ColData(int index)
        {
            ulong col = 0;
            for(var r = 0; r < N; r++)
                BitMask.setif(in data[r], index, ref col, r);
            return col;
        }
        
        /// <summary>
        /// Creates a bitvector from the content of an index-identified column
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public readonly BitVector64 ColVector(int col)
            =>  ColData(col);

        /// <summary>
        /// Extracts the bits that comprise the matrix in row-major order
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> Unpack()
            => Bytes.Unpack();

        [MethodImpl(Inline)]
        public BitMatrix64 Compare(BitMatrix64 rhs)
            => this.AndNot(rhs);

        /// <summary>
        /// Determines whether this matrix is equivalent to the canonical 0 matrix
        /// </summary>
        [MethodImpl(Inline)] 
        public readonly bool IsZero()
            => BitMatrix.testz(this);

        [MethodImpl(Inline)] 
        public readonly BitVector64 Diagonal()
            => BitMatrix.diagonal(this);

        [MethodImpl(Inline)] 
        public BitMatrix64 AndNot(in BitMatrix64 rhs)
            => BitMatrix.andn(this, rhs, ref this);

        public readonly BitMatrix64 Transpose()
        {
            var dst = Replicate();
            for(var i=0; i<N; i++)
                dst.data[i] = ColData(i);
            return dst;
        }

        /// <summary>
        /// Loads a CPU vector from matrix content
        /// </summary>
        /// <param name="dst">The target vector</param>
        /// <param name="row">The row index of where the load should begin</param>
        [MethodImpl(Inline)]
        public readonly ref Vec256<ulong> GetCells(int row, out Vec256<ulong> dst)
        {
            dst = load(ref data[row]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public void Load(int row, out Vector256<ulong> dst)
            => dst = dinx.vloadu(in data[row], out dst);

        /// <summary>
        /// Counts the number of enabled bits in the matrix
        /// </summary>
        [MethodImpl(Inline)] 
        public readonly BitSize Pop()
        {
            var count = 0u;
            for(var i=0; i<data.Length; i++)
                count += Bits.pop(data[i]);
            return count;
        }

        /// <summary>
        /// The data enclosed by the matrix
        /// </summary>
        public ulong[] Rows
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
            get => ref data[0];
        }

        /// <summary>
        /// Computes the product the source matrix and the operand in-place
        /// </summary>
        /// <param name="rhs">The operand</param>
        [MethodImpl(Inline)]
        public void Mul(BitMatrix64 rhs)
        {
            BitMatrix.mul(ref this, rhs);
        }

        /// <summary>
        /// Computes the bitwise AND of the source matrix and the operand in-place
        /// </summary>
        /// <param name="rhs">The operand</param>
        [MethodImpl(Inline)]
        public void And(BitMatrix64 rhs)
        {
            BitMatrix.and(this, rhs, ref this);
        }

        /// <summary>
        /// Computes the bitwise OR of the source matrix and the operand in-place
        /// </summary>
        /// <param name="rhs">The operand</param>
        [MethodImpl(Inline)]
        public void Or(BitMatrix64 rhs)
        {
            BitMatrix.or(ref this, rhs);
        }

        /// <summary>
        /// Computes the bitwise XOR of the source matrix and the operand in-place
        /// </summary>
        /// <param name="rhs">The operand</param>
        [MethodImpl(Inline)]
        public void XOr(BitMatrix64 rhs)
        {
            BitMatrix.xor(ref this, rhs);
        }

        /// <summary>
        /// Computes the complement source matrix in-place
        /// </summary>
        /// <param name="rhs">The operand</param>
        [MethodImpl(Inline)]
        public void Not()
        {
            BitMatrix.not(ref this);
        }
 
        [MethodImpl(Inline)] 
        public readonly BitMatrix64 Replicate()
            => From(data.ToArray()); 

        [MethodImpl(Inline)]
        public string Format()
            => data.FormatMatrixBits(64);

        [MethodImpl(Inline)]
        public bool Equals(BitMatrix64 rhs)
            => BitMatrix.eq(this,rhs);

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
        
        public override string ToString()
            => throw new NotSupportedException();
       

        [MethodImpl(Inline)]
        static unsafe Vec256<ulong> load(ref ulong head)
            => Avx.LoadVector256(refptr(ref head));


        static ReadOnlySpan<byte> Identity64x64 => new byte[]
        {
            Pow2.T00, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T01, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T02, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T03, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T04, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T05, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T06, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T07, 0, 0, 0, 0, 0, 0, 0,
            0, Pow2.T00, 0, 0, 0, 0, 0, 0,
            0, Pow2.T01, 0, 0, 0, 0, 0, 0,
            0, Pow2.T02, 0, 0, 0, 0, 0, 0,
            0, Pow2.T03, 0, 0, 0, 0, 0, 0,
            0, Pow2.T04, 0, 0, 0, 0, 0, 0,
            0, Pow2.T05, 0, 0, 0, 0, 0, 0,
            0, Pow2.T06, 0, 0, 0, 0, 0, 0,
            0, Pow2.T07, 0, 0, 0, 0, 0, 0,
            0, 0, Pow2.T00, 0, 0, 0, 0, 0,
            0, 0, Pow2.T01, 0, 0, 0, 0, 0,
            0, 0, Pow2.T02, 0, 0, 0, 0, 0,
            0, 0, Pow2.T03, 0, 0, 0, 0, 0,
            0, 0, Pow2.T04, 0, 0, 0, 0, 0,
            0, 0, Pow2.T05, 0, 0, 0, 0, 0,
            0, 0, Pow2.T06, 0, 0, 0, 0, 0,
            0, 0, Pow2.T07, 0, 0, 0, 0, 0,
            0, 0, 0, Pow2.T00, 0, 0, 0, 0,
            0, 0, 0, Pow2.T01, 0, 0, 0, 0,
            0, 0, 0, Pow2.T02, 0, 0, 0, 0,
            0, 0, 0, Pow2.T03, 0, 0, 0, 0,
            0, 0, 0, Pow2.T04, 0, 0, 0, 0,
            0, 0, 0, Pow2.T05, 0, 0, 0, 0,
            0, 0, 0, Pow2.T06, 0, 0, 0, 0,
            0, 0, 0, Pow2.T07, 0, 0, 0, 0,
            0, 0, 0, 0, Pow2.T00, 0, 0, 0,
            0, 0, 0, 0, Pow2.T01, 0, 0, 0,
            0, 0, 0, 0, Pow2.T02, 0, 0, 0,
            0, 0, 0, 0, Pow2.T03, 0, 0, 0,
            0, 0, 0, 0, Pow2.T04, 0, 0, 0,
            0, 0, 0, 0, Pow2.T05, 0, 0, 0,
            0, 0, 0, 0, Pow2.T06, 0, 0, 0,
            0, 0, 0, 0, Pow2.T07, 0, 0, 0,
            0, 0, 0, 0, 0, Pow2.T00, 0, 0,
            0, 0, 0, 0, 0, Pow2.T01, 0, 0,
            0, 0, 0, 0, 0, Pow2.T02, 0, 0,
            0, 0, 0, 0, 0, Pow2.T03, 0, 0,
            0, 0, 0, 0, 0, Pow2.T04, 0, 0,
            0, 0, 0, 0, 0, Pow2.T05, 0, 0,
            0, 0, 0, 0, 0, Pow2.T06, 0, 0,
            0, 0, 0, 0, 0, Pow2.T07, 0, 0,
            0, 0, 0, 0, 0, 0, Pow2.T00, 0,
            0, 0, 0, 0, 0, 0, Pow2.T01, 0,
            0, 0, 0, 0, 0, 0, Pow2.T02, 0,
            0, 0, 0, 0, 0, 0, Pow2.T03, 0,
            0, 0, 0, 0, 0, 0, Pow2.T04, 0,
            0, 0, 0, 0, 0, 0, Pow2.T05, 0,
            0, 0, 0, 0, 0, 0, Pow2.T06, 0,
            0, 0, 0, 0, 0, 0, Pow2.T07, 0,
            0, 0, 0, 0, 0, 0, 0, Pow2.T00,
            0, 0, 0, 0, 0, 0, 0, Pow2.T01,
            0, 0, 0, 0, 0, 0, 0, Pow2.T02,
            0, 0, 0, 0, 0, 0, 0, Pow2.T03,
            0, 0, 0, 0, 0, 0, 0, Pow2.T04,
            0, 0, 0, 0, 0, 0, 0, Pow2.T05,
            0, 0, 0, 0, 0, 0, 0, Pow2.T06,
            0, 0, 0, 0, 0, 0, 0, Pow2.T07,
        };

    }
}