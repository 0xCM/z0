//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// __m128i _mm_blendv_epi8 (__m128i a, __m128i b, __m128i mask) PBLENDVB xmm, xmm/m128, xmm
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vblend(Vector128<byte> x, Vector128<byte> y, Vector128<byte> spec)        
            =>  BlendVariable(x, y, spec);

        /// <summary>
        /// __m128i _mm_blendv_epi8 (__m128i a, __m128i b, __m128i mask)PBLENDVB xmm, xmm/m128, xmm
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vblend(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<byte> spec)        
            => BlendVariable(x, y, v8i(spec));

        /// <summary>
        /// __m128i _mm_blendv_epi8 (__m128i a, __m128i b, __m128i mask) PBLENDVB xmm, xmm/m128, xmm
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vblend(Vector128<short> x, Vector128<short> y, Vector128<byte> spec)        
            => BlendVariable(x, y, v16i(spec));

        /// <summary>
        /// __m128i _mm_blendv_epi8 (__m128i a, __m128i b, __m128i mask) PBLENDVB xmm, xmm/m128, xmm
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vblend(Vector128<ushort> x, Vector128<ushort> y, Vector128<byte> spec)        
            => BlendVariable(x, y, v16u(spec));

        /// <summary>
        /// __m128i _mm_blendv_epi8 (__m128i a, __m128i b, __m128i mask) PBLENDVB xmm, xmm/m128, xmm
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vblend(Vector128<int> x, Vector128<int> y, Vector128<byte> spec)        
            => BlendVariable(x, y, v32i(spec));

        /// <summary>
        /// __m128i _mm_blendv_epi8 (__m128i a, __m128i b, __m128i mask) PBLENDVB xmm, xmm/m128, xmm
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vblend(Vector128<uint> x, Vector128<uint> y, Vector128<byte> spec)        
            => BlendVariable(x, y, v32u(spec));

        /// <summary>
        /// __m128i _mm_blendv_epi8 (__m128i a, __m128i b, __m128i mask) PBLENDVB xmm, xmm/m128, xmm
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vblend(Vector128<long> x, Vector128<long> y, Vector128<byte> spec)        
            => BlendVariable(x, y, v64i(spec));

        /// <summary>
        /// __m128i _mm_blendv_epi8 (__m128i a, __m128i b, __m128i mask) PBLENDVB xmm, xmm/m128, xmm
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vblend(Vector128<ulong> x, Vector128<ulong> y, Vector128<byte> spec)        
            => BlendVariable(x, y, v64u(spec));

        /// <summary>
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm,ymm, ymm/m256, ymm
        /// Forms a vector z[i] = testbit(spec[i],7) ? x[i] : y[i] where i = 0,...31
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/pblendvb</remarks>
        [MethodImpl(Inline)]
        public static Vector256<byte> vblend(Vector256<byte> x, Vector256<byte> y, Vector256<byte> spec)        
            => BlendVariable(x, y, spec);

        /// <summary>
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm,ymm, ymm/m256, ymm
        /// Forms a vector z[i] = testbit(spec[i],7) ? x[i] : y[i] where i = 0,...31
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/pblendvb</remarks>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vblend(Vector256<sbyte> x, Vector256<sbyte> y, Vector256<byte> spec)        
            => BlendVariable(x, y, v8i(spec));

        /// <summary>
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm,ymm, ymm/m256, ymm
        /// Forms a vector z[i] = testbit(spec[i],7) ? x[i] : y[i] where i = 0,...31
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/pblendvb</remarks>
        [MethodImpl(Inline)]
        public static Vector256<short> vblend(Vector256<short> x, Vector256<short> y, Vector256<byte> spec)        
            => BlendVariable(x, y, v16i(spec));

        /// <summary>
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm,ymm, ymm/m256, ymm
        /// Forms a vector z[i] = testbit(spec[i],7) ? x[i] : y[i] where i = 0,...31
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/pblendvb</remarks>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vblend(Vector256<ushort> x, Vector256<ushort> y, Vector256<byte> spec)        
            => BlendVariable(x, y, v16u(spec));

        /// <summary>
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm,ymm, ymm/m256, ymm
        /// Forms a vector z[i] = testbit(spec[i],7) ? x[i] : y[i] where i = 0,...31
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/pblendvb</remarks>
        [MethodImpl(Inline)]
        public static Vector256<int> vblend(Vector256<int> x, Vector256<int> y, Vector256<byte> spec)        
            => BlendVariable(x, y, v32i(spec));

        /// <summary>
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm,ymm, ymm/m256, ymm
        /// Forms a vector z[i] = testbit(spec[i],7) ? x[i] : y[i] where i = 0,...31
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/pblendvb</remarks>
        [MethodImpl(Inline)]
        public static Vector256<uint> vblend(Vector256<uint> x, Vector256<uint> y, Vector256<byte> spec)        
            => BlendVariable(x, y, v32u(spec));

        /// <summary>
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm,ymm, ymm/m256, ymm
        /// Forms a vector z[i] = testbit(spec[i],7) ? x[i] : y[i] where i = 0,...31
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/pblendvb</remarks>
        [MethodImpl(Inline)]
        public static Vector256<long> vblend(Vector256<long> x, Vector256<long> y, Vector256<byte> spec)        
            => BlendVariable(x, y, v64i(spec));

        /// <summary>
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm,ymm, ymm/m256, ymm
        /// Forms a vector z[i] = testbit(spec[i],7) ? x[i] : y[i] where i = 0,...31
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/pblendvb</remarks>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vblend(Vector256<ulong> x, Vector256<ulong> y, Vector256<byte> spec)        
            => BlendVariable(x, y, v64u(spec)); 

    }

}