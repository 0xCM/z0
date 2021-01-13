//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Asm.IceOpKind;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static IceRegister memidx(IceInstruction src, byte index)
            => opkind(src, (byte)index) == Memory ? src.MemoryIndex : 0;
    }
}