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
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vblend8x32(Vector256<sbyte> x, Vector256<sbyte> y, Blend8x32 spec)        
            => v8i(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vblend8x32(Vector256<byte> x, Vector256<byte> y, Blend8x32 spec)        
            => v8u(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vblend8x32(Vector256<short> x, Vector256<short> y, Blend8x32 spec)        
            => v16i(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vblend8x32(Vector256<ushort> x, Vector256<ushort> y, Blend8x32 spec)        
            => v16u(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vblend8x32(Vector256<int> x, Vector256<int> y, Blend8x32 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8) VPBLENDD ymm, ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vblend8x32(Vector256<uint> x, Vector256<uint> y, Blend8x32 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vblend8x32(Vector256<long> x, Vector256<long> y, Blend8x32 spec)        
            => v64i(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vblend8x32(Vector256<ulong> x, Vector256<ulong> y, Blend8x32 spec)        
            => v64u(Blend(v32u(x), v32u(y), (byte)spec));


        /// <summary>
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vblend8x32(Vector256<int> x, Vector256<int> y, byte spec)        
            => Blend(x, y, spec);

        /// <summary>
        /// __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8) VPBLENDD ymm, ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vblend8x32(Vector256<uint> x, Vector256<uint> y, byte spec)        
            => Blend(x, y, spec);
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