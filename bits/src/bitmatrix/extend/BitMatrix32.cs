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

    public static class BitMatrix32x
    {   

        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector<N1024,uint> ToBitVector(this BitMatrix32 A)
            => BitVector.natural(A.Data, n1024);


        /// <summary>
        /// Creates the matrix determined by a permutation
        /// </summary>
        /// <param name="src">The source permutation</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 ToBitMatrix(this Perm<N32> perm)
        {
            var dst = BitMatrix.alloc(n32);
            for(var row = 0; row<perm.Length; row++)
                dst[row,perm[row]] = Bit.On;
            return dst;
        }

        /// <summary>
        /// Creates a generic matrix from the primal source data
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<uint> ToGeneric(this BitMatrix32 A)
            => new BitMatrix<uint>(A.Data);

        /// <summary>
        /// Converts the source matrix to a square matrix of natural order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N32,uint> ToNatural(this BitMatrix32 A)
            => BitMatrix.load(n32,A.Data);

        /// <summary>
        /// Converts the source matrix to a square matrix of natural order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N32,uint> ToNatural(this BitMatrix<uint> A)
            => BitMatrix.load(n32,A.Data);

        [MethodImpl(Inline)]
        internal static string FormatMatrixBits(this uint[] src, int rowlen)            
            => src.AsSpan().AsBytes().FormatMatrixBits(rowlen);

        [MethodImpl(Inline)]
        public static BitMatrix32 AndNot(this BitMatrix32 A, in BitMatrix32 B)
            => BitMatrix.cnotimply(A, B);


        /// <summary>
        /// Determines whether this matrix is equivalent to the canonical 0 matrix
        /// </summary>
        [MethodImpl(Inline)] 
        public static bit IsZero(this BitMatrix32 A)
            => BitMatrix.empty(A);

        /// <summary>
        /// Constructs an 8-node graph via the adjacency matrix interpretation
        /// </summary>
        public static Graph<byte> ToGraph(this BitMatrix32 A)
            => BitMatrix.graph(A);


    }

}