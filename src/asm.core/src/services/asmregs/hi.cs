//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static RegFacets;

    partial struct AsmRegs
    {
        [MethodImpl(Inline), Op]
        public static bit hi(RegKind src)
            => ((uint)src & (uint)BitSplitCode.Hi) != 0;
    }
}