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

    [ApiHost]
    public readonly struct TextBlocks
    {
        [Op]
        public Index<TextBlock> blocks(Span<string> src)
        {
            var count = src.Length;
            var buffer = alloc<TextBlock>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = skip(src,i);
            return buffer;
        }
    }
}