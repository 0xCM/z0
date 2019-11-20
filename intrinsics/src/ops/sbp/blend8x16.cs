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
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vblend8x16(Vector128<sbyte> x, Vector128<sbyte> y, Blend8x16 spec)        
            => v8i(Blend(v16u(x), v16u(y), (byte)spec));

        /// <summary>
        /// __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8)PBLENDW xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vblend8x16(Vector128<byte> x, Vector128<byte> y, Blend8x16 spec)        
            => v8u(Blend(v16u(x), v16u(y), (byte)spec));

        /// <summary>
        /// __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8)PBLENDW xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vblend8x16(Vector128<short> x, Vector128<short> y, Blend8x16 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8
        /// Combines components from left/right vectors within 128-bit lanes per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vblend8x16(Vector256<short> x, Vector256<short> y, Blend8x16 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8) PBLENDW xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vblend8x16(Vector128<ushort> x, Vector128<ushort> y, Blend8x16 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8)PBLENDW xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vblend8x16(Vector128<int> x, Vector128<int> y, Blend8x16 spec)        
            => v32i(Blend(v16u(x), v16u(y), (byte)spec));

        /// <summary>
        /// __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8)PBLENDW xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vblend8x16(Vector128<uint> x, Vector128<uint> y, Blend8x16 spec)        
            => v32u(Blend(v16u(x), v16u(y), (byte)spec));

        /// <summary>
        /// __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8)PBLENDW xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vblend8x16(Vector128<long> x, Vector128<long> y, Blend8x16 spec)        
            => v64i(Blend(v16u(x), v16u(y), (byte)spec));

        /// <summary>
        /// __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8)PBLENDW xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vblend8x16(Vector128<ulong> x, Vector128<ulong> y, Blend8x16 spec)        
            => v64u(Blend(v16u(x), v16u(y), (byte)spec));

        /// <summary>
        /// __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8
        /// Combines components from left/right vectors within 128-bit lanes per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vblend8x16(Vector256<sbyte> x, Vector256<sbyte> y, Blend8x16 spec)        
            => v8i(Blend(v16u(x), v16u(y), (byte)spec));

        /// <summary>
        /// __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8
        /// Combines components from left/right vectors within 128-bit lanes per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vblend8x16(Vector256<byte> x, Vector256<byte> y, Blend8x16 spec)        
            => v8u(Blend(v16u(x), v16u(y), (byte)spec));

        /// <summary>
        /// __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8
        /// Combines components from left/right vectors within 128-bit lanes per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vblend8x16(Vector256<ushort> x, Vector256<ushort> y, Blend8x16 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8
        /// Combines components from left/right vectors within 128-bit lanes per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vblend8x16(Vector256<int> x, Vector256<int> y, Blend8x16 spec)        
            => v32i(Blend(v16u(x), v16u(y), (byte)spec));

        /// <summary>
        /// __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8
        /// Combines components from left/right vectors within 128-bit lanes per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vblend8x16(Vector256<uint> x, Vector256<uint> y, Blend8x16 spec)        
            => v32u(Blend(v16u(x), v16u(y), (byte)spec));

        /// <summary>
        /// __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8
        /// Combines components from left/right vectors within 128-bit lanes per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vblend8x16(Vector256<long> x, Vector256<long> y, Blend8x16 spec)        
            => v64i(Blend(v16u(x), v16u(y), (byte)spec));

        /// <summary>
        /// __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8
        /// Combines components from left/right vectors within 128-bit lanes per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vblend8x16(Vector256<ulong> x, Vector256<ulong> y, Blend8x16 spec)        
            => v64u(Blend(v16u(x), v16u(y), (byte)spec));

        /// <summary>
        /// __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8)PBLENDW xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vblend8x16(Vector128<short> x, Vector128<short> y, byte spec)        
            => Blend(x, y, spec);

        /// <summary>
        /// __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8) PBLENDW xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vblend8x16(Vector128<ushort> x, Vector128<ushort> y, byte spec)        
            => Blend(x, y, spec); 


    }

    /// <summary>
    /// Defines control mask values for blending eight 16-bit components from two vectors
    /// </summary>
    [Flags]
    public enum Blend8x16 : byte
    {
        L = 0,        

        R = 1,

        LLLLLLLL = 0,

        RRRRRRRR = 0b11111111,

        LRLRLRLR = 0b10101010,

        RLRLRLRL = 0b01010101,

        LLRRLLRR = 0b11001100,

        RRLLRRLL = 0b00110011,

        LLLLRRRR = 0b11110000,

        RRRRLLLL = 0b00001111
    }
}