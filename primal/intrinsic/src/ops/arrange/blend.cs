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

    /// <summary>
    /// Defines control mask values for blending four 32-bit components from two vectors
    /// </summary>
    [Flags]
    public enum Blend32x4 : byte
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

    /// <summary>
    /// Defines control mask values for blending eight 32-bit components from two vectors
    /// </summary>
    [Flags]
    public enum Blend32x8 : byte
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
        

    [Flags]
    public enum Blend16x8 : byte
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
    

    partial class dinx
    {
        /// <summary>
        /// __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8)PBLENDW xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/pblendw</remarks>
        [MethodImpl(Inline)]
        public static Vec128<short> vblend(in Vec128<short> x, in Vec128<short> y, Blend16x8 control)        
            => Blend(x.xmm, y.xmm, (byte)control);

        /// <summary>
        /// __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8) PBLENDW xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vblend(in Vec128<ushort> x, in Vec128<ushort> y, Blend16x8 control)        
            => Blend(x.xmm, y.xmm, (byte)control);

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vblend(in Vec128<int> x, in Vec128<int> y, Blend32x4 control)        
            => Blend(x.xmm, y.xmm, (byte)control);

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        /// 
        [MethodImpl(Inline)]
        public static Vec128<uint> vblend(in Vec128<uint> x, in Vec128<uint> y, Blend32x4 control)        
            => Blend(x.xmm, y.xmm, (byte)control);

        /// <summary>
        /// __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vblend(in Vec256<short> x, in Vec256<short> y, Blend16x8 control)        
            => Blend(x.ymm, y.ymm, (byte)control);

        /// <summary>
        /// __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/pblendw</remarks>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vblend(in Vec256<ushort> x, in Vec256<ushort> y, Blend16x8 control)        
            => Blend(x.ymm, y.ymm, (byte)control);

        /// <summary>
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vblend(in Vec256<int> x, in Vec256<int> y, Blend32x8 control)        
            => Blend(x.ymm, y.ymm, (byte)control);

        /// <summary>
        /// __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8) VPBLENDD ymm, ymm, ymm/m256, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// dst[i] = testbit(control,i) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/vpblendd</remarks>
        [MethodImpl(Inline)]
        public static Vec256<uint> vblend(in Vec256<uint> x, in Vec256<uint> y, Blend32x8 control)        
            => Blend(x.ymm, y.ymm, (byte)control);

        /// <summary>
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm,ymm, ymm/m256, ymm
        /// Creates a target vector from source components as determined by the hi bit of each 
        /// corresponding control vector component: dst[i] = testbit(control[i],7) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        /// <remarks>https://www.felixcloutier.com/x86/pblendvb</remarks>
        [MethodImpl(Inline)]
        public static Vec256<byte> vblendv(in Vec256<byte> x, in Vec256<byte> y, in Vec256<byte> control)        
            =>  BlendVariable(x.ymm, y.ymm, control);

        /// <summary>
        /// __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm,ymm, ymm/m256, ymm
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vblendv(in Vec256<sbyte> x, in Vec256<sbyte> y, in Vec256<sbyte> control)        
            => BlendVariable(x.ymm, y.ymm, control);

        /// <summary>
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vblendv(in Vec256<short> x, in Vec256<short> y, in Vec256<short> control)        
            => BlendVariable(x.ymm, y.ymm, control);

        /// <summary>
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vblendv(in Vec256<ushort> x, in Vec256<ushort> y, in Vec256<ushort> control)        
            => BlendVariable(x.ymm, y.ymm, control);

        /// <summary>
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vblendv(in Vec256<int> x, in Vec256<int> y, in Vec256<int> control)        
            => BlendVariable(x.ymm, y.ymm, control);

        /// <summary>
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vblendv(in Vec256<uint> x, in Vec256<uint> y, in Vec256<uint> control)        
            => BlendVariable(x.ymm, y.ymm, control);

        /// <summary>
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vblendv(in Vec256<long> x, in Vec256<long> y, in Vec256<long> control)        
            => BlendVariable(x.ymm, y.ymm, control);

        /// <summary>
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vblendv(in Vec256<ulong> x, in Vec256<ulong> y, in Vec256<ulong> control)        
            => BlendVariable(x.ymm, y.ymm, control);
    }

}