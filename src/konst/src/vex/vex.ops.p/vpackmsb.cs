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
    using static z;

    partial struct gcpu
    {
        /// <summary>
        /// Packs 16 1-bit values taken from the most significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort vpackmsb<T>(Vector128<T> src)
            where T : unmanaged
                => vtakemask(src);

        /// <summary>
        /// Packs 32 1-bit values taken from the most significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint vpackmsb<T>(Vector256<T> src)
            where T : unmanaged
                => vtakemask(src);
    }
}