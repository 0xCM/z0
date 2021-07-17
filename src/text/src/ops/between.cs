//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    partial class text
    {
        [Op]
        public static ReadOnlySpan<char> between(ReadOnlySpan<char> src, char c0, char c1)
        {
            var i0 = index(src, c0);
            if(i0 > 0)
            {
                var i1 = index(src, i0 + 1, c1);
                if(i1 > 0)
                    return core.segment(src, i0 + 1, i1 - 1);
            }
            return default;
        }
    }
}