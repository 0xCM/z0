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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;
        
    using static zfunc;
    
    partial class dinx
    {
        /// <summary>
        /// __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8)PBLENDW xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/pblendw</remarks>
        [MethodImpl(Inline)]
        public static Vec128<short> vblend(in Vec128<short> x, in Vec128<short> y, Blend16x8 spec)        
            => Blend(x.xmm, y.xmm, (byte)spec);

        /// <summary>
        /// __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8) PBLENDW xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vblend(in Vec128<ushort> x, in Vec128<ushort> y, Blend16x8 spec)        
            => Blend(x.xmm, y.xmm, (byte)spec);

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vblend(in Vec128<int> x, in Vec128<int> y, Blend32x4 spec)        
            => Blend(x.xmm, y.xmm, (byte)spec);

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        /// 
        [MethodImpl(Inline)]
        public static Vec128<uint> vblend(in Vec128<uint> x, in Vec128<uint> y, Blend32x4 spec)        
            => Blend(x.xmm, y.xmm, (byte)spec);

        /// <summary>
        /// __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vblend(in Vec256<short> x, in Vec256<short> y, Blend16x8 spec)        
            => Blend(x.ymm, y.ymm, (byte)spec);

        /// <summary>
        /// __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/pblendw</remarks>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vblend(in Vec256<ushort> x, in Vec256<ushort> y, Blend16x8 spec)        
            => Blend(x.ymm, y.ymm, (byte)spec);

        /// <summary>
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vblend(in Vec256<int> x, in Vec256<int> y, Blend32x8 spec)        
            => Blend(x.ymm, y.ymm, (byte)spec);

        /// <summary>
        /// __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8) VPBLENDD ymm, ymm, ymm/m256, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// dst[i] = testbit(control,i) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/vpblendd</remarks>
        [MethodImpl(Inline)]
        public static Vec256<uint> vblend(in Vec256<uint> x, in Vec256<uint> y, Blend32x8 spec)        
            => Blend(x.ymm, y.ymm, (byte)spec);
    }
}