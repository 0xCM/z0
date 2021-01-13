//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static Part;

    partial class dinxfp
    {
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<float> vscalar(float src)
            => LoadScalarVector128(&src);

        [MethodImpl(Inline), Op]
        public static unsafe Vector128<double> vscalar(double src)
            => LoadScalarVector128(&src);
    }
}