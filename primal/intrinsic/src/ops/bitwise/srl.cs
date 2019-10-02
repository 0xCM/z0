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
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The offset amount</param>
        /// <remarks>See https://stackoverflow.com/questions/35002937/sse-simd-shift-with-one-byte-element-size-granularity
        /// for a potentially better approach</remarks>
        public static Vec128<sbyte> vsrl(in Vec128<sbyte> src, byte offset)
        {
            dinx.convert(in src, out Vec256<short> dst);
            Span<short> data = stackalloc short[Vec256<short>.Length];
            vstore(dinx.vsrl(dst, offset), ref data[0]);
            var i = 0;
            return Vec128.FromParts(
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
        public static Vec128<byte> vsrl(in Vec128<byte> src, byte offset)
        {
            convert(in src, out Vec256<ushort> dst);
            Span<ushort> data = stackalloc ushort[Vec256<ushort>.Length];
            vstore(dinx.vsrl(dst, offset), ref data[0]);
            var i = 0;
            return Vec128.FromBytes(
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
        public static Vec128<short> vsrl(in Vec128<short> src, byte offset)
            => ShiftRightLogical(src.xmm, offset);

        /// <summary>
        /// __m128i _mm_srli_epi16 (__m128i a, int immediate) PSRLW xmm, imm8
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vsrl(in Vec128<ushort> src, byte offset)
            => ShiftRightLogical(src.xmm, offset);

        /// <summary>
        /// __m128i _mm_srli_epi32 (__m128i a, int immediate) PSRLD xmm, imm8
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vsrl(in Vec128<int> src, byte offset)
            => ShiftRightLogical(src.xmm, offset);

        /// <summary>
        /// __m128i _mm_srli_epi32 (__m128i a, int immediate) PSRLD xmm, imm8
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vsrl(in Vec128<uint> src, byte offset)
            => ShiftRightLogical(src.xmm, offset);

        /// <summary>
        /// __m128i _mm_srli_epi64 (__m128i a, int immediate) PSRLQ xmm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vsrl(in Vec128<long> src, byte offset)
            => ShiftRightLogical(src.xmm, offset);

        /// <summary>
        /// __m128i _mm_srli_epi64 (__m128i a, int immediate) PSRLQ xmm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vsrl(in Vec128<ulong> src, byte offset)
            => ShiftRightLogical(src.xmm, offset);

        public static Vec256<byte> vsrl(in Vec256<byte> src, byte offset)
        {
            //Fan the hi/lo parts of the u8 source vector across 2 u16 vectors
            ref var srcX = ref convert(dinx.extract128(src,0), out Vec256<ushort> _);
            ref var srcY = ref convert(dinx.extract128(src,1), out Vec256<ushort> _);
            
            //Shift each part with a concrete intrinsic anc convert back to bytes
            var dstA = dinx.vsrl(srcX, offset).As<byte>();
            var dstB = dinx.vsrl(srcY, offset).As<byte>();

            // Truncate overflows to sets up the component pattern [X 0 X 0 ... X 0] in each vector
            ref readonly var trm = ref Vec256Pattern.ClearAlt<byte>();
            var trA = dinx.shuffle(in dstA, trm);
            var trB = dinx.shuffle(in dstB, trm);
                        
            // Each vector contains 16 values that need to be merged
            // back into a single vector. The strategey is to condense
            // each vector via the "lane merge" pattern and construct
            // the result vector via insertion of these condensed vectors
            ref readonly var permSpec = ref Vec256Pattern.LaneMerge<byte>();
            var permA = dinx.permute(trA, permSpec);
            var permB = dinx.permute(trB, permSpec);
            var result = default(Vec256<byte>);
            dinx.insert(dinx.extract128(in permA,0), dinx.extract128(in permB,0), ref result);            
            
            return result;            
        } 

        /// <summary>
        /// __m256i _mm256_srli_epi16 (__m256i a, int imm8) VPSRLW ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vsrl(in Vec256<short> src, byte offset)
            => ShiftRightLogical(src.ymm, offset);

        /// <summary>
        /// __m256i _mm256_srli_epi16 (__m256i a, int imm8) VPSRLW ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vsrl(in Vec256<ushort> src, byte offset)
            => ShiftRightLogical(src.ymm, offset);

        /// <summary>
        /// __m256i _mm256_srli_epi32 (__m256i a, int imm8) VPSRLD ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vsrl(in Vec256<int> src, byte offset)
            => ShiftRightLogical(src.ymm, offset);

        /// <summary>
        /// __m256i _mm256_srli_epi32 (__m256i a, int imm8) VPSRLD ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vsrl(in Vec256<uint> src, byte offset)
            => ShiftRightLogical(src.ymm, offset);

        /// <summary>
        /// __m256i _mm256_srli_epi64 (__m256i a, int imm8) VPSRLQ ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vsrl(in Vec256<long> src, byte offset)
            => ShiftRightLogical(src.ymm, offset);

        /// <summary>
        /// __m256i _mm256_srli_epi64 (__m256i a, int imm8) VPSRLQ ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vsrl(in Vec256<ulong> src, byte offset)
            => ShiftRightLogical(src.ymm, offset);
 
    }

}