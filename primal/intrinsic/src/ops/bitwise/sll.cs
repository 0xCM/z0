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
    
    partial class dinx
    {   
        /// <summary>
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The offset amount</param>
        /// <remarks>See https://stackoverflow.com/questions/35002937/sse-simd-shift-with-one-byte-element-size-granularity
        /// for a potentially better approach</remarks>
        public static Vec128<sbyte> vsll(in Vec128<sbyte> src, byte offset)
        {
            dinx.convert(in src, out Vec256<short> dst);
            Span<short> data = stackalloc short[Vec256<short>.Length];
            vstore(dinx.vsll(dst, offset), ref data[0]);
            var i = 0;
            return Vec128.FromParts(
                (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], 
                (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++],
                (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++],
                (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++]
            );
        }

        const ushort ByteMask = 0x00FF;

        static Vec256<ushort> VByteMask
        {
            [MethodImpl(Inline)]
            get => broadcast(ByteMask, out Vec256<ushort> dst);
        }

        [MethodImpl(Inline)]
        public static Vec256<ushort> vsll_2(in Vec128<byte> src, byte offset)
        {
            convert(in src, out Vec256<ushort> dst);
            var x = dinx.vand(dinx.vsll(dst,offset), VByteMask);
            return x;
        }
        /// <summary>
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The offset amount</param>
        /// <remarks>See https://stackoverflow.com/questions/35002937/sse-simd-shift-with-one-byte-element-size-granularity
        /// for a potentially better approach</remarks>
        public static Vec128<byte> vsll(in Vec128<byte> src, byte offset)
        {
            Span<ushort> data = stackalloc ushort[Vec256<ushort>.Length];
            convert(in src, out Vec256<ushort> dst);
            vstore(dinx.vsll(dst, offset), ref data[0]);
            var i = 0;
            return Vec128.FromBytes(
                (byte)data[i++], (byte)data[i++], (byte)data[i++], (byte)data[i++], 
                (byte)data[i++], (byte)data[i++], (byte)data[i++], (byte)data[i++],
                (byte)data[i++], (byte)data[i++], (byte)data[i++], (byte)data[i++],
                (byte)data[i++], (byte)data[i++], (byte)data[i++], (byte)data[i++]
            );
        }

        /// <summary>
        /// __m128i _mm_slli_epi16 (__m128i a, int immediate) PSLLW xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vsll(in Vec128<short> src, byte offset)
            => ShiftLeftLogical(src.xmm, offset);

        /// <summary>
        /// __m128i _mm_slli_epi16 (__m128i a, int immediate) PSLLW xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vsll(in Vec128<ushort> src, byte offset)
            => ShiftLeftLogical(src.xmm, offset);

        /// <summary>
        /// __m128i _mm_slli_epi32 (__m128i a, int immediate) PSLLD xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vsll(in Vec128<int> src, byte offset)
            => ShiftLeftLogical(src.xmm, offset);

        /// <summary>
        /// __m128i _mm_slli_epi32 (__m128i a, int immediate) PSLLD xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vsll(in Vec128<uint> src, byte offset)
            => ShiftLeftLogical(src.xmm, offset);

        /// <summary>
        /// __m128i _mm_slli_epi64 (__m128i a, int immediate) PSLLQ xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vsll(in Vec128<long> src, byte offset)
            => ShiftLeftLogical(src.xmm, offset);

        /// <summary>
        /// __m128i _mm_slli_epi64 (__m128i a, int immediate) PSLLQ xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vsll(in Vec128<ulong> src, byte offset)
            => ShiftLeftLogical(src.xmm, offset);
    

        public static Vec256<byte> vsll(in Vec256<byte> src, byte offset)
        {
            //Fan the hi/lo parts of the u8 source vector across 2 u16 vectors
            ref var srcX = ref convert(dinx.lo(src), out Vec256<ushort> _);
            ref var srcY = ref convert(dinx.hi(src), out Vec256<ushort> _);
            
            //Shift each part with a concrete intrinsic anc convert back to bytes
            var dstA = dinx.vsll(srcX, offset).As<byte>();
            var dstB = dinx.vsll(srcY, offset).As<byte>();

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
            dinx.insert(dinx.lo(in permA), dinx.lo(in permB), ref result);            
            
            return result;            
        }

        /// <summary>
        /// __m256i _mm256_slli_epi16 (__m256i a, int imm8) VPSLLW ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vsll(in Vec256<short> src, byte offset)
            => ShiftLeftLogical(src.ymm, offset);

        /// <summary>
        /// __m256i _mm256_slli_epi16 (__m256i a, int imm8) VPSLLW ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vsll(in Vec256<ushort> src, byte offset)
            => ShiftLeftLogical(src.ymm, offset);

        /// <summary>
        /// __m256i _mm256_slli_epi32 (__m256i a, int imm8) VPSLLD ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vsll(in Vec256<int> src, byte offset)
            => ShiftLeftLogical(src.ymm, offset);

        /// <summary>
        /// __m256i _mm256_slli_epi32 (__m256i a, int imm8) VPSLLD ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vsll(in Vec256<uint> src, byte offset)
            => ShiftLeftLogical(src.ymm, offset);

        /// <summary>
        /// __m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vsll(in Vec256<long> src, byte offset)
            => ShiftLeftLogical(src.ymm, offset);

        /// <summary>
        /// __m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vsll(in Vec256<ulong> src, byte offset)
            => ShiftLeftLogical(src.ymm, offset); 
   
    }

}