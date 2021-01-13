//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Part;
    using static Asm.IceOpKind;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static MemoryScale memScale(IceInstruction src, int index)
            => opkind(src, (byte)index) == Memory ? src.MemoryIndexScale : MemoryScale.Empty;
    }
}