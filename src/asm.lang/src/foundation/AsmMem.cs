//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct AsmMem
    {
        [MethodImpl(Inline), Op, Closures(Integers8x16x32k)]
        public static MemoryAddress effective<T>(offset64<T> src)
            where T : unmanaged
                => src.Base.Content + (src.Index.Content * (byte)src.Scale) + memory.u32(src.Dx);
    }
}