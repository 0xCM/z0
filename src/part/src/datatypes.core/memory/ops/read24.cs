//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        [MethodImpl(Inline), Op]
        public static uint read24(ReadOnlySpan<byte> src, int offset)
        {
            var dst = z32;
            dst = ((uint)read16(src,offset)) << 24;
            dst |= skip(src,offset + 2);
            return dst;
        }
    }
}