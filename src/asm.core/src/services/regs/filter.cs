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
        public static uint filter(RegClass @class, ReadOnlySpan<Register> src, Span<Register> dst)
        {
            var k=0u;
            var j = min(src.Length, dst.Length);
            for(var i=0; i<j; i++)
            {
                ref readonly var candidate = ref skip(src,i);

                if(invalid(candidate.Code))
                    continue;

                if(candidate.Class == @class)
                    seek(dst,k++) = candidate;
            }
            return k;
        }

        [MethodImpl(Inline), Op]
        public static uint filter(RegWidth width, ReadOnlySpan<Register> src, Span<Register> dst)
        {
            var k=0u;
            var j = min(src.Length, dst.Length);
            for(var i=0; i<j; i++)
            {
                ref readonly var candidate = ref skip(src,i);

                if(invalid(candidate.Code))
                    continue;

                if(candidate.Width == width)
                    seek(dst,k++) = candidate;
            }
            return k;
        }

        [MethodImpl(Inline), Op]
        public static uint filter(RegClass @class, RegWidth width, ReadOnlySpan<Register> src, Span<Register> dst)
        {
            var k=0u;
            var j = min(src.Length, dst.Length);
            for(var i=0; i<j; i++)
            {
                ref readonly var candidate = ref skip(src,i);

                if(invalid(candidate.Code))
                    continue;

                if(candidate.Width == width && candidate.Class == @class)
                    seek(dst,k++) = candidate;
            }
            return k;
        }
    }
}
