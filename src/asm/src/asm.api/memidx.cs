//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Part;
    using static Asm.IceOpKind;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static IceRegister memidx(IceInstruction src, byte index)
            => kind(src, (byte)index) == Memory ? src.MemoryIndex : 0;
    }
}