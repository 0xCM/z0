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
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm,ymm, ymm/m256, ymm
        /// Forms a vector z[i] = testbit(spec[i],7) ? x[i] : y[i] where i = 0,...31
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/pblendvb</remarks>
        [MethodImpl(Inline)]
        public static Vector256<byte> vblend32x8(Vector256<byte> x, Vector256<byte> y, Vector256<byte> spec)        
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
        public static Vector256<sbyte> vblend32x8(Vector256<sbyte> x, Vector256<sbyte> y, Vector256<byte> spec)        
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
        public static Vector256<short> vblend32x8(Vector256<short> x, Vector256<short> y, Vector256<byte> spec)        
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
        public static Vector256<ushort> vblend32x8(Vector256<ushort> x, Vector256<ushort> y, Vector256<byte> spec)        
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
        public static Vector256<int> vblend32x8(Vector256<int> x, Vector256<int> y, Vector256<byte> spec)        
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
        public static Vector256<uint> vblend32x8(Vector256<uint> x, Vector256<uint> y, Vector256<byte> spec)        
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
        public static Vector256<long> vblend32x8(Vector256<long> x, Vector256<long> y, Vector256<byte> spec)        
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
        public static Vector256<ulong> vblend32x8(Vector256<ulong> x, Vector256<ulong> y, Vector256<byte> spec)        
            => BlendVariable(x, y, v64u(spec));

    }
}