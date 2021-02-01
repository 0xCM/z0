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
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static Part;

    partial class fcpu
    {
        /// <summary>
        /// __m128 _mm_shuffle_ps (__m128 a, __m128 b, unsigned int control) SHUFPS xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vshuffle(Vector128<float> x, Vector128<float> y, byte control)
            => Shuffle(x, y, control);

        /// <summary>
        /// __m128d _mm_shuffle_pd (__m128d a, __m128d b, int immediate) SHUFPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vshuffle(Vector128<double> x, Vector128<double> y, byte control)
            => Shuffle(x, y, control);
    }
}