//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    partial class text
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

        [Op]
        public static int index(string src, char match)
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