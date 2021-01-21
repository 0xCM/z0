//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct TextRules
    {
        partial struct Parse
        {
            [Op]
            public static int index(ReadOnlySpan<char> src, char match)
            {
                var count = src.Length;
                ref readonly var c = ref first(src);
                for(var i=0; i<count; i++)
                    if(skip(c, i) == match)
                        return i;
                return NotFound;
            }
        }
    }
}