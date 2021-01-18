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
    using static System.Runtime.Intrinsics.X86.Sse.X64;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse2.X64;

    using static Part;

    partial struct z
    {
        /// <summary>
        /// int _mm_cvtsi128_si32 (__m128i a) MOVD reg/m32, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static int convert32i(Vector128<int> src, W32 w)
            => ConvertToInt32(src);

        /// <summary>
        /// int _mm_cvtsi128_si32 (__m128i a) MOVD reg/m32, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static uint convert32u(Vector128<uint> src, W32 w)
            => ConvertToUInt32(src);

        /// <summary>
        /// __int64 _mm_cvtsi128_si64 (__m128i a) MOVQ reg/m64, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static long convert64i(Vector128<long> src, W64 w)
            => ConvertToInt64(src);

        /// <summary>
        /// __int64 _mm_cvtsi128_si64 (__m128i a) MOVQ reg/m64, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static ulong convert64u(Vector128<ulong> src, W64 w)
            => ConvertToUInt64(src);

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// Zero extend 8 packed 8-bit integers in the low 8 bytes of xmm2/m64 to 8 packed 32-bit integers in ymm1
        /// </summary>
        /// <param name="n64">The number of bits covered by the source reference</param>
        /// <param name="src">The source reference</param>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vconvert32u(N64 n64, in byte src, W256 w)
            => v32u(ConvertToVector256Int32(gptr(src)));

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// Evenly covers a 256-bit target vector with a 64-bit source
        /// </summary>
        /// <param name="n64">The number of bits covered by the source reference</param>
        /// <param name="src">The source reference</param>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vconvert32u(N64 n64, in ushort src, W256 w, W32 n)
            => v32u(ConvertToVector256Int32(gptr(u8(src))));

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// Evenly covers a 256-bit target vector with a 64-bit source
        /// </summary>
        /// <param name="w64">The number of bits covered by the source reference</param>
        /// <param name="src">The source reference</param>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vconvert32u(W64 w64, in uint src, W256 w, W32 n)
            => v32u(ConvertToVector256Int32(gptr(u8(src))));

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// Evenly covers a 256-bit target vector with a 64-bit source
        /// </summary>
        /// <param name="n64">The number of bits covered by the source reference</param>
        /// <param name="src">The source reference</param>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vconvert32u(W64 n64, in ulong src, W256 w, W32 n)
            => v32u(ConvertToVector256Int32(gptr(u8(src))));
    }
}