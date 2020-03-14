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
    using static System.Runtime.Intrinsics.X86.Avx.X64;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse.X64;
    using static System.Runtime.Intrinsics.X86.Sse2;

    using static Root;

    partial class dinxfp
    {
        [MethodImpl(Inline), Op]
        public static Vector128<float> vlo(Vector256<float> src)
            => ExtractVector128(src, 0);

        [MethodImpl(Inline), Op]
        public static Vector128<double> vlo(Vector256<double> src)
            => ExtractVector128(src, 0);

        [MethodImpl(Inline), Op]
        public static Vector128<float> vhi(Vector256<float> src)
            => ExtractVector128(src, 1);

        [MethodImpl(Inline), Op]
        public static Vector128<double> vhi(Vector256<double> src)
            => ExtractVector128(src, 1);


        [MethodImpl(Inline), Op]
        public static unsafe Vector128<float> vscalar(float src)
            => LoadScalarVector128(&src);

        [MethodImpl(Inline), Op]
        public static unsafe Vector128<double> vscalar(double src)
            => LoadScalarVector128(&src);

        /// <summary>
        /// __m128 _mm_move_ss (__m128 a, __m128 b) MOVSS xmm, xmm
        /// z[0] = y[0]
        /// z[1] = x[1]
        /// z[2] = x[2]
        /// z[3] = x[3]
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vmovescalar(Vector128<float> x, Vector128<float> y)
            => MoveScalar(y,x);

        /// <summary>
        /// __m128d _mm_move_sd (__m128d a, __m128d b) MOVSD xmm, xmm
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vmovescalar(Vector128<double> x, Vector128<double> y)
            => MoveScalar(y,x);

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
        /// <returns></returns>
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