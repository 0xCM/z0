//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    partial class Perms
    {
        /// <summary>
        /// Creates a generic permutation by application of a sequence of transpositions to the identity permutation
        /// </summary>
        /// <param name="n">The permutation length</param>
        /// <param name="swaps">Pairs of permutation indices (i,j) to be transposed</param>
        /// <typeparam name="T">The integral type</typeparam>
        [MethodImpl(Inline)]
        public static Perm<T> build<T>(T n, params (T i, T j)[] swaps)
            where T : unmanaged
                => new Perm<T>(n,swaps);

        /// <summary>
        /// Creates a generic permutation by application of a sequence of transpositions to the identity permutation
        /// </summary>
        /// <param name="n">The permutation length</param>
        /// <param name="swaps">Pairs of permutation indices (i,j) to be transposed</param>
        /// <typeparam name="T">The integral type</typeparam>
        [MethodImpl(Inline)]
        public static Perm<T> build<T>(T n, params Swap<T>[] swaps)
            where T : unmanaged
                => new Perm<T>(n,swaps);


    }

}