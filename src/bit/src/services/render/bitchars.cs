//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct BitRender
    {
        [MethodImpl(Inline), Op]
        public static byte bitchars(byte src, byte offset, out char hi, out char lo)
        {
            hi = bitchar(src, offset);
            lo = bitchar(src, Bytes.sub(offset, 1));
            return 2;
        }
    }
}