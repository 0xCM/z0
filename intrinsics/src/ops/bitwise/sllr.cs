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
        public static Vector128<short> vsllr(Vector128<short> src, Vector128<short> shift)
            => ShiftLeftLogical(src, shift);

        [MethodImpl(Inline)]
        public static Vector128<ushort> vsllr(Vector128<ushort> src, Vector128<ushort> shift)
            => ShiftLeftLogical(src, shift);

        [MethodImpl(Inline)]
        public static Vector128<int> vsllr(Vector128<int> src, Vector128<int> shift)
            => ShiftLeftLogical(src, shift);

        [MethodImpl(Inline)]
        public static Vector128<uint> vsllr(Vector128<uint> src, Vector128<uint> shift)
            => ShiftLeftLogical(src, shift);

        [MethodImpl(Inline)]
        public static Vector128<long> vsllr(Vector128<long> src, Vector128<long> shift)
            => ShiftLeftLogical(src, shift);

        [MethodImpl(Inline)]
        public static Vector128<ulong> vsllr(Vector128<ulong> src, Vector128<ulong> shift)
            => ShiftLeftLogical(src, shift);


        [MethodImpl(Inline)]
        public static Vector256<sbyte> vsllr(Vector256<sbyte> src, Vector128<sbyte> shift)
            => vsll(src, (byte)shift.Item(0));

        [MethodImpl(Inline)]
        public static Vector256<byte> vsllr(Vector256<byte> src, Vector128<byte> shift)
            => vsll(src, (byte)shift.Item(0));

        /// <summary>
        /// __m256i _mm256_sll_epi16 (__m256i a, __m128i count)VPSLLW ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        [MethodImpl(Inline)]
        public static Vector256<short> vsllr(Vector256<short> src, Vector128<short> shift)
            => ShiftLeftLogical(src, shift);

        /// <summary>
        /// __m256i _mm256_sll_epi16 (__m256i a, __m128i count) VPSLLW ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vsllr(Vector256<ushort> src, Vector128<ushort> shift)
            => ShiftLeftLogical(src, shift);

        /// <summary>
        ///  __m256i _mm256_sll_epi32 (__m256i a, __m128i count) VPSLLD ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<int> vsllr(Vector256<int> src, Vector128<int> shift)
            => ShiftLeftLogical(src, shift);

        /// <summary>
        ///  __m256i _mm256_sll_epi32 (__m256i a, __m128i count) VPSLLD ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vsllr(Vector256<uint> src, Vector128<uint> shift)
            => ShiftLeftLogical(src, shift);

        /// <summary>
        /// _m256i _mm256_sll_epi64 (__m256i a, __m128i count)VPSLLQ ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        [MethodImpl(Inline)]
        public static Vector256<long> vsllr(Vector256<long> src, Vector128<long> shift)
            => ShiftLeftLogical(src, shift);

        /// <summary>
        /// _m256i _mm256_sll_epi64 (__m256i a, __m128i count)VPSLLQ ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsllr(Vector256<ulong> src, Vector128<ulong> shift)
            => ShiftLeftLogical(src, shift);

        [MethodImpl(Inline)]
        public static Vector128<short> vsllr(Vector128<short> src, short shift)
            => vsllr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector128<ushort> vsllr(Vector128<ushort> src, ushort shift)
            => vsllr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector128<int> vsllr(Vector128<int> src, int shift)
            => vsllr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector128<uint> vsllr(Vector128<uint> src, uint shift)
            => vsllr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector128<long> vsllr(Vector128<long> src, long shift)
            => vsllr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector128<ulong> vsllr(Vector128<ulong> src, ulong shift)
            => vsllr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector256<short> vsllr(Vector256<short> src, short shift)
            => vsllr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector256<ushort> vsllr(Vector256<ushort> src, ushort shift)
            => vsllr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector256<int> vsllr(Vector256<int> src, int shift)
            => vsllr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector256<uint> vsllr(Vector256<uint> src, uint shift)
            => vsllr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector256<long> vsllr(Vector256<long> src, long shift)
            => vsllr(src, vscalar(n128,shift));

        [MethodImpl(Inline)]
        public static Vector256<ulong> vsllr(Vector256<ulong> src, ulong shift)
            => vsllr(src, vscalar(n128,shift));

    }

}