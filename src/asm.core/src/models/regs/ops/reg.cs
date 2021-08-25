//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
     using System;
     using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmRegs
    {
        [MethodImpl(Inline), Op]
        public static RegOp reg(AsmWidthCode width, RegClassCode @class, RegIndexCode r)
            => AsmRegBits.reg(width, @class, r);
    }
}