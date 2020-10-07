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
    using static z;

    partial class dinxfp
    {
        /// <summary>
        /// Creates a scalar vector from the upper 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vhi(Vector128<float> src)
            =>  v32f(vscalar(v64i(src).GetElement(1)));

        /// <summary>
        /// Creates a scalar vector from the upper 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vhi(Vector128<double> src)
            =>  vscalar(src.GetElement(1));

        [MethodImpl(Inline), Op]
        public static Vector128<float> vhi(Vector256<float> src)
            => ExtractVector128(src, 1);

        [MethodImpl(Inline), Op]
        public static Vector128<double> vhi(Vector256<double> src)
            => ExtractVector128(src, 1);
    }
}