//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct AsmRegs
    {
        [MethodImpl(Inline), Op]
        public static RegRange range(RegClass @class, RegIndex i0, RegIndex i1)
            => new RegRange(@class, i0, i1);
    }
}