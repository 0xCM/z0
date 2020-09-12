//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static MemDirect memDirect(in Instruction src)
            => new MemDirect(src.MemoryBase, src.MemoryIndexScale, asm.memDx(src.MemoryDisplacement, (MemDxSize)src.MemoryDisplSize));
    }
}