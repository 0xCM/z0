//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Strings
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct strings
    {
        [Op]
        public static StringBuffer labels(ReadOnlySpan<string> src, out Index<Label> index)
        {
            var count = src.Length;
            var length = strings.length(src);
            var buffer = strings.buffer(length);
            index = alloc<Label>(count);
            var offset = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(src,i);
                index[i] = buffer.StoreLabel(s,offset);
                offset += (uint)s.Length;
            }

            return buffer;
        }
    }
}