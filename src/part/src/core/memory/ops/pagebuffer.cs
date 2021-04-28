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
        [Op]
        public static PageBuffer pagebuffer(MemoryRange range, ushort size = PageSize)
            => new PageBuffer(range, memory.alloc<byte>(size));

        [MethodImpl(Inline), Op]
        public static PageBuffer pagebuffer(MemoryRange range, Index<byte> data)
            => new PageBuffer(range, data);
    }
}