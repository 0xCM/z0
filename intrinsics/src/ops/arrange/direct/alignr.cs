//-----------------------------------------------------------------------------
// Copyy   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Ssse3;
    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static Root;    

    partial class dinx
    {        
        /// <summary>
        /// __m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count)PALIGNR xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="offset"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> valignr(Vector128<ulong> x, Vector128<ulong> y, [Imm] byte offset)
            => AlignRight(x, y, offset);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count) VPALIGNR ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="offset"></param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> valignr(Vector256<ulong> x, Vector256<ulong> y, [Imm] byte offset)
            => AlignRight(x, y, offset);

        /// <summary>
        /// __m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count) PALIGNR xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="offset"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, [Imm] byte offset)
            => AlignRight(x, y, offset);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="offset"></param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, [Imm] byte offset)
            => AlignRight(x, y, offset);
    }
}