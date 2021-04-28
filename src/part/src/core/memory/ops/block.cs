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
        public static MemoryBlock block(MemoryRange origin, BinaryCode data)
            => new MemoryBlock(origin, data);

        [Op]
        public static unsafe MemoryBlock block(byte* pSrc, ByteSize size)
        {
            var start = address(pSrc);
            var end = start + size;
            MemoryRange range = (start,end);
            var dst = alloc<byte>(size);
            var read = reader(pSrc,size);
            read.ReadAll(dst);
            return block(range, dst);
        }
    }
}