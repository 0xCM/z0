//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static BitMasks.Literals;
    using static BitMasks;

    partial class Bits
    {
        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static byte pack8x8x1<T>(in T src)
            where T : unmanaged
                => (byte)BitMasks.gather(force<T,ulong>(src), Lsb64x8x1);
    }
}