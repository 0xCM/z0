//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class BitMatrix
    {        
        /// <summary>
        /// Loads a generic bitmatrix from a rowbit sequence
        /// </summary>
        /// <param name="rows">The row content</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<T> from<T>(RowBits<T> src)
            where T : unmanaged
        {
            if(src.RowCount != bitsize<T>())
                Errors.Throw($"{bitsize<T>()} != {src.RowCount}");

            return load(src.data);                
        }

        /// <summary>
        /// Constructs a bitmatrix formed from the ordered bitvector representation of the permutation symbols
        /// </summary>
        /// <param name="n"></param>
        /// <param name="perm"></param>
        /// <remarks>
        /// Example:
        /// Permutation: [11 10 00 01] (ABCD -> BACD)
        /// Bitmatrix:
        /// 1000
        /// 0000
        /// 0100
        /// 1100
        /// </remarks>
        public static BitMatrix4 from(N4 n, Perm4 perm)
        {
            var digits = perm.Digits();
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
        public static BitMatrix64 from(Perm<N64> spec)
        {
            var id = BitMatrix64.Identity;
            permute(spec, ref id);
            return id;
        }

    }

}