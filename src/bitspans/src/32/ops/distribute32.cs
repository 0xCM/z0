//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class SpannedBits
    {
        [MethodImpl(Inline), Op]
        public static void distribute32(in byte src, int step, ref uint dst)
            => cpu.vstore(cpu.vinflate8x256x32u(skip(src, step*8)), ref seek(dst, step*8));

        [MethodImpl(Inline), Op]
        public static void distribute32(in byte src, int srcstep, ref uint dst, int dststep)
            => cpu.vstore(cpu.vinflate8x256x32u(skip(src, srcstep*8)), ref seek(dst, dststep*8));
    }
}