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

    }

}