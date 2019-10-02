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
        ///  __m256i _mm256_mulhrs_epi16 (__m256i a, __m256i b)VPMULHRSW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public static Vec256<short> mulhrs(in Vec256<short> lhs, in Vec256<short> rhs)
            => MultiplyHighRoundScale(lhs.ymm,rhs.ymm);

        /// <summary>
        /// __m128i _mm_mulhrs_epi16 (__m128i a, __m128i b)PMULHRSW xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec128<short> mulhrs(in Vec128<short> lhs, in Vec128<short> rhs)
            => MultiplyHighRoundScale(lhs.xmm,rhs.xmm);

        /// <summary>
        /// _mm_mul_epi32
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<long> mul(in Vec128<int> lhs, in Vec128<int> rhs)
            => Multiply(lhs, rhs);
            
        /// <summary>
        /// _mm_mul_epu32
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        static Vec128<ulong> mul(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Multiply(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_mul_epi32 (__m256i a, __m256i b) VPMULDQ ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<long> mul(in Vec256<int> lhs,in Vec256<int> rhs)
            => Multiply(lhs, rhs);


        /// <summary>
        /// _mm256_mul_epu32
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        static Vec256<ulong> mul(in Vec256<uint> lhs,in Vec256<uint> rhs)
            => Multiply(lhs, rhs);
                        
        /// <summary>
        /// Multiplies two two 256-bit/u64 vectors to yield a 256-bit/u64 vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> mul(in Vec256<ulong> x, in Vec256<ulong> y)    
        {
            var loMask = Vec256.Fill(0x00000000fffffffful);    
            var xl = dinx.vand(x, loMask).As<uint>();
            var xh = dinx.vsrl(x, 32).As<uint>();
            var yl = dinx.vand(y, loMask).As<uint>();
            var yh = dinx.vsrl(y, 32).As<uint>();

            var xh_yl = dinx.mul(xh, yl);
            var hl = dinx.vsll(in xh_yl, 32);

            var xh_mh = dinx.mul(xh, yh);
            var lh = dinx.vsll(xh_mh, 32);

            var xl_yl = dinx.mul(xl, yl);

            var hl_lh = dinx.vadd(hl, lh);
            var z = dinx.vadd(xl_yl, hl_lh);
            return z;
        }
    }
}