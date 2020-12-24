//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct MemRefs
    {
        [MethodImpl(Inline), Op]
        static unsafe Ref define(void* pSrc, ulong size)
            => new Ref((ulong)pSrc, (uint)size);

        [MethodImpl(Inline), Op]
        static unsafe Ref define(void* pSrc, int size)
            => new Ref((ulong)pSrc, (uint)size);
    }
}