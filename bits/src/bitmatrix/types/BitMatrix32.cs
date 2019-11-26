//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines a 32x32 matrix of bits
    /// </summary>
    
    public readonly ref struct BitMatrix32
    {                
        readonly Span<uint> data;        

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
                
        [MethodImpl(Inline)]
        public static BitMatrix32 From(Span<byte> src)        
            => new BitMatrix32(src.AsUInt32());

        [MethodImpl(Inline)]
        public static BitMatrix32 operator & (in BitMatrix32 A, in BitMatrix32 B)
            => BitMatrix.and(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator | (in BitMatrix32 A, in BitMatrix32 B)
            => BitMatrix.or(A, B);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator ^ (in BitMatrix32 A, in BitMatrix32 B)
            => BitMatrix.xor(A, B);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator ~ (in BitMatrix32 A)
            => BitMatrix.not(A);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator - (in BitMatrix32 A, in BitMatrix32 B)
            => BitMatrix.xornot(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator * (in BitMatrix32 A, in BitMatrix32 B)
            => BitMatrix.mul(A, B);

        [MethodImpl(Inline)]
        public static BitVector32 operator * (in BitMatrix32 A, in BitVector32 B)
            => BitMatrix.mul(A, B);

        [MethodImpl(Inline)]
        public static bool operator ==(in BitMatrix32 A, in BitMatrix32 B)
            => BitMatrix.same(A,B);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitMatrix32 A, in BitMatrix32 B)
            => !BitMatrix.same(A,B);

        [MethodImpl(Inline)]
        internal BitMatrix32(Span<uint> src)
            => this.data = src;

        [MethodImpl(Inline)]
        internal BitMatrix32(bit fill)
        {
            this.data = new uint[N];
            if(fill)
                data.Fill(uint.MaxValue);
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
        /// The square matrix order
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
        /// Queries/manipulates a bit in an identified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => BitMask.test(data[row], col);

            [MethodImpl(Inline)]
            set =>  data[row] = BitMask.set(data[row], (byte)col, value);
        }            

        /// <summary>
        /// Queries/manipulates row data
        /// </summary>
        /// <param name="row">The row index</param>
        public ref BitVector32 this[int row]
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.As<uint,BitVector32>(ref seek(ref Head, row));
        }

        [MethodImpl(Inline)]
        public readonly BitVector32 Column(int index)
        {
            uint col = 0;
            for(var r = 0; r < N; r++)
                col = BitMask.setif(data[r], index, col, r);
            return col;
        }

        [MethodImpl(NotInline)] 
        public readonly BitMatrix32 Replicate()
            => new BitMatrix32(data.ToArray());

        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 32
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public void RowSwap(int i, int j)
            => data.Swap(i,j);        
        
        public readonly BitMatrix32 Transpose()
        {
            var dst = Replicate();
            for(var i=0; i<N; i++)
                dst.data[i] = Column(i);
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