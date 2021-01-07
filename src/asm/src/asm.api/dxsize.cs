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
        public static MemDxSize dxsize(in IceInstruction src, byte index)
            => kind(src,index) == Memory ? (MemDxSize)src.MemoryDisplSize : 0;
    }
}