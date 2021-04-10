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
        public static MemoryPage page(MemoryRange range, ushort size = PageSize)
            => new MemoryPage(range, memory.alloc<byte>(size));

        [MethodImpl(Inline), Op]
        public static MemoryPage page(MemoryRange range, Index<byte> content)
            => new MemoryPage(range, content);
    }
}