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

        [MethodImpl(Inline), Op]
        public static Vector512<ushort> vinflate16u(in byte src, W256 w)
        {
           var lo = vinflate16u(vload(w128, src));
           var hi = vinflate16u(vload(w128, add(src, 16)));
           return gcpu.vconcat(lo,hi);
        }

        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vinflate16u(Vector256<byte> src, N0 lo)
            => vinflate16u(vlo(src));

        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vinflate16u(Vector256<byte> src, N1 hi)
            => vinflate16u(vhi(src));
    }
}