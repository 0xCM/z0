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

    /// <summary>
    /// Defines a 32x32 matrix of bits
    /// </summary>
    
    public ref struct BitMatrix32
    {                
        Span<uint> data;        

        /// <summary>
        /// The matrix order
        /// </summary>
        public static readonly N32 N = default;

        /// <summary>
        /// The number of bits per row = 32
        /// </summary>
        public static readonly BitSize RowBitCount = N.value;        

        /// <summary>
        /// The number of bits per column = 32
        /// </summary>
        public static readonly BitSize ColBitCount = N.value;

        /// <summary>
        /// The number of bits apprehended by the matrix = 1024 bits =  128 bytes
        /// </summary>
        public static readonly BitSize TotalBitCount = RowBitCount * ColBitCount;
                        
        /// <summary>
        /// The (aligned) number of bytes needed for a row
        /// </summary>
        public static readonly ByteSize RowByteCount = (ByteSize)RowBitCount;                        

        /// <summary>
        /// The (aligned) number of bytes needed for a column
        /// </summary>
        public static readonly ByteSize ColByteCount = (ByteSize)ColBitCount;

        /// <summary>
        /// Defines the 32x32 identity bitmatrix
        /// </summary>
        public static BitMatrix32 Identity => From(Identity32x32.ToSpan());

        /// <summary>
        /// Defines the 32x32 zero bitmatrix
        /// </summary>
        public static BitMatrix32 Zero => Alloc();
                
        [MethodImpl(Inline)]
        public static BitMatrix32 Alloc()        
            => new BitMatrix32(new uint[N]);

        [MethodImpl(Inline)]
        public static BitMatrix32 From(params uint[] src)        
            => src.Length == 0 ? Alloc() : new BitMatrix32(src);

        [MethodImpl(Inline)]
        public static BitMatrix32 From(BitMatrix<N32,uint> src)        
            => new BitMatrix32(src);

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
            => BitMatrix.flip(src);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator - (BitMatrix32 A, BitMatrix32 B)
            => BitMatrix.sub(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator * (BitMatrix32 lhs, BitMatrix32 rhs)
            => BitMatrix.mul(lhs, rhs);

        [MethodImpl(Inline)]
        public static BitVector32 operator * (BitMatrix32 lhs, BitVector32 rhs)
            => BitMatrix.mul(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix32 lhs, BitMatrix32 rhs)
            => BitMatrix.eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix32 lhs, BitMatrix32 rhs)
            => !BitMatrix.eq(lhs,rhs);

        [MethodImpl(Inline)]
        BitMatrix32(Span<uint> src)
        {                        
            require(src.Length == Pow2.T05);
            this.data = src;
        }        

        [MethodImpl(Inline)]
        BitMatrix32(uint[] src)
        {                        
            require(src.Length == Pow2.T05);
            this.data = src;
        }        

        [MethodImpl(Inline)]
        BitMatrix32(BitMatrix<N32,uint> src)
        {
            this.data = src.Data;
        }

        public readonly int RowCount
        {
            [MethodImpl(Inline)]
            get => N;
        }

        public readonly int ColCount
        {
            [MethodImpl(Inline)]
            get => N;
        }

        /// <summary>
        /// Reads the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public readonly Bit GetBit(int row, int col)
            => BitMask.test(in data[row], col);

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
        /// Queries/manipulates a bit in an identified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        public Bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => GetBit(row,col);

            [MethodImpl(Inline)]
            set => SetBit(row,col,value);
        }            

        [MethodImpl(Inline)] 
        public readonly BitVector32 Diagonal()
            => BitMatrix.diagonal(this);

        [MethodImpl(Inline)] 
        public readonly BitMatrix32 Replicate()
            => new BitMatrix32(data.ToArray());

        [MethodImpl(Inline)]
        public readonly BitVector32 RowVector(int index)
            => data[index];

        /// <summary>
        /// Returns a mutable reference for an index-identified matrix row
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref uint RowData(int row)
            => ref data[row];

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
        /// Queries/manipulates row data
        /// </summary>
        /// <param name="row">The row index</param>
        public ref uint this[int row]
        {
            [MethodImpl(Inline)]
            get => ref RowData(row);
        }

        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 32
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
        public BitMatrix32 Apply(Perm<N32> perm)
            => BitMatrix.apply(perm, ref this);

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

        [MethodImpl(Inline)]
        public bool Equals(BitMatrix32 rhs)
            => BitMatrix.eq(this,rhs);

        [MethodImpl(Inline)]
        public readonly bool IsZero()
            => BitMatrix.testz(this);

        [MethodImpl(Inline)]
        public  BitMatrix32 AndNot(BitMatrix32 rhs)
            => BitMatrix.andn(ref this, rhs);
        // {
        //     const int rowstep = 8;
        //     for(var i=0; i< RowCount; i += rowstep)
        //     {
        //         this.GetCells(i, out Vec256<uint> vLhs);
        //         rhs.GetCells(i, out Vec256<uint> vRhs);
        //         dinx.vandn(vLhs,vRhs).StoreTo(ref data[i]);
        //     }
        //     return this;
        // }
        
        public readonly BitMatrix32 Transpose()
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
        public readonly ref Vec256<uint> GetCells(int row, out Vec256<uint> dst)
        {
            dst = load(ref data[row]);
            return ref dst;
        }

        /// <summary>
        /// Counts the number of enabled bits in the matrix
        /// </summary>
        [MethodImpl(Inline)] 
        public readonly BitSize Pop()
            => bitspan.pop(data);


        [MethodImpl(Inline)]
        public string Format()
            => data.FormatMatrixBits(32);

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
        
        public override string ToString()
            => Format();


        [MethodImpl(Inline)]
        static unsafe Vec256<uint> load(ref uint head)
            => Avx.LoadVector256(refptr(ref head));

        static ReadOnlySpan<byte> Identity32x32 => new byte[]
        {
            Pow2.T00, 0, 0, 0,
            Pow2.T01, 0, 0, 0,
            Pow2.T02, 0, 0, 0,
            Pow2.T03, 0, 0, 0,
            Pow2.T04, 0, 0, 0,
            Pow2.T05, 0, 0, 0,
            Pow2.T06, 0, 0, 0,
            Pow2.T07, 0, 0, 0,
            0, Pow2.T00, 0, 0,
            0, Pow2.T01, 0, 0,
            0, Pow2.T02, 0, 0,
            0, Pow2.T03, 0, 0,
            0, Pow2.T04, 0, 0,
            0, Pow2.T05, 0, 0,
            0, Pow2.T06, 0, 0,
            0, Pow2.T07, 0, 0,
            0, 0, Pow2.T00, 0,
            0, 0, Pow2.T01, 0,
            0, 0, Pow2.T02, 0,
            0, 0, Pow2.T03, 0,
            0, 0, Pow2.T04, 0,
            0, 0, Pow2.T05, 0,
            0, 0, Pow2.T06, 0,
            0, 0, Pow2.T07, 0,
            0, 0, 0, Pow2.T00,
            0, 0, 0, Pow2.T01,
            0, 0, 0, Pow2.T02,
            0, 0, 0, Pow2.T03,
            0, 0, 0, Pow2.T04,
            0, 0, 0, Pow2.T05,
            0, 0, 0, Pow2.T06,
            0, 0, 0, Pow2.T07,

        };

    }
}