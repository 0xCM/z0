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

    partial struct z
    {
        /// <summary>
        /// Packs 16 1-bit values taken from the most significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort vpackmsb<T>(Vector128<T> src)
            where T : unmanaged
                => z.vtakemask(src);

        /// <summary>
        /// Packs 32 1-bit values taken from the most significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong vpackmsb<T>(Vector256<T> src)
            where T : unmanaged
                => z.vtakemask(src);
    }
}