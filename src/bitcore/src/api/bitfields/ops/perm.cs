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
    using static memory;
    using static BitMasks.Literals;

    readonly partial struct BitFields
    {
        /// <summary>
        /// Creates a fixed 16-bit permutation over a generic permutation over 16 elements
        /// </summary>
        /// <param name="src">The source permutation</param>
        [MethodImpl(Inline), Op]
        public static Perm16 perm16(W128 w, Perm<byte> spec)
            => new Perm16(gcpu.vload(w128, spec.Terms));

        /// <summary>
        /// Creates a fixed 32-bit permutation over a generic permutation over 32 elements
        /// </summary>
        /// <param name="src">The source permutation</param>
        [MethodImpl(Inline), Op]
        public static Perm32 perm32(W256 w, Perm<byte> src)
            => new Perm32(gcpu.vload(w, src.Terms));

        [MethodImpl(Inline), Op]
        public static Perm16 perm16(Vector128<byte> data)
            => new Perm16(cpu.vand(data, cpu.vbroadcast(w128, Msb8x8x3)));

        [MethodImpl(Inline), Op]
        public static Perm32 perm32(Vector256<byte> data)
            => new Perm32(cpu.vand(data, cpu.vbroadcast(w256, Msb8x8x3)));
    }
}