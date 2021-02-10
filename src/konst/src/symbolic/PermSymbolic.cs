//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static PermLits;

    [ApiHost(ApiNames.PermSymbolic, true)]
    public readonly partial struct PermSymbolic
    {
        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec as
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> digits(Perm16 spec)
            => cpu.vshuf16x8(gcpu.vinc<byte>(n128), spec.data);

        /// <summary>
        /// Computes the digits corresponding to each 5-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> digits(Perm32 spec)
            => cpu.vshuf32x8(gcpu.vinc<byte>(n256),spec.Data);

        [MethodImpl(Inline), Op]
        public static Perm8L permid(N8 n)
            => Perm8Identity;

        [MethodImpl(Inline), Op]
        public static Perm16L permid(N16 n)
            => Perm16Identity;
    }
}