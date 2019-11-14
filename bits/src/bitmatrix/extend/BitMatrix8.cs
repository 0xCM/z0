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
    using System.Diagnostics;

    using static zfunc;

    public static class BitMatrix8x
    {   

        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this BitMatrix8 A)
            => BitVector.from(n64,(ulong)A);

        /// <summary>
        /// Creates a generic matrix from the primal source data
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<byte> ToGeneric(this BitMatrix8 A)
            => new BitMatrix<byte>(A.Bytes);

        /// <summary>
        /// Creates the matrix determined by a permutation
        /// </summary>
        /// <param name="perm">The source permutation</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 ToBitMatrix(this Perm<N8> perm)
        {
            var dst = BitMatrix8.Alloc();
            for(var row = 0; row<perm.Length; row++)
                dst[row, perm[row]] = Bit.On;
            return dst;
        }

        /// <summary>
        /// Converts the source matrix to a square matrix of natural order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N8,byte> ToNatural(this BitMatrix8 A)
            => BitMatrix.load(n8,A.Bytes);

        /// <summary>
        /// Converts the source matrix to a square matrix of natural order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N8,byte> ToNatural(this BitMatrix<byte> A)
            => BitMatrix.load(n8,A.Bytes);

        [MethodImpl(Inline)]
        public static string Format(this BitMatrix8 src)            
            => src.Bytes.FormatMatrixBits(src.Order);

        /// <summary>
        /// Determines whether this matrix is equivalent to the canonical 0 matrix
        /// </summary>
        [MethodImpl(Inline)] 
        public static bit IsZero(this BitMatrix8 A)
            => BitMatrix.empty(A);

        /// <summary>
        /// Constructs an 8-node graph via the adjacency matrix interpretation
        /// </summary>
        [MethodImpl(Inline)]
        public static Graph<byte> ToGraph(this BitMatrix8 A)
            => BitGraph.graph(A);

        /// <summary>
        /// Packs the matrix into an unsigned 64-bit integer
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong Pack(this BitMatrix8 A)
            => BitConvert.ToUInt64(A.Bytes);

        /// <summary>
        /// Transposes a copy of the source matrix
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix8 Transpose(this BitMatrix8 A)
            => BitMatrix.transpose(A);
 
        /// <summary>
        /// Creates a new matrix by cloning the existing matrix or allocating a matrix with the same structure
        /// </summary>
        /// <param name="structureOnly">Specifies whether the replication reproduces only structure and is thus equivalent to an allocation</param>
        [MethodImpl(Inline)] 
        public static BitMatrix8 Replicate(this BitMatrix8 A, bool structureOnly = false)
            => structureOnly ? BitMatrix.alloc(n8) : BitMatrix.primal(n8, A.Bytes.Replicate());

    }
}