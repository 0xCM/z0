//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Avx2;
    using static Konst;
    using static z;

    partial struct cpu
    {
        /// <summary>
        /// 16x8u -> 16x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vinflate16i(Vector128<byte> src, W256 w)
            => vinflate16i(src, w);

        /// <summary>
        /// 32x8u -> 32x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ushort> vinflate16u(Vector256<byte> src, W512 w)
            => vinflate16u(src, w);

        /// <summary>
        /// 16x8u -> 16x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vinflate16u(Vector128<byte> src, W256 w)
            => vconvert16u(src, w);

        /// <summary>
        /// 8x16i -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vinflate32i(Vector128<short> src, W256 w)
            => vconvert32i(src, w);

        /// <summary>
        /// 4x32u -> 4x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector</param>
        /// <param name="x1">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vinflate64u(Vector128<uint> src, W256 w)
            => vconvert64u(src, w);

        /// <summary>
        /// 4x32w -> 4x64w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vinflate64i(Vector128<int> src, W256 w)
            => vconvert64i(src, w);

        /// <summary>
        /// 16x8u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vinflate32u(Vector128<byte> src, W512 w)
            => vconvert32u(src, w);

        /// <summary>
        /// 8x16u -> 8x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vinflate32u(Vector128<ushort> src, W256 w)
            => vconvert32u(src, w);

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a) VPMOVZXBW ymm, xmm
        /// </summary>
        /// <param name="src"></param>
        /// <param name="w"></param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vinflate16u(in byte src, W128 w)
            => ConvertToVector256Int16(vload(w, src)).AsUInt16();

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a) VPMOVZXBW ymm, xmm
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vinflate16u(Vector128<byte> src)
            => ConvertToVector256Int16(src).AsUInt16();

        /// <summary>
        /// 16x8i -> 16x16i
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vinflate16i(Vector128<sbyte> src, W16 w)
            => vconcat(vmaplo16i(src, w128), vmaphi16i(src, w128));

        /// <summary>
        /// 16x8u -> 16x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vinflate16i(Vector128<byte> src, N256 w, short t = 0)
            => vconvert16i(src, w);

        /// <summary>
        /// 16x8i -> 16x16i
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vinflate16i(Vector128<sbyte> src, N256 w, short t = 0)
            => vconcat(vmaplo16i(src, w128), vmaphi16i(src, w128));

        /// <summary>
        /// 16x8u -> 16x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vinflate16u(Vector128<byte> src, N256 w, ushort t = 0)
            => vconvert16u(src, w);

        /// <summary>
        /// 8x16i -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vinflate32i(Vector128<short> src, N256 w, int t = 0)
            => vconvert32i(src, w);

        /// <summary>
        /// 4x32u -> 4x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector</param>
        /// <param name="x1">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vinflate64u(Vector128<uint> src, N256 w)
            => vconvert64u(src, w);

        /// <summary>
        /// 4x32w -> 4x64w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vinflate64i(Vector128<int> src, N256 w)
            => vconvert64i(src, w);

        /// <summary>
        /// 16x8u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vinflate32u(Vector128<byte> src, N512 w, uint t = 0)
            => vconvert32u(src, w);

        /// <summary>
        /// 8x16u -> 8x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vinflate32u(Vector128<ushort> src, N256 w, uint t = 0)
            => vconvert32u(src, w);

        /// <summary>
        /// 8x32u -> 8x64u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ulong> vinflate64u(Vector256<uint> src, W512 w)
            => vconvert64u(src, w);

        /// <summary>
        /// 8x32i -> 8x64i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline), Op]
        public static Vector512<long> vinflate64i(Vector256<int> src, W512 w)
            => vconvert64i(src, w);

        /// <summary>
        /// 32x8u -> 32x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="x1">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<uint> vinflate32u(Vector256<byte> src, W1024 w)
            => vconvert32u(src, w);

        /// <summary>
        /// 32x8i -> (8x32i, 8x32i, 8x32i, 8x32i)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="x1">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<int> vinflate32i(Vector256<sbyte> src, W1024 w)
            => vconvert32i(src, w);

        /// <summary>
        /// 32x8i -> 32x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector</param>
        /// <param name="x1">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<short> vinflate16i(Vector256<sbyte> src, W512 w)
            => vconvert16i(src, w);

        /// <summary>
        /// 16x16i -> 16x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<int> vinflate32i(Vector256<short> src, W512 w)
            => vconvert32i(src, w);

        /// <summary>
        /// 16x16u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vinflate32u(Vector256<ushort> src, W512 w)
            => vconvert32u(src, w);

        [MethodImpl(Inline), Op]
        public static Vector512<ushort> vinflate16u(in byte src, W256 w)
        {
           var lo = vinflate16u(vload(w128, src));
           var hi = vinflate16u(vload(w128, add(src, 16)));
           return gcpu.vconcat(lo,hi);
        }

        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vinflate(Vector256<byte> src, N0 lo)
            => vinflate16u(vlo(src));

        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vinflate(Vector256<byte> src, N1 hi)
            => vinflate16u(vhi(src));

        /// <summary>
        /// 32x8w -> 32x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<short> vinflate16i(Vector256<byte> src, N512 w)
            => vconvert16i(src, w);

        /// <summary>
        /// 32x8i -> 32x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector</param>
        /// <param name="x1">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<short> vinflate16i(Vector256<sbyte> src, N512 w, short t = 0)
            => vconvert16i(src, w);

        /// <summary>
        /// 32x8u -> 32x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector512<ushort> vinflate16u(Vector256<byte> src, N512 w, ushort t = 0)
            => vconvert16u(src, w);

        /// <summary>
        /// 16x16i -> 16x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<int> vinflate32i(Vector256<short> src, N512 w, int t)
            => vconvert32i(src, w);

        /// <summary>
        /// 32x8i -> (8x32i, 8x32i, 8x32i, 8x32i)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="x1">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<int> vinflate32i(Vector256<sbyte> src, N1024 w)
            => vconvert32i(src, w);

        /// <summary>
        /// 8x32u -> 8x64u
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Vector512<ulong> vinflate64u(Vector256<uint> src, N512 w)
            => vconvert64u(src, w);

        /// <summary>
        /// 8x32i -> 8x64i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The target for the lower source elements</param>
        /// <param name="hi">The target for the upper source elements</param>
        [MethodImpl(Inline), Op]
        public static Vector512<long> vinflate64i(Vector256<int> src, N512 w)
            => vconvert64i(src, w);

        /// <summary>
        /// 32x8u -> 32x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="x1">A target cell type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector1024<uint> vinflate32u(Vector256<byte> src, N1024 w, uint t = 0)
            => vconvert32u(src, w);

        /// <summary>
        /// 16x16u -> 16x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector512<uint> vinflate32u(Vector256<ushort> src, N512 w, uint t)
            => vconvert32u(src, w);
    }
}