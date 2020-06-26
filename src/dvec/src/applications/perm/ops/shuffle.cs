//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Root;
    using static Typed;

    partial class Permute
    {
        [MethodImpl(Inline), Op]
        public static Vector128<byte> shuffles(NatPerm<N16> src)
            => V0.vload(n128, head(As.transform<byte>(src.Terms)));

        /// <summary>
        /// Shuffles the permutation in-place using a provided random source.
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static ref readonly Perm shuffle(in Perm src, IPolyrand random)
        {
            random.Shuffle(src.Terms);
            return ref src;
        }

        /// <summary>
        /// Shuffles the permutation in-place using a provided random source.
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static ref readonly Perm<T> shuffle<T>(in Perm<T> src, IPolyrand random)
            where T : unmanaged
        {
            random.Shuffle(src.Terms);
            return ref src;
        }
    }
}