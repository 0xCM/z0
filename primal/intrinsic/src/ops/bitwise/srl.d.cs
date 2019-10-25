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

    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;

    using static zfunc;
    using static As;

    partial class dinx
    {         
        /// <summary>
        /// Shifts the entire 128-bit vector rightwards at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits the shift rightward</param>
        /// <remarks>Taken from http://programming.sirrida.de</remarks>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsrlx(Vector128<ulong> src, byte offset)        
        {
            var x = dinx.vbsrl(src, 8);
            var y = dinx.vsrl(src, offset);
            return dinx.vor(y,dinx.vsll(x, (byte)(64 - offset)));
        }

        public static Vector256<byte> vsrl(Vector256<byte> src, byte offset)
        {
            //Fan the hi/lo parts of the u8 source vector across 2 u16 vectors
            var srcX = vconvert(dinx.vlo(src), out Vector256<ushort> _);
            var srcY = vconvert(dinx.vhi(src), out Vector256<ushort> _);
            
            //Shift each part with a concrete intrinsic anc convert back to bytes
            var dstA = dinx.vsrl(srcX, offset).AsByte();
            var dstB = dinx.vsrl(srcY, offset).AsByte();

            // Truncate overflows to sets up the component pattern [X 0 X 0 ... X 0] in each vector
            var trm = Vec256Pattern.ClearAltVector<byte>();
            var trA = dinx.vshuffle(dstA, trm);
            var trB = dinx.vshuffle(dstB, trm);
                        
            // Each vector contains 16 values that need to be merged
            // back into a single vector. The strategey is to condense
            // each vector via the "lane merge" pattern and construct
            // the result vector via insertion of these condensed vectors
            var permSpec = Vec256Pattern.LaneMergeVector<byte>();
            var permA = dinx.vpermvar32x8(trA, permSpec);
            var permB = dinx.vpermvar32x8(trB, permSpec);
            return dinx.insert(dinx.vlo(permA), dinx.vlo(permB), out Vector256<byte> _);            
        } 

        /// <summary>
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The offset amount</param>
        /// <remarks>See https://stackoverflow.com/questions/35002937/sse-simd-shift-with-one-byte-element-size-granularity
        /// for a potentially better approach</remarks>
        public static Vector128<sbyte> vsrl(Vector128<sbyte> src, byte offset)
        {
            dinx.vconvert(src, out Vector256<short> dst);
            Span<short> data = stackalloc short[Vector256<short>.Count];
            vstore(dinx.vsrl(dst, offset), ref data[0]);
            var i = 0;
            return Vector128.Create(
                (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], 
                (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++],
                (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++],
                (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++]
            );
        }

        /// <summary>
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The offset amount</param>
        /// <remarks>See https://stackoverflow.com/questions/35002937/sse-simd-shift-with-one-byte-element-size-granularity
        /// for a potentially better approach</remarks>
        public static Vector128<byte> vsrl(Vector128<byte> src, byte offset)
        {
            vconvert(src, out Vector256<ushort> dst);
            Span<ushort> data = stackalloc ushort[Vector256<ushort>.Count];
            vstore(dinx.vsrl(dst, offset), ref head(data));
            var i = 0;
            return Vector128.Create(
                (byte)data[i++], (byte)data[i++], (byte)data[i++], (byte)data[i++], 
                (byte)data[i++], (byte)data[i++], (byte)data[i++], (byte)data[i++],
                (byte)data[i++], (byte)data[i++], (byte)data[i++], (byte)data[i++],
                (byte)data[i++], (byte)data[i++], (byte)data[i++], (byte)data[i++]
            );
        }

        /// <summary>
        /// __m128i _mm_srli_epi16 (__m128i a, int immediate) PSRLW xmm, imm8
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vsrl(Vector128<short> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m128i _mm_srli_epi16 (__m128i a, int immediate) PSRLW xmm, imm8
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vsrl(Vector128<ushort> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m128i _mm_srli_epi32 (__m128i a, int immediate) PSRLD xmm, imm8
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vsrl(Vector128<int> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m128i _mm_srli_epi32 (__m128i a, int immediate) PSRLD xmm, imm8
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vsrl(Vector128<uint> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m128i _mm_srli_epi64 (__m128i a, int immediate) PSRLQ xmm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vsrl(Vector128<long> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m128i _mm_srli_epi64 (__m128i a, int immediate) PSRLQ xmm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsrl(Vector128<ulong> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_srli_epi16 (__m256i a, int imm8) VPSRLW ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vsrl(Vector256<short> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_srli_epi16 (__m256i a, int imm8) VPSRLW ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vsrl(Vector256<ushort> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_srli_epi32 (__m256i a, int imm8) VPSRLD ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vsrl(Vector256<int> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_srli_epi32 (__m256i a, int imm8) VPSRLD ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vsrl(Vector256<uint> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_srli_epi64 (__m256i a, int imm8) VPSRLQ ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vsrl(Vector256<long> src, byte offset)
            => ShiftRightLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_srli_epi64 (__m256i a, int imm8) VPSRLQ ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsrl(Vector256<ulong> src, byte offset)
            => ShiftRightLogical(src, offset); 

    }

}