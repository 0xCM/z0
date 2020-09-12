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
    using static Asm.OpKind;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static MemDx memDx(ulong value, MemDxSize size)
            => new MemDx(value, (MemDxSize)size);

        [MethodImpl(Inline), Op]
        public static uint memDx(Instruction src, byte index)
            => kind(src, (byte)index) == Memory ? src.MemoryDisplacement : 0;
    }
}