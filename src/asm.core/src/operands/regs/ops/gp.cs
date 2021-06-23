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
            => r.RegClass == RegClass.GP;

        [MethodImpl(Inline), Op]
        public static bool gp(RegClass c)
            => c == RegClass.GP;

        [MethodImpl(Inline), Op]
        public static bool gp(RegOp r, RegWidth w)
            => w == r.Width && gp(r);
    }
}