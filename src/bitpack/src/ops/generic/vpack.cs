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

    partial class BitPack
    {
        /// <summary>
        /// Packs 16 1-bit values taken from each source byte at a specified index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="index">The byte-relative index from which the bit will be extracted, an integer in the range [0,7]</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ushort vpack<T>(Vector128<T> src, byte index)
            where T : unmanaged
                => gvec.vtakemask(src,index);

        /// <summary>
        /// Packs 32 1-bit values taken from each source byte at a specified index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="index">The byte-relative index from which the bit will be extracted, an integer in the range [0,7]</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static uint vpack<T>(Vector256<T> src, byte index)
            where T : unmanaged
                => gvec.vtakemask(src,index);
    }
}