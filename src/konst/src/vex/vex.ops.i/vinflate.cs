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
    using static memory;

    partial struct cpu
    {
        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a) vpmovzxbw ymm, xmm
        /// 16x8u -> 16x16i
        /// src[i] -> dst[i], i = 0,...,15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vinflate256x16i(Vector128<byte> src, W256 w = default)
            => ConvertToVector256Int16(src);

        /// <summary>
        /// 16x8i -> 16x16i
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vinflate256x16i(Vector128<sbyte> src, W256 w = default)
            => vconcat(vmaplo16i(src, w128), vmaphi16i(src, w128));

        /// <summary>
        /// 32x8i -> 32x16i
        /// src[i] -> lo[i], i = 1,..,15
        /// src[i] -> hi[i], i = 16,..,31
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector</param>
        /// <param name="x1">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<short> vinflate512x16i(Vector256<sbyte> src, W512 w = default)
            => (vmaplo16i(src, w256), vmaphi16i(src, w256));

        /// <summary>
        /// 32x8w -> 32x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<short> vinflate512x16i(Vector256<byte> src)
            => (vmaplo16i(src, w256), vmaphi16i(src, w256));

        /// <summary>
        /// 32x8u -> 32x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ushort> vinflate512x16u(Vector256<byte> src, W512 w = default)
             => (vmaplo16u(src, w256), vmaphi16u(src, w256));

        /// <summary>
        ///  __m256i _mm256_cvtepu8_epi16 (__m128i a) VPMOVZXBW ymm, xmm
        /// 16x8u -> 16x16u
        /// src[i] -> dst[i], i = 0,...,15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vinflate256x16u(Vector128<byte> src, W256 w = default)
            => v16u(ConvertToVector256Int16(src));

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a) VPMOVZXBW ymm, xmm
        /// </summary>
        /// <param name="src"></param>
        /// <param name="w"></param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vinflate256x16u(in byte src)
            => ConvertToVector256Int16(vload(w128, src)).AsUInt16();

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a) VPMOVZXBW ymm, xmm
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vinflate256x16u(Vector128<byte> src)
            => ConvertToVector256Int16(src).AsUInt16();

        [MethodImpl(Inline), Op]
        public static Vector512<ushort> vinflate512x16u(in byte src)
        {
           var lo = vinflate256x16u(vload(w128, src));
           var hi = vinflate256x16u(vload(w128, add(src, 16)));
           return gcpu.vconcat(lo,hi);
        }

        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vinflatelo256x16u(Vector256<byte> src, N0 lo = default)
            => vinflate256x16u(vlo(src));

        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vinflatehi256x16u(Vector256<byte> src, N1 hi = default)
            => vinflate256x16u(vhi(src));

        /// <summary>
        /// __m256i _mm256_cvtepi16_epi32 (__m128i a) VPMOVSXWD ymm, xmm/m128
        /// 8x16i -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vinflate256x32i(Vector128<short> src, W256 w = default)
            => ConvertToVector256Int32(src);

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi32 (__m128i a) VPMOVZXWD ymm, xmm
        /// 8x16u -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vinflate256x32i(Vector128<ushort> src, W256 w = default)
            => ConvertToVector256Int32(src);

        /// <summary>
        /// 16x16i -> 16x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<int> vinflate512x32i(Vector256<short> src, W512 w = default)
            => (vmaplo32i(src, w256), vmaphi32i(src, w256));

        /// <summary>
        /// 32x8i -> (8x32i, 8x32i, 8x32i, 8x32i)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="x1">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<int> vinflate1024x32i(Vector256<sbyte> src)
        {
            (var lo, var hi) = vinflate512x16i(src, w512);
            var x0 = vmaplo32i(lo, w256);
            var x1 = vmaphi32i(lo, w256);
            var x2 = vmaplo32i(hi, w256);
            var x3 = vmaphi32i(hi, w256);
            return (x0,x1,x2,x3);
        }

        /// <summary>
        /// 8x32i -> 8x64i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline), Op]
        public static Vector512<long> vinflate512x64i(Vector256<int> src)
            => vmap64i(src, w512);

        /// <summary>
        /// 4x32w -> 4x64w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vinflate256x64i(Vector128<int> src)
             => ConvertToVector256Int64(src);

        /// <summary>
        /// 16x8u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vinflate512x32u(Vector128<byte> src, W512 w = default)
            => vmap32u(src, w512);

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi32 (__m128i a) VPMOVZXWD ymm, xmm
        /// 8x16u -> 8x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vinflate256x32u(Vector128<ushort> src, W256 w = default)
            => v32u(ConvertToVector256Int32(src));

        /// <summary>
        /// 32x8u -> (8x32u, 8x32u, 8x32u, 8x32u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="x1">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<uint> vinflate1024x32u(Vector256<byte> src, W1024 w = default)
        {
            (var lo, var hi) = vmap16u(src, w512);
            (var x0, var x1) = vmap32u(lo, w512);
            (var x2, var x3) = vmap32u(hi, w512);
            return (x0, x1, x2, x3);
        }

        /// <summary>
        /// 16x16u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vinflate512x32u(Vector256<ushort> src)
            => vmap32u(src, w512);

        /// <summary>
        /// 16x16u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vinflate512x32u(Vector256<ushort> src, W512 w = default)
            => vmap32u(src, w);

        /// <summary>
        /// 4x32u -> 4x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector</param>
        /// <param name="x1">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vinflate256x64u(Vector128<uint> src)
            => v64u(ConvertToVector256Int64(src));

        /// <summary>
        /// 8x32u -> 8x64u
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Vector512<ulong> vinflate512x64u(Vector256<uint> src)
            => vmap64u(src, w512);

        /// <summary>
        /// __m128i _mm_cvtepi8_epi32 (__m128i a) PMOVSXBD xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vconvert32i(Vector128<sbyte> src, W128 w)
            => ConvertToVector128Int32(src);

    }
}