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
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vblend4x32(Vector128<int> x, Vector128<int> y, Blend4x32 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vblend4x32(Vector128<int> x, Vector128<int> y, byte spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vblend4x32(Vector128<uint> x, Vector128<uint> y, Blend4x32 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vblend4x32(Vector128<uint> x, Vector128<uint> y, byte spec)        
            => Blend(x, y, spec);


    }

    /// <summary>
    /// Defines control mask values for blending four 32-bit components from two vectors
    /// </summary>
    [Flags]
    public enum Blend4x32 : byte
    {
        /// <summary>
        /// Selects all components from the left vector
        /// </summary>
        LLLL = 0b0000,

        LLLR = 0b1000,

        RLLL = 0b0001,

        LLRL = 0b0100,

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
        /// Selects all components from the right vector
        /// </summary>
        RRRR = 0b1111
    }

}