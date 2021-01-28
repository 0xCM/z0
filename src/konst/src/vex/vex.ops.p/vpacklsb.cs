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

    partial struct gcpu
    {
        /// <summary>
        /// Packs 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort vpacklsb<T>(Vector128<T> src)
            where T : unmanaged
                => vpack16(src, 0);

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint vpacklsb<T>(Vector256<T> src)
            where T : unmanaged
                => vpack32(src, 0);
    }
}