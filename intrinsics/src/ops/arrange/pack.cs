//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;

    using static zfunc;
    using static As;

    partial class dinx
    {

        /// <summary>
        ///  __m128i _mm_packus_epi16 (__m128i a, __m128i b)PACKUSWB xmm, xmm/m128
        /// (8x16w,8x16w) -> 16x8w
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vpackus(Vector128<ushort> x, Vector128<ushort> y)
            => PackUnsignedSaturate(x.AsInt16(),y.AsInt16());

        /// <summary>
        ///__m128i _mm_packus_epi32 (__m128i a, __m128i b)PACKUSDW xmm, xmm/m128 
        /// (4x32w,4x32w) -> 8x16w
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vpackus(Vector128<uint> x, Vector128<uint> y)
            => PackUnsignedSaturate(x.AsInt32(),y.AsInt32());

        /// <summary>
        /// __m256i _mm256_packus_epi16 (__m256i a, __m256i b) VPACKUSWB ymm, ymm, ymm/m256
        /// (16x8w,16x8w) -> 32x8w
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vpackus(Vector256<ushort> x, Vector256<ushort> y)
            => PackUnsignedSaturate(x.AsInt16(),y.AsInt16());

        /// <summary>
        /// __m256i _mm256_packus_epi32 (__m256i a, __m256i b) VPACKUSDW ymm, ymm, ymm/m256
        /// (8x32w,8x32w) -> 16x16w
        /// [0, 1, 2, 3, 8, 9, 10, 11, 4, 5, 6, 7, 12, 13, 14, 15]
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vpackus(Vector256<uint> x, Vector256<uint> y)
            => PackUnsignedSaturate(x.AsInt32(), y.AsInt32());

        /// <summary>
        ///  __m128i _mm_packus_epi16 (__m128i a, __m128i b)PACKUSWB xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vpackus(Vector128<short> x, Vector128<short> y)
            => PackUnsignedSaturate(x,y);

        /// <summary>
        /// __m256i _mm256_packus_epi16 (__m256i a, __m256i b)VPACKUSWB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vpackus(Vector256<short> x, Vector256<short> y)
            => PackUnsignedSaturate(x,y);

        /// <summary>
        /// __m256i _mm256_packus_epi32 (__m256i a, __m256i b)VPACKUSDW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vpackus(Vector256<int> x, Vector256<int> y)
            => PackUnsignedSaturate(x,y);

        /// <summary>
        ///__m128i _mm_packus_epi32 (__m128i a, __m128i b)PACKUSDW xmm, xmm/m128 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vpackus(Vector128<int> x, Vector128<int> y)
            => PackUnsignedSaturate(x,y);

        /// <summary>
        ///  __m128i _mm_packs_epi16 (__m128i a, __m128i b)PACKSSWB xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vpackss(Vector128<short> x, Vector128<short> y)
            => PackSignedSaturate(x,y);

        /// <summary>
        /// __m128i _mm_packs_epi32 (__m128i a, __m128i b)PACKSSDW xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector128<short> vpackss(Vector128<int> x, Vector128<int> y)
            => PackSignedSaturate(x,y);

        /// <summary>
        /// __m256i _mm256_packs_epi16 (__m256i a, __m256i b)VPACKSSWB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vpackss(Vector256<short> x, Vector256<short> y)
            => PackSignedSaturate(x,y);

        /// <summary>
        /// __m256i _mm256_packs_epi32 (__m256i a, __m256i b)VPACKSSDW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Vector256<short> vpackss(Vector256<int> x, Vector256<int> y)
            =>  PackSignedSaturate(x,y);


    }
}