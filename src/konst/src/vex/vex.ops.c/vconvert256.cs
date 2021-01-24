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

    using static Part;

    partial struct cpu
    {
        /// <summary>
        /// __m128i _mm256_cvtpd_epi32 (__m256d a) VCVTPD2DQ xmm, ymm/m256
        /// 4x64u -> 4x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vconvert32u(Vector256<ulong> src, W128 w)
            => gcpu.v32u(ConvertToVector128Int32(gcpu.v64f(src)));

        /// <summary>
        /// src[i] -> lo[i], i = 1,..,15
        /// src[i] -> hi[i], i = 16,..,31
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<short> vconvert16i(Vector256<sbyte> src, W512 w)
            => (vmaplo16i(src, w256), vmaphi16i(src, w256));

        /// <summary>
        /// 32x8u -> (16x16i, 16x16i)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<short> vconvert16i(Vector256<byte> src, W512 w)
            => (vmaplo16i(src, w256), vmaphi16i(src, w256));

        /// <summary>
        /// 16x16i -> 16x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline), Op]
        public static Vector512<int> vconvert32i(Vector256<short> src, W512 w)
            => (vmaplo32i(src, w256), vmaphi32i(src, w256));

        /// <summary>
        /// 16x16u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vconvert32u(Vector256<ushort> src, W512 w)
            => (vmaplo32u(src, w256), vmaphi16u(src, w256));

        /// <summary>
        /// 8x32i -> (4x64i, 4x64i)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<long> vconvert64i(Vector256<int> src, W512 w)
            => (vmaplo64i(src, w256), vmaphi64i(src, w256));

        /// <summary>
        /// 8x32u -> (4x64u, 4x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ulong> vconvert64u(Vector256<uint> src, W512 w)
            => (vmaplo64u(src, w256), vmaphi64u(src, w256));

        [MethodImpl(Inline), Op]
        public static Vector512<long> vconvert64i(Vector256<short> src, W512 w)
            => (ConvertToVector256Int64(vlo(src)), ConvertToVector256Int64(vhi(src)));

        /// <summary>
        /// 32x8u -> (16x16u, 16x16u)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ushort> vconvert16u(Vector256<byte> src, W512 w)
             => (vmaplo16u(src, w256), vmaphi16u(src, w256));

        /// <summary>
        /// 32x8i -> (8x32i, 8x32i, 8x32i, 8x32i)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<int> vconvert32i(Vector256<sbyte> src, W1024 w)
        {
            (var lo, var hi) = vconvert16i(src, w512);
            var x0 = vmaplo32i(lo, w256);
            var x1 = vmaphi32i(lo, w256);
            var x2 = vmaplo32i(hi, w256);
            var x3 = vmaphi32i(hi, w256);
            return (x0,x1,x2,x3);
        }

        /// <summary>
        /// 32x8u -> (8x32u, 8x32u, 8x32u, 8x32u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="x1">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<uint> vconvert32u(Vector256<byte> src, W1024 w)
        {
            (var lo, var hi) = vconvert16u(src, w512);
            (var x0, var x1) = vconvert32u(lo, w512);
            (var x2, var x3) = vconvert32u(hi, w512);
            return (x0, x1, x2, x3);
        }

        /// <summary>
        /// 16x16u -> 16x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<ulong> vconvert64u(Vector256<ushort> src, W1024 w)
            => (vconvert64u(z.vlo(src), w512), vconvert64u(cpu.vhi(src), w512));
    }
}