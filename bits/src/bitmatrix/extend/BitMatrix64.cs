//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static class BitMatrix64x
    {   
        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitBlock<N4096,ulong> ToBitVector(this BitMatrix64 A)
            => BitBlocks.load(A.Data, n4096);

        /// <summary>
        /// Creates the matrix determined by a permutation
        /// </summary>
        /// <param name="perm">The source permutation</param>
        [MethodImpl(Inline)]
        public static BitMatrix64 ToBitMatrix(this NatPerm<N64> perm)            
        {
            var dst = BitMatrix.alloc(n64);
            for(var row = 0; row<perm.Length; row++)
                dst[row,perm[row]] = bit.On;
            return dst;
        }

        /// <summary>
        /// Creates a generic matrix from the primal source data
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<ulong> ToGeneric(this BitMatrix64 A)
            => new BitMatrix<ulong>(A.Data);

        /// <summary>
        /// Converts the source matrix to a square matrix of natural order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N64,ulong> ToNatural(this BitMatrix64 A)
            => BitMatrix.load(n64,A.Data);

        /// <summary>
        /// Converts the source matrix to a square matrix of natural order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N64,ulong> ToNatural(this BitMatrix<ulong> A)
            => BitMatrix.load(n64,A.Data);

        [MethodImpl(Inline)]
        public static string Format(this BitMatrix64 src)            
            => src.Data.FormatMatrixBits(src.Order);        
    
        /// <summary>
        /// Determines whether this matrix is equivalent to the canonical 0 matrix
        /// </summary>
        [MethodImpl(Inline)] 
        public static bit IsZero(this BitMatrix64 A)
            => BitMatrix.empty(A);


        [MethodImpl(Inline)]
        public static BitMatrix64 AndNot(this BitMatrix64 A, in BitMatrix64 B)
            => BitMatrix.cnonimpl(A, B);
    }

}