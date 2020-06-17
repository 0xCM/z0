//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Konst;

    partial class dinxfp
    {
        [MethodImpl(Inline), Op]
        public static Vector128<float> vlo(Vector256<float> src)
            => ExtractVector128(src, 0);

        [MethodImpl(Inline), Op]
        public static Vector128<double> vlo(Vector256<double> src)
            => ExtractVector128(src, 0);
    }
}