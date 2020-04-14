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

    using static Seed;

    partial class dinxfp
    {
        /// <summary>
        /// __m128 _mm_movehl_ps (__m128 a, __m128 b) MOVHLPS xmm, xmm
        /// z[0] = x[3]
        /// z[1] = y[3]
        /// z[2] = x[0]
        /// z[3] = y[0]
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> movehl(Vector128<float> x, Vector128<float> y)
            => MoveHighToLow(x,y);

        /// <summary>
        /// __m128 _mm_movelh_ps (__m128 a, __m128 b) MOVLHPS xmm, xmm
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> movelh(Vector128<float> x, Vector128<float> y)
            => MoveLowToHigh(x,y);

        /// <summary>
        /// Transposes a 4x4 matrix of floats, adapted from MSVC intrinsic headers
        /// </summary>
        /// <param name="row0">The first row</param>
        /// <param name="row1">The second row</param>
        /// <param name="row2">The third row</param>
        /// <param name="row3">The fourth row</param>
        [MethodImpl(Inline), Op]
        public static void vtranspose(ref Vector128<float> row0, ref Vector128<float> row1, ref Vector128<float> row2, ref Vector128<float> row3)
        {
            var tmp0 = Shuffle(row0,row1, 0x44);
            var tmp2 = Shuffle(row0, row1, 0xEE);
            var tmp1 = Shuffle(row2, row3, 0x44);
            var tmp3 = Shuffle(row2,row3, 0xEE);
            row0 = Shuffle(tmp0,tmp1, 0x88);
            row1 = Shuffle(tmp0,tmp1, 0xDD);
            row2 = Shuffle(tmp2,tmp3, 0x88);
            row3 = Shuffle(tmp2, tmp3, 0xDD);
        }    
    }
}