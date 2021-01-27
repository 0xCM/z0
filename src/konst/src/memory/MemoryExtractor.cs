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

    public readonly struct MemoryExtractor
    {
        public void ExtractPages(MemoryRange src, Span<MemoryPage> dst)
        {
            var pages = root.min((uint)(src.Size/PageSize), dst.Length);
            var reader = memory.reader<byte>(src);
            var offset = 0ul;
            for(var i=0; i<pages; i++)
            {
                ref var page = ref seek(dst,i);
                var size = reader.Read((int)offset, PageSize, page.Edit);
                offset += PageSize;

                if(size < PageSize || offset >= src.Size)
                    break;
            }
        }
    }
}