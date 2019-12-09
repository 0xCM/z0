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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;
    
    partial class dinx
    {           

        [MethodImpl(Inline)]
        public static Vector128<short> vsrlr(Vector128<short> src, Vector128<short> shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m128i _mm_srl_epi16 (__m128i a, __m128i count)PSRLW xmm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vsrlr(Vector128<ushort> src, Vector128<ushort> shift)
            => ShiftRightLogical(src, shift);

        [MethodImpl(Inline)]
        public static Vector128<int> vsrlr(Vector128<int> src, Vector128<int> shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m128i _mm_srl_epi32 (__m128i a, __m128i count)PSRLD xmm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector128<uint> vsrlr(Vector128<uint> src, Vector128<uint> shift)
            => ShiftRightLogical(src, shift);

        [MethodImpl(Inline)]
        public static Vector128<long> vsrlr(Vector128<long> src, Vector128<long> shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m128i _mm_srl_epi64 (__m128i a, __m128i count)PSRLQ xmm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsrlr(Vector128<ulong> src, Vector128<ulong> shift)
            => ShiftRightLogical(src, shift);


        [MethodImpl(Inline)]
        public static Vector256<sbyte> vsrlr(Vector256<sbyte> src, Vector128<sbyte> shift)
            => vsll(src, (byte)shift.Item(0));

        [MethodImpl(Inline)]
        public static Vector256<byte> vsrlr(Vector256<byte> src, Vector128<byte> shift)
            => vsll(src, (byte)shift.Item(0));

        /// <summary>
        /// __m256i _mm256_srl_epi16 (__m256i a, __m128i count)VPSRLW ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        [MethodImpl(Inline)]
        public static Vector256<short> vsrlr(Vector256<short> src, Vector128<short> shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m256i _mm256_srl_epi16 (__m256i a, __m128i count)VPSRLW ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vsrlr(Vector256<ushort> src, Vector128<ushort> shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        ///  __m256i _mm256_srl_epi32 (__m256i a, __m128i count) VPSRLD ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<int> vsrlr(Vector256<int> src, Vector128<int> shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        ///  __m256i _mm256_srl_epi32 (__m256i a, __m128i count) VPSRLD ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vsrlr(Vector256<uint> src, Vector128<uint> shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m256i _mm256_srl_epi64 (__m256i a, __m128i count) VPSRLQ ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        [MethodImpl(Inline)]
        public static Vector256<long> vsrlr(Vector256<long> src, Vector128<long> shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m256i _mm256_srl_epi64 (__m256i a, __m128i count) VPSRLQ ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsrlr(Vector256<ulong> src, Vector128<ulong> shift)
            => ShiftRightLogical(src, shift);

        [MethodImpl(Inline)]
        public static Vector128<short> vsrlr(Vector128<short> src, short shift)
            => vsrlr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector128<ushort> vsrlr(Vector128<ushort> src, ushort shift)
            => vsrlr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector128<int> vsrlr(Vector128<int> src, int shift)
            => vsrlr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector128<uint> vsrlr(Vector128<uint> src, uint shift)
            => vsrlr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector128<long> vsrlr(Vector128<long> src, long shift)
            => vsrlr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector128<ulong> vsrlr(Vector128<ulong> src, ulong shift)
            => vsrlr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector256<short> vsrlr(Vector256<short> src, short shift)
            => vsrlr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector256<ushort> vsrlr(Vector256<ushort> src, ushort shift)
            => vsrlr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector256<int> vsrlr(Vector256<int> src, int shift)
            => vsrlr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector256<uint> vsrlr(Vector256<uint> src, uint shift)
            => vsrlr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector256<long> vsrlr(Vector256<long> src, long shift)
            => vsrlr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector256<ulong> vsrlr(Vector256<ulong> src, ulong shift)
            => vsrlr(src, vscalar(n128,shift));

    }

}