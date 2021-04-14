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
        public static PageBuffer page(MemoryRange range, ushort size = PageSize)
            => new PageBuffer(range, memory.alloc<byte>(size));

        [MethodImpl(Inline), Op]
        public static PageBuffer page(MemoryRange range, Index<byte> content)
            => new PageBuffer(range, content);
    }
}