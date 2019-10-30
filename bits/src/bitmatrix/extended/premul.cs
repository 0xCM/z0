//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {

        /// <summary>
        /// Permutes the rows of a target matrix via premultiplication by a permutation-identified permutation matrix 
        /// </summary>
        /// <param name="spec">The permutation definition</param>
        public static ref BitMatrix8 premul(Perm<N8> spec, ref BitMatrix8 A)
        {
            var P = spec.ToBitMatrix();
            A = P * A;
            return ref A;
        }

        /// <summary>
        /// Permutes the rows of a target matrix via premultiplication by a permutation-identified permutation matrix 
        /// </summary>
        /// <param name="spec">The permutation definition</param>
        /// <param name="A">The target matrix</param>
        public static BitMatrix16 premul(Perm<N16> spec, BitMatrix16 A)
        {
            var P = spec.ToBitMatrix();
            A = P * A;
            return A;
        }

        // <summary>
        /// Permutes the rows of a target matrix via premultiplication by a permutation-identified permutation matrix 
        /// </summary>
        /// <param name="spec">The permutation definition</param>
        /// <param name="A">The target matrix</param>
        public static BitMatrix32 premul(Perm<N32> spec, BitMatrix32 A)
        {
            var P = spec.ToBitMatrix();
            A = P * A;
            return A;
        }
 
        /// <summary>
        /// Permutes the rows of a target matrix via premultiplication by a permutation-identified permutation matrix 
        /// </summary>
        /// <param name="spec">The permutation definition</param>
        /// <param name="A">The target matrix</param>
        public static BitMatrix64 premul(Perm<N64> spec, BitMatrix64 A)
        {
            var P = spec.ToBitMatrix();
            A = P * A;
            return A;
        }
    }
}