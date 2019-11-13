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
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Produces the target vector by assembling components from two source vectors as specified by a control mask,
        /// dst[i] = testbit(control,i) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vblend8x32(Vector256<int> x, Vector256<int> y, Blend8x32 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8) VPBLENDD ymm, ymm, ymm/m256, imm8
        /// Produces the target vector by assembling components from two source vectors as specified by a control mask,
        /// dst[i] = testbit(control,i) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/vpblendd</remarks>
        [MethodImpl(Inline)]
        public static Vector256<uint> vblend8x32(Vector256<uint> x, Vector256<uint> y, Blend8x32 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask)VPBLENDVB ymm,ymm, ymm/m256, ymm
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vblend8x32(Vector256<int> x, Vector256<int> y, Vector256<int> spec)        
            => BlendVariable(x, y, spec);

        /// <summary>
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Produces the target vector by assembling components from two source vectors as specified by a control mask,
        /// dst[i] = testbit(control,i) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vblend8x32(Vector256<int> x, Vector256<int> y, byte spec)        
            => Blend(x, y, spec);

        /// <summary>
        /// __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8) VPBLENDD ymm, ymm, ymm/m256, imm8
        /// Produces the target vector by assembling components from two source vectors as specified by a control mask,
        /// dst[i] = testbit(control,i) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/vpblendd</remarks>
        [MethodImpl(Inline)]
        public static Vector256<uint> vblend8x32(Vector256<uint> x, Vector256<uint> y, byte spec)        
            => Blend(x, y, spec);

        /// <summary>
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask)VPBLENDVB ymm,
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component,
        /// z[i] = testbit(spec[i],7) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vblend8x32(Vector256<uint> x, Vector256<uint> y, Vector256<uint> spec)        
            => BlendVariable(x, y, spec);

    }

    /// <summary>
    /// Defines control mask values for blending eight 32-bit components from two vectors
    /// </summary>
    [Flags]
    public enum Blend8x32 : byte
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