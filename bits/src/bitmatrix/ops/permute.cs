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
        /// Permutes the rows of a matrix in-place
        /// </summary>
        /// <param name="spec">The permutation definition</param>
        /// <param name="A">The matrix to be permuted</param>
        public static ref BitMatrix<T> permute<T>(Perm spec, ref BitMatrix<T> A)
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
        public static ref BitMatrix8 permute(in Perm<N8> perm, ref BitMatrix8 A)
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
        public static ref BitMatrix16 permute(in Perm<N16> perm, ref BitMatrix16 A)
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
        public static ref BitMatrix32 permute(in Perm<N32> perm, ref BitMatrix32 A)
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
        public static ref BitMatrix64 permute(in Perm<N64> perm, ref BitMatrix64 A)
        {
            for(var row = 0; row < perm.Length; row++)
                if(perm[row] != row)
                    A.RowSwap(row, perm[row]);
            return ref A;
        }
    }
}