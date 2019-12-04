//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static class BitMatrix16x
    {   
        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitCells<N256,ushort> ToCells(this BitMatrix16 A)
            => BitCells.load(A.Data, n256);

        /// <summary>
        /// Creates the matrix determined by a permutation
        /// </summary>
        /// <param name="perm">The source permutation</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 ToBitMatrix(this NatPerm<N16> perm)
        {
            var dst = BitMatrix16.Alloc();
            for(var row = 0; row<perm.Length; row++)
                dst[row,perm[row]] = Bit.On;
            return dst;
        }


        /// <summary>
        /// Creates a generic matrix from the primal source data
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<ushort> ToGeneric(this BitMatrix16 A)
            => new BitMatrix<ushort>(A.Data);

        /// <summary>
        /// Converts the source matrix to a square matrix of natural order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N16,ushort> ToNatural(this BitMatrix16 A)
            => BitMatrix.load(n16,A.Data);

        /// <summary>
        /// Converts the source matrix to a square matrix of natural order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N16,ushort> ToNatural(this BitMatrix<ushort> A)
            => BitMatrix.load(n16,A.Data);

        /// <summary>
        /// Determines whether this matrix is equivalent to the canonical 0 matrix
        /// </summary>
        [MethodImpl(Inline)] 
        public static bit IsZero(this BitMatrix16 A)
            => BitMatrix.empty(A);

        /// <summary>
        /// Constructs an 8-node graph via the adjacency matrix interpretation
        /// </summary>
        [MethodImpl(Inline)] 
        public static Graph<byte> ToGraph(this BitMatrix16 A)
            => BitMatrix.graph(A);

        /// <summary>
        /// Transposes a copy of the source matrix
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix16 Transpose(this BitMatrix16 A)
            => BitMatrix.transpose(A);

        [MethodImpl(Inline)]
        public static BitMatrix16 AndNot(this BitMatrix16 A, in BitMatrix16 B)
            => BitMatrix.cnotimply(A, B);

    }

}