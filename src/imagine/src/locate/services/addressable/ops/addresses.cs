//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Addressable
    {
        [MethodImpl(Inline), Op]
        public static MemoryOffsets offsets(params MemoryOffset[] src)
            => new MemoryOffsets(src);
    }
}