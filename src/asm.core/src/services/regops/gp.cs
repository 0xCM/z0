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
        public static bool gp(RegOp r)
            => r.RegClass == RegClassCode.GP;

        [MethodImpl(Inline), Op]
        public static bool gp(RegClassCode c)
            => c == RegClassCode.GP;

        [MethodImpl(Inline), Op]
        public static bool gp(RegOp r, RegWidthCode w)
            => w == r.Width && gp(r);
    }
}