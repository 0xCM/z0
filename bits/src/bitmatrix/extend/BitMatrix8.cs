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
        public static BitVector64 ToBitvector(this BitMatrix8 A)
            => A.Data.AsUInt64()[0];

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
        /// Creates a generic matrix from the primal source data
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<byte> ToGeneric(this BitMatrix8 A)
            => new BitMatrix<byte>(A.Data);

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
            => BitMatrix.load(n8,A.Data);

        [MethodImpl(Inline)]
        public static string Format(this BitMatrix8 src)            
            => src.Bytes.FormatMatrixBits(src.RowCount);

        /// <summary>
        /// Determines whether this matrix is equivalent to the canonical 0 matrix
        /// </summary>
        [MethodImpl(Inline)] 
        public static bit IsZero(this BitMatrix8 A)
            => BitMatrix.empty(A);

        /// <summary>
        /// Constructs an 8-node graph via the adjacency matrix interpretation
        /// </summary>
        public static Graph<byte> ToGraph(this BitMatrix8 A)
            => BitGraph.graph(A);
    }

}