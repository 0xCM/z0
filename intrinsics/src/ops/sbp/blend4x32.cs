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
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vblend4x32(Vector128<byte> x, Vector128<byte> y, Blend4x32 spec)        
            => v8u(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vblend4x32(Vector128<sbyte> x, Vector128<sbyte> y, Blend4x32 spec)        
            => v8i(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vblend4x32(Vector128<short> x, Vector128<short> y, Blend4x32 spec)        
            => v16i(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vblend4x32(Vector128<ushort> x, Vector128<ushort> y, Blend4x32 spec)        
            => v16u(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vblend4x32(Vector128<int> x, Vector128<int> y, Blend4x32 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vblend4x32(Vector128<uint> x, Vector128<uint> y, Blend4x32 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vblend4x32(Vector128<ulong> x, Vector128<ulong> y, Blend4x32 spec)        
            => v64u(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vblend4x32(Vector128<long> x, Vector128<long> y, Blend4x32 spec)        
            => v64i(Blend(v32u(x), v32u(y), (byte)spec));
            
        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vblend4x32(Vector128<int> x, Vector128<int> y, byte spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vblend4x32(Vector128<uint> x, Vector128<uint> y, byte spec)        
            => Blend(x, y, spec);

    }

    /// <summary>
    /// Defines control mask values for blending four 32-bit segments from two 128-bit vectors
    /// </summary>
    [Flags]
    public enum Blend4x32 : byte
    {
        /// <summary>
        /// ([0 1 2 3], [4 5 6 7]) -> [0 1 2 3]
        /// </summary>
        LLLL = 0b0000,

        /// <summary>
        /// ([0 1 2 3], [4 5 6 7]) -> [0 1 2 7]
        /// </summary>
        LLLR = 0b1000,

        /// <summary>
        /// ([0 1 2 3], [4 5 6 7]) -> [4 1 2 3]
        /// </summary>
        RLLL = 0b0001,

        /// <summary>
        /// ([0 1 2 3], [4 5 6 7]) -> [0 1 6 3]
        /// </summary>
        LLRL = 0b0100,

        /// <summary>
        /// ([0 1 2 3], [4 5 6 7]) -> [0 1 6 7]
        /// </summary>
        LLRR = 0b1100,

        LRLL = 0b0010,

        RLRL = 0b0101,

        LRRL = 0b0110,

        RRRL = 0b0111,

        RLLR = 0b1001,

        LRLR = 0b1010,

        RLRR = 0b1011,

        RRLL = 0b1100,

        RRLR = 0b1101,
        
        LRRR = 0b1110,
        
        /// <summary>
        /// ([0 1 2 3], [4 5 6 7]) -> [4 5 6 7]
        /// </summary>
        RRRR = 0b1111
    }
}