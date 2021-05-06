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
        public static unsafe MemorySpan memspan(byte* pSrc, ByteSize size)
            => new MemorySpan((address(pSrc), address(pSrc) + size), cover(pSrc,size));
    }
}