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
        [Op]
        public static ReadOnlySpan<RegOp> generate(RegClassCode @class, SortedSpan<RegWidthCode> widths)
        {
            var wCount = widths.Length;
            var view = widths.View;
            var count = AsmRegs.count(@class)*wCount;
            var dst = alloc<RegOp>(count);
            for(var w=wCount-1; w>=0; w--)
                list(@class, skip(view,w),  dst);
            return dst;
        }
    }
}