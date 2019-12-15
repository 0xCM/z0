//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class BitMatrix
    {
        /// <summary>
        /// Permutes the rows of a matrix in-place according to a permutation
        /// </summary>
        /// <param name="spec">The permutation definition</param>
        /// <param name="A">The matrix to be permuted</param>
        public static ref readonly BitMatrix<T> permute<T>(PermSpec spec, in BitMatrix<T> A)
            where T : unmanaged
        {
            for(var row = 0; row < spec.Length; row++)
                if(spec[row] != row)
                    A.RowSwap(row, spec[row]);
            return ref A;
        }

        /// <summary>
        /// Permutes the rows of a matrix in-place according to a permutation
        /// </summary>
        /// <param name="perm">The permutation to apply</param>
        /// <param name="A">The matrix to be permuted</param>
        public static ref readonly BitMatrix8 permute(in NatPerm<N8> perm, in BitMatrix8 A)
        {
            for(var row = 0; row < perm.Length; row++)
                if(perm[row] != row)
                    A.RowSwap(row, perm[row]);
            return ref A;
        }

        /// <summary>
        /// Permutes the rows of a matrix in-place according to a specified permutation
        /// </summary>
        /// <param name="perm">The permutation to apply</param>
        /// <param name="A">The matrix to be permuted</param>
        public static ref readonly BitMatrix16 permute(in NatPerm<N16> perm, in BitMatrix16 A)
        {
            for(var row = 0; row < perm.Length; row++)
                if(perm[row] != row)
                    A.RowSwap(row, perm[row]);
            return ref A;
        }

        /// <summary>
        /// Permutes the rows of a matrix in-place according to a permutation
        /// </summary>
        /// <param name="perm">The permutation definition</param>
        /// <param name="A">The source/target matrix</param>
        public static ref readonly BitMatrix32 permute(in NatPerm<N32> perm, in BitMatrix32 A)
        {
            for(var row = 0; row < perm.Length; row++)
                if(perm[row] != row)
                    rowswap(A, row, perm[row]);
            return ref A;
        }

        /// <summary>
        /// Permutes the rows of a matrix in-place according to a permutation
        /// </summary>
        /// <param name="perm">The permutation definition</param>
        /// <param name="A">The source/target matrix</param>
        public static ref readonly BitMatrix64 permute(in NatPerm<N64> perm, in BitMatrix64 A)
        {
            for(var row = 0; row < perm.Length; row++)
                if(perm[row] != row)
                    A.RowSwap(row, perm[row]);
            return ref A;
        }

        /// <summary>
        /// Derives a 4x4 bitmatrix from a permutation of length 4
        /// </summary>
        /// <param name="spec">The permutaton spec</param>
        /// <remarks>
        /// Example:
        /// Permutation: [11 10 00 01] (ABCD -> BACD)
        /// Bitmatrix: [1000 | 0000 | 0100 | 1100]
        /// </remarks>
        public static BitMatrix4 permencode(Perm4 spec)
        {
            var digits = spec.ToDigits();
            var rows = new BitVector4[4];
            for(var i=0; i<digits.Length; i++)
                rows[i] = BitVector.from(n4, digits[i]);
            return primal(n4, rows);
        }
        
        /// <summary>
        /// Creates a canonical permutation matrix by swapping matrix rows of the identity matrix as specified by a permutation
        /// </summary>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static BitMatrix64 permute(NatPerm<N64> spec)
            => permute(spec, identity(n64));


    }
}