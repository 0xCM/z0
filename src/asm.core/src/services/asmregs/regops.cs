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
        public static ReadOnlySpan<RegOp> regops(RegClassCode @class, SortedSpan<RegWidthCode> widths)
        {
            var wCount = widths.Length;
            var view = widths.View;
            var count = regcount(@class)*wCount;
            var dst = alloc<RegOp>(count);
            for(var w=wCount-1; w>=0; w--)
                regops(@class, skip(view,w),  dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static uint regops(RegClassCode @class, RegWidthCode w, Span<RegOp> dst)
        {
            ref var r = ref first(dst);
            var count = regcount(@class);
            var counter = 0u;
            for(var i=0; i<count; i++)
                seek(r,counter++) = reg((RegWidthCode)w, @class, (RegIndexCode)i);
            return counter;
        }
    }
}