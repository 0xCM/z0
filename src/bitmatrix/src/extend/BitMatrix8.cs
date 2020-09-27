//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    public static class BitMatrix8x
    {
        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this BitMatrix8 A)
            => BitVector.create(n64,(ulong)A);

        /// <summary>
        /// Creates a generic matrix from the primal source data
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<byte> ToGeneric(this BitMatrix8 A)
            => new BitMatrix<byte>(A.Data);

        /// <summary>
        /// Creates the matrix determined by a permutation
        /// </summary>
        /// <param name="perm">The source permutation</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 ToBitMatrix(this NatPerm<N8> perm)
        {
            var dst = BitMatrix.alloc(n8);
            for(var row = 0; row<perm.Length; row++)
                dst[row, perm[row]] = Bit32.On;
            return dst;
        }

        /// <summary>
        /// Converts the source matrix to a square matrix of natural order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N8,byte> ToNatural(this BitMatrix8 A)
            => BitMatrix.load(n8,A.Data);

        /// <summary>
        /// Converts the source matrix to a square matrix of natural order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N8,byte> ToNatural(this BitMatrix<byte> A)
            => BitMatrix.load(n8,A.Bytes);

        [MethodImpl(Inline)]
        public static string Format(this BitMatrix8 src)
            => src.Data.FormatMatrixBits(src.Order);

        /// <summary>
        /// Determines whether this matrix is equivalent to the canonical 0 matrix
        /// </summary>
        [MethodImpl(Inline)]
        public static Bit32 IsZero(this BitMatrix8 A)
            => BitMatrix.empty(A);

        /// <summary>
        /// Constructs an 8-node graph via the adjacency matrix interpretation
        /// </summary>
        [MethodImpl(Inline)]
        public static Graph<byte> ToGraph(this BitMatrix8 A)
            => BitMatrix.graph(A);

        /// <summary>
        /// Packs the matrix into an unsigned 64-bit integer
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong Pack(this BitMatrix8 A)
            => Sized.u64(A.Data);

        /// <summary>
        /// Transposes a copy of the source matrix
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix8 Transpose(this BitMatrix8 A)
            => BitMatrix.transpose_v2(A);

        [MethodImpl(Inline)]
        public static BitMatrix8 AndNot(this BitMatrix8 A, in BitMatrix8 B)
            => BitMatrix.cnonimpl(A, B);

        /// <summary>
        /// Retrives the bitvector determined by the matrix diagonal
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector8 Diagonal(this BitMatrix8 A)
            => BitMatrix.diagonal(A);

        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 32
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public static void RowSwap(this BitMatrix8 A, int i, int j)
            => A.Data.Swap((uint)i,(uint)j);

        [MethodImpl(Inline)]
        public static BitMatrix8 ToPrimalBits(this ulong src, N8 n = default)
            => BitMatrix.primal(n, src);

        /// <summary>
        /// Creates a new matrix by cloning the existing matrix or allocating a matrix with the same structure
        /// </summary>
        /// <param name="structureOnly">Specifies whether the replication reproduces only structure and is thus equivalent to an allocation</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 Replicate(this BitMatrix8 A)
            => BitMatrix.primal(n8, A.Bytes.Replicate());
    }
}