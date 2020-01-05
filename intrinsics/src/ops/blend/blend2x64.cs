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
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8)BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vblend(Vector128<sbyte> x, Vector128<sbyte> y, Blend2x64 spec)        
            => v8i(Blend(v64f(x), v64f(y), (byte)spec));

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8)BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vblend(Vector128<byte> x, Vector128<byte> y, Blend2x64 spec)        
            => v8u(Blend(v64f(x), v64f(y), (byte)spec));

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8)BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vblend(Vector128<short> x, Vector128<short> y, Blend2x64 spec)        
            => v16i(Blend(v64f(x), v64f(y), (byte)spec));

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8)BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vblend(Vector128<ushort> x, Vector128<ushort> y, Blend2x64 spec)        
            => v16u(Blend(v64f(x), v64f(y), (byte)spec));

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8)BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vblend(Vector128<int> x, Vector128<int> y, Blend2x64 spec)        
            => v32i(Blend(v64f(x), v64f(y), (byte)spec));

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8)BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vblend(Vector128<uint> x, Vector128<uint> y, Blend2x64 spec)        
            => v32u(Blend(v64f(x), v64f(y), (byte)spec));

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8)BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vblend(Vector128<long> x, Vector128<long> y, Blend2x64 spec)        
            => v64i(Blend(v64f(x), v64f(y), (byte)spec));

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8)BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vblend(Vector128<ulong> x, Vector128<ulong> y, Blend2x64 spec)        
            => v64u(Blend(v64f(x), v64f(y), (byte)spec));

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8)BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<double> vblend(Vector128<double> x, Vector128<double> y, Blend2x64 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8)BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vblend(Vector128<ulong> x, Vector128<ulong> y, byte spec)        
            => v64u(Blend(v64f(x), v64f(y), spec));
    }
}