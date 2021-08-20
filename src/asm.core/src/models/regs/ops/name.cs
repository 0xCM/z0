//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Blit;

    partial struct AsmRegs
    {
        [MethodImpl(Inline), Op]
        public static name64 name(RegOp src)
            => AsmRegNames.name(src);
    }
}