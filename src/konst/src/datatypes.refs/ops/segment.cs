//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct MemRefs
    {
        [MethodImpl(Inline), Op]
        public static SegRef segment(MemoryAddress address, ByteSize size)
            => new SegRef(address, size);
    }
}