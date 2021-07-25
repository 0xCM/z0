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
        public static RegName name(RegOp src)
            => AsmRegNames.name(src);

        [MethodImpl(Inline), Op]
        public static string format(RegName src)
            => AsmRegNames.format(src);
    }
}