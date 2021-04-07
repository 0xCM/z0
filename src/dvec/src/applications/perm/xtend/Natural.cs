//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public static partial class PermX
    {
        /// <summary>
        /// Shuffles the permutation in-place using a provided random source.
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static ref readonly Perm<T> Shuffle<T>(this IDomainSource random, in Perm<T> src)
            where T : unmanaged
        {
            random.Shuffle(src.Terms);
            return ref src;
        }

        /// <summary>
        /// Shuffles bitstring content as determined by a permutation
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="p">The permutation to apply</param>
        public static BitString Permute(this BitString src, Perm p)
        {
            var dst = BitString.alloc(p.Length);
            for(var i = 0; i < p.Length; i++)
                dst[i] = src[p[i]];
            return dst;
        }
    }
}