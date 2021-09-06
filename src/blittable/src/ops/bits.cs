//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Blit
    {
        partial struct Operate
        {
            [MethodImpl(Inline), Op]
            public static uint bits(uint width, ulong src, Span<bit> dst)
            {
                var input = src;
                var storage = 0ul;
                var count = (uint)min(width, dst.Length);
                for(byte i=0; i<count; i++)
                    seek(dst,i) = bit.test(input,i);
                return count;
            }
        }
    }
}