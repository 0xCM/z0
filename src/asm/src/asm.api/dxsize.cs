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
        public static AsmDisplacementSize dxsize(in IceInstruction src, byte index)
            => opkind(src,index) == Memory ? (AsmDisplacementSize)src.MemoryDisplSize : 0;
    }
}