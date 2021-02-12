//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static BitMasks.Literals;
    using static memory;
    using static Part;

    partial struct gpack
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T pack<T>(ReadOnlySpan<byte> src, out T dst, uint offset = 0)
            where T : unmanaged
        {
            dst = default;
            var buffer = bytes(dst);
            BitPack.pack(src, offset, ref first(buffer));
            return ref dst;
        }
    }
}