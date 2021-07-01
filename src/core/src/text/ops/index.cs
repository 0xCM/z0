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