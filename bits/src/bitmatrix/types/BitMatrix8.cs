//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static As;

    using static zfunc;
 
    /// <summary>
    /// Defines an 8x8 matrix of bits
    /// </summary>
    public readonly ref struct BitMatrix8
    {        
        internal readonly Span<byte> data;
                                        
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
        public static BitMatrix8 operator & (in BitMatrix8 A, in BitMatrix8 B)
            =>  BitMatrix.and(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator | (in BitMatrix8 A, in BitMatrix8 B)
            => BitMatrix.or(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator ^ (in BitMatrix8 A, in BitMatrix8 B)
            => BitMatrix.xor(A,B);

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
        public static explicit operator ulong(BitMatrix8 src)
            => BitConvert.ToUInt64(src.data);

        [MethodImpl(Inline)]
        public static explicit operator BitMatrix8(ulong src)
            => new BitMatrix8(src);

        [MethodImpl(Inline)]
        internal BitMatrix8(Span<byte> src)
        {
            this.data = src;
        }

        [MethodImpl(Inline)]
        internal BitMatrix8(ulong src)
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

        public ReadOnlySpan<byte> Bytes
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
        /// Reads/manipulates the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        /// <param name="src">The source value</param>
        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => BitMask.test(skip(in Head,row), col);

            [MethodImpl(Inline)]
            set => seek(ref Head, row) = BitMask.set(seek(ref Head, row), (byte)col, value);
        }            

        /// <summary>
        /// Gets/Sets the data for a row
        /// </summary>
        /// <param name="index">The row index</param>
        public ref BitVector8 this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Row(index);
        }

        [MethodImpl(Inline)]
        public BitVector8 Col(int index)
            => BitVector.from(n8, Bits.gather((ulong)this, (C0 << index)));

        // C0 =           [00000001 00000001 ... 00000001]
        // C1 = C0 << 1 = [00000010 00000010 ... 00000010]
        // C2 = C0 << 2 = [00000100 00000100 ... 00000100]
        // ...
        // C7 = C0 << 7 = [10000000 10000000 ... 10000000]
        const ulong C0 = 
            (1ul << 64 - 1*8) | (1ul << 64 - 2*8) | (1ul << 64 - 3*8) | (1ul << 64 - 4*8) | 
            (1ul << 64 - 5*8) | (1ul << 64 - 6*8) | (1ul << 64 - 7*8) | 1;

        /// <summary>
        /// Presents the data at a specified offset as a bitvector
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref BitVector8 Row(int row)
            => ref Unsafe.As<byte,BitVector8>(ref seek(ref Head, row));

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