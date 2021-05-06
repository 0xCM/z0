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
        public static MemoryBlock memblock(MemoryRange origin, BinaryCode data)
            => new MemoryBlock(origin, data);

        [Op]
        public static unsafe MemoryBlock memblock(byte* pSrc, ByteSize size)
        {
            var slice = memspan(pSrc,size);
            return memblock(slice.Origin, slice.Edit.ToArray());
        }
    }
}