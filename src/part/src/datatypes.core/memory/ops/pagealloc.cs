//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        public static Index<PageBuffer> pagealloc(MemoryRange range, ushort size = PageSize)
        {
            var count = (uint)(range.Size/size);
            var buffer = alloc<PageBuffer>(count);
            ref var dst = ref first(buffer);
            var current = range.Min;
            for(var i=0; i<count; i++)
            {
                seek(buffer,i) = page((current, current + size), size);
                current += size;
            }
            return buffer;
        }
    }
}