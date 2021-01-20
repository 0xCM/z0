//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Defines a 16x16 matrix of bits
    /// </summary>
    [IdentityProvider(typeof(BitMatrixIdentityProvider))]
    public readonly ref struct BitMatrix16
    {
        internal readonly Span<ushort> Data;

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
        /// Allocates a matrix with a fill value
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix16 Alloc(Bit32 fill)
            => new BitMatrix16(fill);

        [MethodImpl(Inline)]
        public static BitMatrix16 From(ushort[] src)
            => new BitMatrix16(src);

        [MethodImpl(Inline)]
        internal BitMatrix16(Span<ushort> src)
            => this.Data = src;

        internal BitMatrix16(Bit32 fill)
        {
            this.Data = new ushort[N];
            if(fill)
                Data.Fill(ushort.MaxValue);
        }

        /// <summary>
        /// The underlying matrix presented as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Data.Bytes();
        }

        /// <summary>
        /// The underlying matrix data
        /// </summary>
        public Span<ushort> Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        /// <summary>
        /// A reference to the first row of the matrix
        /// </summary>
        public ref ushort Head
        {
            [MethodImpl(Inline)]
            get => ref first(Data);
        }

        public readonly int Order
        {
            [MethodImpl(Inline)]
            get => (int)N;
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
            get => BitStates.test(skip(in Head, row), (byte)col);

            [MethodImpl(Inline)]
            set => seek(Head, row) = BitStates.set(seek(Head, row), (byte)col, value);
        }

        /// <summary>
        /// Gets/sets an identified row
        /// </summary>
        /// <param name="row">The row index</param>
        public ref BitVector16 this[int row]
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.As<ushort,BitVector16>(ref seek(Head, row));
        }

        [MethodImpl(Inline)]
        public readonly BitVector16 Col(int index)
        {
            ushort col = 0;
            for(byte r = 0; r<N; r++)
                col = Bits.setif(Data[r], (byte)index, col, r);
            return col;
        }

        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 16
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public void RowSwap(int i, int j)
            => Data.Swap((uint)i,(uint)j);

        public readonly BitMatrix16 Transpose()
        {
            var dst = Replicate();
            for(var i=0; i<N; i++)
                dst.Data[i] = Col(i);
            return dst;
        }

        public readonly BitMatrix16 Replicate()
            => From(Data.ToArray());

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

        [MethodImpl(Inline)]
        public static implicit operator BitMatrix<ushort>(in BitMatrix16 src)
            => BitMatrix.load(src.Data);

        /// <summary>
        /// Computes the bitwise and of the operands
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix16 operator & (in BitMatrix16 A, in BitMatrix16 B)
            => BitMatrix.and(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator | (in BitMatrix16 A, in BitMatrix16 B)
            => BitMatrix.or(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator ^ (in BitMatrix16 A, in BitMatrix16 B)
            => BitMatrixA.xor(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator ~ (in BitMatrix16 A)
            => BitMatrix.not(A);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator - (in BitMatrix16 A, in BitMatrix16 B)
            => BitMatrix.xornot(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator * (in BitMatrix16 A, in BitMatrix16 B)
            => BitMatrix.mul(A, B);

        [MethodImpl(Inline)]
        public static BitVector16 operator * (in BitMatrix16 A, in BitVector16 B)
            => BitMatrix.mul(A, B);

        [MethodImpl(Inline)]
        public static Bit32 operator ==(in BitMatrix16 A, in BitMatrix16 B)
            => BitMatrix.same(A,B);

        [MethodImpl(Inline)]
        public static Bit32 operator !=(in BitMatrix16 A, in BitMatrix16 B)
            => !BitMatrix.same(A,B);
   }
}