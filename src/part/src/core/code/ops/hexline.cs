//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;
    using static memory;

    partial struct CodeBlocks
    {
        [Op]
        public static string hexline(in MemorySeg src, uint index, Span<char> buffer)
        {
            var memspan = src.ToSpan();
            var count = hexchars(memspan.View, buffer);
            var content = text.format(slice(buffer,0, count));
            return string.Format(HexPackLine, memspan.BaseAddress, index, memspan.Size, content);
        }
    }
}