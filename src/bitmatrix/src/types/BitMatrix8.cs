//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines an 8x8 matrix of bits
    /// </summary>
    [IdentityProvider(typeof(BitMatrixIdentityProvider))]
    public readonly ref struct BitMatrix8
    {
        internal readonly Span<byte> Data;

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
        public static BitMatrix8 Ones => new BitMatrix8(0xFFFFFFFFFFFFFFFF);

        [MethodImpl(Inline)]
        public static implicit operator BitMatrix<byte>(BitMatrix8 src)
            => BitMatrix.load(src.Data);

        [MethodImpl(Inline)]
        public static explicit operator ulong(BitMatrix8 src)
            => BitSeq.u64(src.Data);

        [MethodImpl(Inline)]
        public static explicit operator BitMatrix8(ulong src)
            => new BitMatrix8(src);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator & (in BitMatrix8 A, in BitMatrix8 B)
            =>  BitMatrix.and(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator | (in BitMatrix8 A, in BitMatrix8 B)
            => BitMatrix.or(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator ^ (in BitMatrix8 A, in BitMatrix8 B)
            => BitMatrixA.xor(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator ~ (in BitMatrix8 src)
            => BitMatrix.not(src);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator - (in BitMatrix8 A, in BitMatrix8 B)
            => BitMatrix.xornot(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator * (in BitMatrix8 A, in BitMatrix8 B)
            => BitMatrix.mul(A,B);

        [MethodImpl(Inline)]
        public static BitVector8 operator * (in BitMatrix8 A, in BitVector8 x)
            => BitMatrix.mul(A,x);

        [MethodImpl(Inline)]
        public static bool operator ==(in BitMatrix8 A, in BitMatrix8 B)
            => A.Equals(B);

        [MethodImpl(Inline)]
        public static bool operator !=(in BitMatrix8 A, in BitMatrix8 B)
            => !(A.Equals(B));

        [MethodImpl(Inline)]
        internal BitMatrix8(Span<byte> src)
            => this.Data = src;

        [MethodImpl(Inline)]
        internal BitMatrix8(ulong src)
            => this.Data = z.bytes(src).Replicate();

        public ReadOnlySpan<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        /// <summary>
        /// A reference to the first row of the matrix
        /// </summary>
        public unsafe ref byte Head
        {
            [MethodImpl(Inline)]
            get => ref first(Data);
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
        /// Reads/manipulates the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        /// <param name="src">The source value</param>
        public Bit32 this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => Bit32.test(skip(in Head,row), col);

            [MethodImpl(Inline)]
            set => seek(Head, row) = Bit32.set(seek(Head, row), (byte)col, value);
        }

        /// <summary>
        /// Gets/Sets the data for a row
        /// </summary>
        /// <param name="index">The row index</param>
        public ref BitVector8 this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Unsafe.As<byte,BitVector8>(ref seek(Head, index));
        }

        [MethodImpl(Inline)]
        public BitVector8 Col(int index)
            => BitVector.create(n8, BitMasks.gather((ulong)this, (C0 << index)));

        const ulong C0 =
            (1ul << 64 - 1*8) | (1ul << 64 - 2*8) | (1ul << 64 - 3*8) | (1ul << 64 - 4*8) |
            (1ul << 64 - 5*8) | (1ul << 64 - 6*8) | (1ul << 64 - 7*8) | 1;

        public override string ToString()
            => this.Format();

        [MethodImpl(Inline)]
        public readonly bool Equals(BitMatrix8 src)
            => BitMatrix.same(this, src);

        [MethodImpl(Inline)]

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}