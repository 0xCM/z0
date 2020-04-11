//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial class SpannedBits
    {
        [MethodImpl(Inline), Op]
        public static void distribute(in byte src, int step, ref uint dst)
            => Vectors.vstore(dvec.vconvert(w64, in skip(in src, step*8), w256, w32), ref seek(ref dst, step*8));

        [MethodImpl(Inline), Op]
        public static void distribute(in byte src, int srcstep, ref uint dst, int dststep)
            => Vectors.vstore(dvec.vconvert(w64, in skip(in src, srcstep*8), w256, w32), ref seek(ref dst, dststep*8));
    }
}