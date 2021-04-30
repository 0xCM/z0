//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        [MethodImpl(Inline), Op]
        public static MemoryRange range(MemoryAddress min, MemoryAddress max)
            => new MemoryRange(min, max);

        [MethodImpl(Inline), Op]
        public static MemoryRange range(MemoryAddress min, ByteSize size)
            => new MemoryRange(min, size);
    }
}