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

    partial struct TextTools
    {
        [MethodImpl(Inline), Op]
        public static uint render(StringAddress src, ref uint i, Span<char> dst)
        {
            var i0=i;
            ref var c = ref firstchar(src);
            var j=0u;
            while(c != 0)
                seek(dst, i++) = skip(c, j++);
            return j-1;
        }
    }
}