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

    partial struct AsmRegs
    {
        [MethodImpl(Inline), Op]
        public static r8 next(r8 src)
        {
            if(math.lt((byte)src.Index, (byte)RegIndex.r15))
                return emath.inc(src.Index);
            else
                return RegIndex.r0;
        }

        [MethodImpl(Inline), Op]
        public static r16 next(r16 src)
        {
            if(math.lt((byte)src.Index, (byte)RegIndex.r15))
                return emath.inc(src.Index);
            else
                return RegIndex.r0;
        }

        [MethodImpl(Inline), Op]
        public static r32 next(r32 src)
        {
            if(math.lt((byte)src.Index, (byte)RegIndex.r15))
                return emath.inc(src.Index);
            else
                return RegIndex.r0;
        }


        [MethodImpl(Inline), Op]
        public static r64 next(r64 src)
        {
            if(math.lt((byte)src.Index, (byte)RegIndex.r15))
                return emath.inc(src.Index);
            else
                return RegIndex.r0;
        }

        [MethodImpl(Inline), Op]
        public static xmm next(xmm src)
        {
            if(math.lt((byte)src.Index, (byte)RegIndex.r31))
                return emath.inc(src.Index);
            else
                return RegIndex.r0;
        }


        [MethodImpl(Inline), Op]
        public static ymm next(ymm src)
        {
            if(math.lt((byte)src.Index, (byte)RegIndex.r31))
                return emath.inc(src.Index);
            else
                return RegIndex.r0;
        }

        [MethodImpl(Inline), Op]
        public static zmm next(zmm src)
        {
            if(math.lt((byte)src.Index, (byte)RegIndex.r31))
                return emath.inc(src.Index);
            else
                return RegIndex.r0;
        }

        [MethodImpl(Inline), Op]
        public static rK next(rK src)
        {
            if(math.lt((byte)src.Index, (byte)RegIndex.r8))
                return emath.inc(src.Index);
            else
                return RegIndex.r0;
        }
    }
}