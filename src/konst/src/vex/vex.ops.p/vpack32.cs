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
        /// Packs 32 1-bit values taken from each source byte at a specified index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="index">The byte-relative index from which the bit will be extracted, an integer in the range [0,7]</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint vpack32<T>(Vector256<T> src, byte index)
            where T : unmanaged
                => vtakemask(src, index);
    }
}