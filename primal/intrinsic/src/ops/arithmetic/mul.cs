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

    using static System.Runtime.Intrinsics.X86.Pclmulqdq;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Ssse3;

    using static zfunc;
    using static As;

    partial class dinx
    {
        /// <summary>
        /// __m128i _mm_mulhrs_epi16 (__m128i a, __m128i b)PMULHRSW xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vmulhrs(Vector128<short> x, Vector128<short> y)
            => MultiplyHighRoundScale(x,y);

        /// <summary>
        ///  __m256i _mm256_mulhrs_epi16 (__m256i a, __m256i b)VPMULHRSW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        public static Vector256<short> vmulhrs(Vector256<short> x, Vector256<short> y)
            => MultiplyHighRoundScale(x,y);

        /// <summary>
        ///  __m128i _mm_mul_epi32 (__m128i a, __m128i b)PMULDQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vmul(in Vec128<int> x, in Vec128<int> y)
            => Multiply(x.xmm, y.xmm);

        /// <summary>
        ///  __m128i _mm_mul_epi32 (__m128i a, __m128i b)PMULDQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vmul(Vector128<int> x, Vector128<int> y)
            => Multiply(x, y);

        /// <summary>
        /// __m128i _mm_mul_epu32 (__m128i a, __m128i b)PMULUDQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vmul(Vector128<uint> x, Vector128<uint> y)
            => Multiply(x, y);

        /// <summary>
        /// __m256i _mm256_mul_epi32 (__m256i a, __m256i b) VPMULDQ ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vmul(Vector256<int> x,Vector256<int> y)
            => Multiply(x, y);

        /// <summary>
        ///  __m256i _mm256_mul_epu32 (__m256i a, __m256i b)VPMULUDQ ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vmul(Vector256<uint> x,Vector256<uint> y)
            => Multiply(x, y);
                        
        /// <summary>
        /// Multiplies two two 256-bit/u64 vectors to yield a 256-bit/u64 vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        public static Vector256<ulong> vmul(Vector256<ulong> x, Vector256<ulong> y)    
        {
            var loMask = ginx.vbroadcast(n256, 0x00000000fffffffful);  
              
            var xl = dinx.vand(x, loMask).AsUInt32();
            var xh = dinx.vsrl(x, 32).AsUInt32();
            var yl = dinx.vand(y, loMask).AsUInt32();
            var yh = dinx.vsrl(y, 32).AsUInt32();

            var xh_yl = dinx.vmul(xh, yl);
            var hl = dinx.vsll(xh_yl, 32);

            var xh_mh = dinx.vmul(xh, yh);
            var lh = dinx.vsll(xh_mh, 32);

            var xl_yl = dinx.vmul(xl, yl);

            var hl_lh = dinx.vadd(hl, lh);
            var z = dinx.vadd(xl_yl, hl_lh);
            return z;
        }
    }
}