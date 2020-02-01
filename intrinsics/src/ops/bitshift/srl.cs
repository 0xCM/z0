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
    using static System.Runtime.Intrinsics.X86.Sse2;

    using static zfunc;
    using static As;

    partial class dinx
    {         
        /// <summary>
        /// Shifts each each component rightward by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The bitcount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vsrl(Vector128<byte> src, [Shift] byte count)
        {
            var y = v8u(ShiftRightLogical(v64u(src), count));
            var m = VMask.vlsb(n128, n8, (byte)(8 - count),z8);
            return dinx.vand(y,m);
        }

        /// <summary>
        /// Shifts each each component rightward by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The bitcount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vsrl(Vector128<sbyte> src, [Shift] byte count)
        {
            var x = v16u(ShiftRightLogical(vinflate(src, n256, z16i),count));
            var y = vand(x,v16u(CpuVector.vbroadcast(n256, byte.MaxValue)));
            return v8i(vcompact(y,n128,z8));
        } 

        /// <summary>
        /// __m128i _mm_srli_epi16 (__m128i a, int immediate) PSRLW xmm, imm8
        /// Shifts each each component rightward by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The bitcount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vsrl(Vector128<short> src, [Shift] byte count)
            => ShiftRightLogical(src, count);

        /// <summary>
        ///  __m128i _mm_srli_epi16 (__m128i a, int immediate) PSRLW xmm, imm8
        /// Shifts each each component rightward by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The bitcount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vsrl(Vector128<ushort> src, [Shift] byte count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// __m128i _mm_srli_epi32 (__m128i a, int immediate) PSRLD xmm, imm8
        /// Shifts each each component rightward by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The bitcount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vsrl(Vector128<int> src, [Shift] byte count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// __m128i _mm_srli_epi32 (__m128i a, int immediate) PSRLD xmm, imm8
        /// Shifts each each component rightward by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The bitcount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vsrl(Vector128<uint> src, [Shift] byte count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// __m128i _mm_srli_epi64 (__m128i a, int immediate) PSRLQ xmm, imm8
        /// Shifts each each component rightward by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The bitcount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vsrl(Vector128<long> src, [Shift] byte count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// __m128i _mm_srli_epi64 (__m128i a, int immediate) PSRLQ xmm, imm8
        /// Shifts each each component rightward by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The bitcount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vsrl(Vector128<ulong> src, [Shift] byte count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// Shifts each each component rightward by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The bitcount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vsrl(Vector256<sbyte> src, [Shift] byte count)
        {
            var x = v16u(ShiftRightLogical(vinflate(vlo(src), n256, z16i),count));
            var y = v16u(ShiftRightLogical(vinflate(vhi(src), n256, z16i),count));
            var m = v16u(CpuVector.vbroadcast(n256, byte.MaxValue));
            return v8i(vcompact(vand(x,m),vand(y,m),n256,z8));
        } 

        /// <summary>
        /// Shifts each each component rightward by a specified bitcount
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The bitcount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vsrl(Vector256<byte> src, [Shift] byte count)
        {
            var y = v8u(ShiftRightLogical(v64u(src), count));
            var m = VMask.vlsb(n256, n8, (byte)(8 - count),z8);
            return dinx.vand(y,m);
        } 

        /// <summary>
        /// __m256i _mm256_srli_epi16 (__m256i a, int imm8) VPSRLW ymm, ymm, imm8
        /// Shifts each each component rightward by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The bitcount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vsrl(Vector256<short> src, [Shift] byte count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// __m256i _mm256_srli_epi16 (__m256i a, int imm8) VPSRLW ymm, ymm, imm8
        /// Shifts each each component rightward by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The bitcount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vsrl(Vector256<ushort> src, [Shift] byte count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// __m256i _mm256_srli_epi32 (__m256i a, int imm8) VPSRLD ymm, ymm, imm8
        /// Shifts each each component rightward by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The bitcount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vsrl(Vector256<int> src, [Shift] byte count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// __m256i _mm256_srli_epi32 (__m256i a, int imm8) VPSRLD ymm, ymm, imm8
        /// Shifts each each component rightward by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The bitcount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vsrl(Vector256<uint> src, [Shift] byte count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// __m256i _mm256_srli_epi64 (__m256i a, int imm8) VPSRLQ ymm, ymm, imm8
        /// Shifts each each component rightward by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The bitcount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vsrl(Vector256<long> src, [Shift] byte count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// __m256i _mm256_srli_epi64 (__m256i a, int imm8) VPSRLQ ymm, ymm, imm8
        /// Shifts each each component rightward by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The bitcount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vsrl(Vector256<ulong> src, [Shift] byte count)
            => ShiftRightLogical(src, count); 
    }
}