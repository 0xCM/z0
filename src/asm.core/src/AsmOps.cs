//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmOps;
    using static core;
    using static RegFacets;

    [ApiHost]
    public readonly partial struct AsmOps
    {
        [MethodImpl(Inline), Op]
        public static r8 next(r8 src)
        {
            if(emath.lt(src.Index, RegIndex.r15))
                return emath.inc(src.Index);
            else
                return RegIndex.r0;
        }

        [MethodImpl(Inline), Op]
        public static r8 prior(r8 src)
        {
            if(emath.gt(src.Index, RegIndex.r0))
                return emath.dec(src.Index);
            else
                return RegIndex.r15;
        }

        [MethodImpl(Inline), Op]
        public static r16 next(r16 src)
        {
            if(emath.lt(src.Index, RegIndex.r15))
                return emath.inc(src.Index);
            else
                return RegIndex.r0;
        }

        [MethodImpl(Inline), Op]
        public static r16 prior(r16 src)
        {
            if(emath.gt(src.Index, RegIndex.r0))
                return emath.dec(src.Index);
            else
                return RegIndex.r15;
        }

        [MethodImpl(Inline), Op]
        public static r32 next(r32 src)
        {
            if(emath.lt(src.Index, RegIndex.r15))
                return emath.inc(src.Index);
            else
                return RegIndex.r0;
        }

        [MethodImpl(Inline), Op]
        public static r32 prior(r32 src)
        {
            if(emath.gt(src.Index, RegIndex.r0))
                return emath.dec(src.Index);
            else
                return RegIndex.r15;
        }

        [MethodImpl(Inline), Op]
        public static r64 next(r64 src)
        {
            if(emath.lt(src.Index, RegIndex.r15))
                return emath.inc(src.Index);
            else
                return RegIndex.r0;
        }

        [MethodImpl(Inline), Op]
        public static r64 prior(r64 src)
        {
            if(emath.gt(src.Index, RegIndex.r0))
                return emath.dec(src.Index);
            else
                return RegIndex.r15;
        }

        [MethodImpl(Inline), Op]
        public static xmm next(xmm src)
        {
            if(emath.lt(src.Index, RegIndex.r31))
                return emath.inc(src.Index);
            else
                return RegIndex.r0;
        }

        [MethodImpl(Inline), Op]
        public static xmm prior(xmm src)
        {
            if(emath.gt(src.Index, RegIndex.r0))
                return emath.dec(src.Index);
            else
                return RegIndex.r31;
        }

        [MethodImpl(Inline), Op]
        public static ymm next(ymm src)
        {
            if(emath.lt(src.Index, RegIndex.r31))
                return emath.inc(src.Index);
            else
                return RegIndex.r0;
        }

        [MethodImpl(Inline), Op]
        public static ymm prior(ymm src)
        {
            if(emath.gt(src.Index, RegIndex.r0))
                return emath.dec(src.Index);
            else
                return RegIndex.r31;
        }

        [MethodImpl(Inline), Op]
        public static zmm next(zmm src)
        {
            if(emath.lt(src.Index, RegIndex.r31))
                return emath.inc(src.Index);
            else
                return RegIndex.r0;
        }

        [MethodImpl(Inline), Op]
        public static zmm prior(zmm src)
        {
            if(emath.gt(src.Index, RegIndex.r0))
                return emath.dec(src.Index);
            else
                return RegIndex.r31;
        }

        [MethodImpl(Inline), Op]
        public static rK next(rK src)
        {
            if(emath.lt(src.Index, RegIndex.r15))
                return emath.inc(src.Index);
            else
                return RegIndex.r0;
        }

        [MethodImpl(Inline), Op]
        public static rK prior(rK src)
        {
            if(emath.gt(src.Index, RegIndex.r0))
                return emath.dec(src.Index);
            else
                return RegIndex.r31;
        }
    }
}