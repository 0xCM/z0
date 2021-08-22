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
        public static uint filter(RegClassCode @class, ReadOnlySpan<RegOp> src, Span<RegOp> dst)
        {
            var k=0u;
            var j = min(src.Length, dst.Length);
            for(var i=0; i<j; i++)
            {
                ref readonly var candidate = ref skip(src,i);
                if(AsmRegBits.invalid(candidate.Index))
                    continue;

                if(candidate.RegClassCode == @class)
                    seek(dst,k++) = candidate;
            }
            return k;
        }

        [MethodImpl(Inline), Op]
        public static uint filter(RegWidthCode width, ReadOnlySpan<RegOp> src, Span<RegOp> dst)
        {
            var k=0u;
            var j = min(src.Length, dst.Length);
            for(var i=0; i<j; i++)
            {
                ref readonly var candidate = ref skip(src,i);

                if(AsmRegBits.invalid(candidate.Index))
                    continue;

                if(candidate.WidthCode == width)
                    seek(dst,k++) = candidate;
            }
            return k;
        }

        [MethodImpl(Inline), Op]
        public static uint filter(RegClassCode @class, RegWidthCode width, ReadOnlySpan<RegOp> src, Span<RegOp> dst)
        {
            var k=0u;
            var j = min(src.Length, dst.Length);
            for(var i=0; i<j; i++)
            {
                ref readonly var candidate = ref skip(src,i);

                if(AsmRegBits.invalid(candidate.Index))
                    continue;

                if(candidate.WidthCode == width && candidate.RegClassCode == @class)
                    seek(dst,k++) = candidate;
            }
            return k;
        }
    }
}
