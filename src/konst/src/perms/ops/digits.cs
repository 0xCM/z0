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
    using static z;

    partial struct Permutary
    {
        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec as
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> digits(Perm16 spec)
            => vshuf16x8(z.vinc<byte>(n128), spec.data);

        /// <summary>
        /// Computes the digits corresponding to each 5-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> digits(Perm32 spec)
            => vshuf32x8(z.vinc<byte>(n256),spec.data);
    }
}
