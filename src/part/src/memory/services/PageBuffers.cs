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

    [ApiHost]
    public readonly struct PageBuffers
    {
        [Op]
        public void read(MemoryRange src, Span<PageBuffer> dst)
        {
            const ushort PageSize = PageBuffer.Size;
            var count = root.min((uint)(src.Size/PageSize), dst.Length);
            var reader = MemoryReader.create<byte>(src);
            var offset = 0ul;
            for(var i=0; i<count; i++)
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