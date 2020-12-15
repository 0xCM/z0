//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// __m128i _mm256_cvtpd_epi32 (__m256d a) VCVTPD2DQ xmm, ymm/m256
        /// 4x64u -> 4x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vconvert32u(Vector256<ulong> src, W128 w, uint t)
            => v32u(ConvertToVector128Int32(v64f(src)));

        /// <summary>
        /// src[i] -> lo[i], i = 1,..,15
        /// src[i] -> hi[i], i = 16,..,31
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<short> vconvert16i(Vector256<sbyte> src, N512 w, short t)
            => (vmaplo16i(src, n256, z16i), vmaphi16i(src, n256, z16i));

        /// <summary>
        /// 32x8u -> (16x16i, 16x16i)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<short> vconvert16i(Vector256<byte> src, N512 w, short t)
            => (vmaplo16i(src, n256, z16i), vmaphi16i(src, n256, z16i));

        /// <summary>
        /// 16x16i -> 16x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline), Op]
        public static Vector512<int> vconvert32i(Vector256<short> src, N512 w, int t)
            => (vmaplo32i(src,n256,t), vmaphi32i(src,n256,t));

        /// <summary>
        /// 16x16u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vconvert32u(Vector256<ushort> src, N512 w, uint t)
            => (vmaplo32u(src,n256,t), vmaphi16u(src,n256,t));

        /// <summary>
        /// 8x32i -> (4x64i, 4x64i)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<long> vconvert64i(Vector256<int> src, N512 w, long t)
            => (vmaplo64i(src, n256, t), vmaphi64i(src, n256, t));

        /// <summary>
        /// 8x32u -> (4x64u, 4x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ulong> vconvert64u(Vector256<uint> src, N512 w, ulong t)
            => (vmaplo64u(src, n256, t), vmaphi64u(src, n256, t));

        [MethodImpl(Inline), Op]
        public static Vector512<long> vconvert64i(Vector256<short> src, N512 w, long t)
            => (ConvertToVector256Int64(vlo(src)), ConvertToVector256Int64(vhi(src)));

        /// <summary>
        /// 32x8u -> (16x16u, 16x16u)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ushort> vconvert16u(Vector256<byte> src, N512 w, ushort t)
             => (vmaplo16u(src, n256, t), vmaphi16u(src, n256, t));

        /// <summary>
        /// 32x8i -> (8x32i, 8x32i, 8x32i, 8x32i)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<int> vconvert32i(Vector256<sbyte> src, N1024 w, int t)
        {
            (var lo, var hi) = vconvert16i(src, n512, z16i);
            var x0 = vmaplo32i(lo, n256, z32i);
            var x1 = vmaphi32i(lo, n256, z32i);
            var x2 = vmaplo32i(hi, n256, z32i);
            var x3 = vmaphi32i(hi, n256, z32i);
            return (x0,x1,x2,x3);
        }

        /// <summary>
        /// 32x8u -> (8x32u, 8x32u, 8x32u, 8x32u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="x1">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<uint> vconvert32u(Vector256<byte> src, N1024 w, uint t)
        {
            (var lo, var hi) = vconvert16u(src, n512, z16);
            (var x0, var x1) = vconvert32u(lo, n512, t);
            (var x2, var x3) = vconvert32u(hi, n512, t);
            return (x0, x1, x2, x3);
        }

        /// <summary>
        /// 16x16u -> 16x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<ulong> vconvert64u(Vector256<ushort> src, N1024 w, ulong t)
            => (vconvert64u(vlo(src), n512, t), vconvert64u(vhi(src), n512, t));
    }
}