//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; 
    using static Memories;

    /// <summary>
    /// Defines a 32x32 matrix of bits
    /// </summary>    
    [IdentityProvider(typeof(BitMatrixIdentityProvider))]
    public readonly ref struct BitMatrix32
    {                
        internal readonly Span<uint> Data;        

        /// <summary>
        /// The matrix order
        /// </summary>
        public const int N = 32;

        /// <summary>
        /// Allocates a 32x32 identity bitmatrix
        /// </summary>
        public static BitMatrix32 Identity => BitMatrix.identity(n32);

        /// <summary>
        /// Allocates a 32x32 zero bitmatrix
        /// </summary>
        public static BitMatrix32 Zero => new BitMatrix32(new uint[N]);
                
        [MethodImpl(Inline)]
        public static implicit operator BitMatrix<uint>(in BitMatrix32 src)
            => BitMatrix.load(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator & (in BitMatrix32 A, in BitMatrix32 B)
            => BitMatrix.and(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator | (in BitMatrix32 A, in BitMatrix32 B)
            => BitMatrix.or(A, B);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator ^ (in BitMatrix32 A, in BitMatrix32 B)
            => BitMatrixA.xor(A, B);

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
            => this.Data = src;

        [MethodImpl(Inline)]
        internal BitMatrix32(bit fill)
        {
            this.Data = new uint[N];
            if(fill)
                Data.Fill(uint.MaxValue);
        }

        /// <summary>
        /// The underlying matrix data
        /// </summary>
        public Span<uint> Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        /// <summary>
        /// The underlying matrix presented as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Data.AsBytes();
        }

        /// <summary>
        /// A reference to the first row of the matrix
        /// </summary>
        public unsafe ref uint Head
        {
            [MethodImpl(Inline)] 
            get => ref head(Data);
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
        /// Queries/manipulates a bit in an identified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => bit.test(Data[row], col);

            [MethodImpl(Inline)]
            set =>  Data[row] = bit.set(Data[row], (byte)col, value);
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
        public bool Equals(BitMatrix32  src)
            => BitMatrix.same(this, src);

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
        
        public override string ToString()
            => throw new NotSupportedException();
    }
}