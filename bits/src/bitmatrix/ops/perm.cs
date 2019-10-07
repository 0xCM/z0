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
        /// Applies a permutation to a target matrix by premultiplying the target with
        /// the permutation matrix implied by the defined permutation
        /// </summary>
        /// <param name="spec">The permutation definition</param>
        public static ref BitMatrix8 apply(Perm<N8> spec, ref BitMatrix8 A)
        {
            var P = spec.ToBitMatrix();
            A = P * A;
            return ref A;
        }

        /// <summary>
        /// Applies a permutation to a target matrix by premultiplying the target with
        /// the permutation matrix implied by the defined permutation
        /// </summary>
        /// <param name="spec">The permutation definition</param>
        /// <param name="A">The target matrix</param>
        public static BitMatrix8 apply(Perm<N8> spec, BitMatrix8 A)
        {
            var P = spec.ToBitMatrix();
            A = P * A;
            return A;
        }


        /// <summary>
        /// Applies a permutation to a target matrix by swapping the rows
        /// according to permutation transpositions
        /// </summary>
        /// <param name="spec">The permutation definition</param>
        public static ref BitMatrix16 apply(Perm<N16> spec, ref BitMatrix16 dst)
        {
            var copy = dst.Replicate();                
            for(var row = 0; row<spec.Length; row++)
            {
                var i = row;
                var j = spec[i];
                if(i != j)
                    dst[i] = copy[j];
            }
            return ref dst;
        }

        /// <summary>
        /// Applies a permutation to a target matrix by premultiplying the target with
        /// the permutation matrix implied by the defined permutation
        /// </summary>
        /// <param name="spec">The permutation definition</param>
        /// <param name="A">The target matrix</param>
        public static BitMatrix16 apply(Perm<N16> spec, BitMatrix16 A)
        {
            var P = spec.ToBitMatrix();
            A = P * A;
            return A;
        }


        /// <summary>
        /// Applies a permutation to a target matrix by swapping the rows
        /// according to permutation transpositions
        /// </summary>
        /// <param name="spec">The permutation definition</param>
        public static ref BitMatrix32 apply(Perm<N32> spec, ref BitMatrix32 dst)
        {
            for(var row = 0; row<spec.Length; row++)
                if(spec[row] != row)
                    dst.RowSwap(row, spec[row]);
            return ref dst;
        }

        /// <summary>
        /// Applies a permutation to a target matrix by premultiplying the target with
        /// the permutation matrix implied by the defined permutation
        /// </summary>
        /// <param name="spec">The permutation definition</param>
        /// <param name="A">The target matrix</param>
        public static BitMatrix32 apply(Perm<N32> spec, BitMatrix32 A)
        {
            var P = spec.ToBitMatrix();
            A = P * A;
            return A;
        }
 
        /// <summary>
        /// Applies a permutation to a target matrix by swapping the rows
        /// according to permutation transpositions
        /// </summary>
        /// <param name="spec">The permutation definition</param>
        public static ref BitMatrix64 apply(Perm<N64> spec, ref BitMatrix64 dst)
        {
            for(var row = 0; row<spec.Length; row++)
                if(spec[row] != row)
                    dst.RowSwap(row, spec[row]);
            return ref dst;
        }

        /// <summary>
        /// Applies a permutation to a target matrix by premultiplying the target with
        /// the permutation matrix implied by the defined permutation
        /// </summary>
        /// <param name="spec">The permutation definition</param>
        /// <param name="A">The target matrix</param>
        public static BitMatrix64 apply(Perm<N64> spec, BitMatrix64 A)
        {
            var P = spec.ToBitMatrix();
            A = P * A;
            return A;
        }

        /// <summary>
        /// Creates a canonical permutation matrix by swapping matrix rows of
        /// the identity matrix as specified by a permutation
        /// </summary>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static BitMatrix64 perm(Perm<N64> spec)
        {
            var id = BitMatrix64.Identity;
            apply(spec, ref id);
            return id;
        }
    }
}