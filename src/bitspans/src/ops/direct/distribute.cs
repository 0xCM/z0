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
        public static void distribute(in byte src, int step, ref uint dst)
            => Vectors.vstore(z.vconvert(w64, in skip(src, step*8), w256, w32), ref seek(dst, step*8));

        [MethodImpl(Inline), Op]
        public static void distribute(in byte src, int srcstep, ref uint dst, int dststep)
            => Vectors.vstore(z.vconvert(w64, skip(src, srcstep*8), w256, w32), ref seek(dst, dststep*8));
    }
}