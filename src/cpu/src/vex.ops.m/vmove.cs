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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse2.X64;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static Part;
    using static memory;

    partial struct cpu
    {
        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 16x8u -> 16x16u
        /// Projects 16 unsigned 8-bit integers onto 16 unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> vmove8x16(in byte src)
            => ConvertToVector256Int16(gptr(src)).AsUInt16();

        /// <summary>
        /// src[3] -> r/m16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target register width</param>
        /// <param name="i">The source component index</param>
        /// <param name="j">THe target component index</param>
        [MethodImpl(Inline), Op]
        public static ushort vmove(Vector128<ushort> src, W16 w, N3 i, N0 j)
            => vint16u(cpu.vpermlo4x16(src,Perm4L.DBCA));

        /// <summary>
        /// src[2] -> r/m16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target register width</param>
        /// <param name="i">The source component index</param>
        /// <param name="j">THe target component index</param>
        [MethodImpl(Inline), Op]
        public static ushort vmove(Vector128<ushort> src, W16 w, N2 i, N0 j)
            => vint16u(cpu.vpermlo4x16(src,Perm4L.CBDA));

        /// <summary>
        /// src[1] -> r/m16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target register width</param>
        /// <param name="i">The source component index</param>
        /// <param name="j">THe target component index</param>
        [MethodImpl(Inline), Op]
        public static ushort vmove(Vector128<ushort> src, W16 w, N1 i, N0 j)
            => vint16u(cpu.vpermlo4x16(src,Perm4L.BCDA));

        /// <summary>
        /// src[0..31] -> dst[0..64]
        /// __m128d _mm_cvtss_sd (__m128d a, __m128 b) CVTSS2SD xmm, xmm/m32
        /// Overwrites the lower half of the target vector with the value obtained by converting the
        /// least component of the source vector to a 64-bit integer
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vmove(Vector128<uint> src, Vector128<ulong> dst)
            => v64u(ConvertScalarToVector128Double(v64f(dst),v32f(src)));

        /// <summary>
        /// src[0..31] -> dst[0..64]
        /// __m128d _mm_cvtss_sd (__m128d a, __m128 b) CVTSS2SD xmm, xmm/m32
        /// Overwrites the lower half of the target vector with the value obtained by converting the least component of the source vector to a 64-bit integer
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vmove(Vector128<int> src, Vector128<long> dst)
            => v64i(ConvertScalarToVector128Double(v64f(dst),v32f(src)));

        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// 2x8u -> 2x64u
        /// Projects 2 unsigned 8-bit values onto 2 unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="dst">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> vmove2x64u(in byte src)
            => v64u(ConvertToVector128Int64(gptr(src)));

        /// <summary>
        /// PMOVZXBD xmm, m32
        /// 4x8u -> 4x32u
        /// Projects 4 unsigned 8-bit values onto 4 unsigned 32-bit values
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="dst">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vmove4x32u(in byte src)
            => v32u(ConvertToVector128Int32(gptr(src)));

        /// <summary>
        /// VPMOVZXBQ ymm, m32
        /// 4x8u -> 4x64u
        /// Projects four unsigned 8-bit integers onto 4 unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="dst">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vmove4x64u(in byte src)
            => v64u(ConvertToVector256Int64(gptr(src)));

        /// <summary>
        /// PMOVZXBW xmm, m64
        /// 8x8u -> 8x16u
        /// Projects 8 8-bit unsigned integers onto 8 16-bit unsigned integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="dst">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ushort> vmove8x16u(in byte src)
            => v16u(ConvertToVector128Int16(gptr(src)));

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// Projects 8 unsigned 8-bit integers onto 8 unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="dst">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vmove8x32u(in byte src)
            => v32u(ConvertToVector256Int32(gptr(src)));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 16x8u -> 16x16u
        /// Projects 16 unsigned 8-bit integers onto 16 unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="dst">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ushort> vmove16x16u(in byte src)
            => v16u(ConvertToVector256Int16(gptr(src)));

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// 2x16u -> 2x64u
        /// Projects 2 unsigned 16-bit integers onto two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> vmove2x64u(in ushort src)
            => v64u(ConvertToVector128Int64(gptr(src)));

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// 4x16u -> 4x64u
        /// Projects 4 unsigned 16-bit integers onto 4 unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vmove4x64u(in ushort src)
            => v64u(ConvertToVector256Int64(gptr(src)));

        /// <summary>
        /// PMOVSXWD xmm, m64
        /// 4x16u -> 4x32u
        /// Projects 4 16-bit unsigned integers onto 4 32-bit unsigned integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vmove4x32u(in ushort src)
            => v32u(ConvertToVector128Int32(gptr(in src)));

        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// 8x16u -> 8x32u
        /// Projects 8 unsigned 16-bit integers onto 8 unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vmove8x32u(in ushort src)
            => v32u(ConvertToVector256Int32(gptr(src)));

        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// 2x8u -> 2x64i
        /// Projects two unsigned 8-bit integers onto 2 signed 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vmove2x64i(in byte src)
            => ConvertToVector128Int64(gptr(src));

        /// <summary>
        /// PMOVZXBD xmm, m32
        /// 4x8u -> 4x32i
        /// Projects four unsigned 8-bit integers onto 4 signed 32-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vmove2x32i(in byte src)
            => ConvertToVector128Int32(gptr(src));

        /// <summary>
        /// VPMOVZXBQ ymm, m32
        /// 4x8u -> 4x64i
        /// Projects four unsigned 8-bit integers onto 4 signed 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vmove4x64i(in byte src)
            => ConvertToVector256Int64(gptr(src));

        /// <summary>
        /// PMOVZXBW xmm, m64
        /// 8x8u -> 8x16u
        /// Projects 8 8-bit unsigned integers onto 8 signed 16-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<short> vmove8x16i(in byte src)
            => ConvertToVector128Int16(gptr(src));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 16x8u -> 16x16i
        /// Projects 16 8-bit unsigned integers onto 16 signed 16-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<short> vmove16x16i(in byte src)
            => ConvertToVector256Int16(gptr(src));

        /// <summary>
        /// PMOVSXWQ xmm, m32
        /// 2x16i -> 2x64u
        /// Projects 2 16-bit signed integers onto 2 64-bit signed integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vmove2x64i(in short src)
            => ConvertToVector128Int64(gptr(src));

        /// <summary>
        /// PMOVSXWD xmm, m64
        /// 4x16i -> 4x32i
        /// Projects 4 16-bit signed integers onto 4 32-bit signed integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vmove4x32i(in short src)
            => ConvertToVector128Int32(gptr(src));

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// Projects 2 unsigned 16-bit integers onto 2 signed 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        /// <param name="i">Signals a sign extension</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vmove2x64i(in ushort src)
            => ConvertToVector128Int64(gptr(src));

        /// <summary>
        /// PMOVSXDQ xmm, m64
        /// 2x32i -> 2x64i
        /// Projects 2 signed 32-bit integers onto 2 signed 64-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vmove2x64i(in int src)
            => ConvertToVector128Int64(gptr(src));

        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// 16x16u ->16x32u
        /// Projects 16 unsigned 16-bit integers onto 16 unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<uint> vmove16x32u(in ushort src)
            => (v32u(ConvertToVector256Int32(gptr(src))),
                v32u(ConvertToVector256Int32(gptr(src, 8))));

        /// <summary>
        /// __m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// 4x32i -> 4x64i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vmove4x64i(Vector128<int> src, W256 wDst)
            => ConvertToVector256Int64(src);

        /// <summary>
        ///  __m256i _mm256_cvtepu32_epi64 (__m128i a) VPMOVZXDQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vmove4x64i(Vector128<uint> src, W256 wDst)
            => ConvertToVector256Int64(src);


    }
}