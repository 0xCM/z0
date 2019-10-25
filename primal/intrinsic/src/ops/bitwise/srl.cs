// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2019
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0
// {
//     using System;
//     using System.Runtime.CompilerServices;    
//     using System.Runtime.Intrinsics;
//     using System.Runtime.Intrinsics.X86;

//     using static System.Runtime.Intrinsics.X86.Avx2;
//     using static System.Runtime.Intrinsics.X86.Sse2;

//     using static zfunc;
//     using static As;

//     partial class dinx
//     {         

//         /// <summary>
//         /// __m128i _mm_srli_epi16 (__m128i a, int immediate) PSRLW xmm, imm8
//         /// Shifts each component of the source vector rightwards by a common number of bits
//         /// </summary>
//         /// <param name="src">The source vector</param>
//         /// <param name="offset">The number of bits to shift</param>
//         [MethodImpl(Inline)]
//         public static Vec128<short> vsrl(in Vec128<short> src, byte offset)
//             => ShiftRightLogical(src.xmm, offset);

//         /// <summary>
//         /// __m128i _mm_srli_epi16 (__m128i a, int immediate) PSRLW xmm, imm8
//         /// Shifts each component of the source vector rightwards by a common number of bits
//         /// </summary>
//         /// <param name="src">The source vector</param>
//         /// <param name="offset">The number of bits to shift</param>
//         [MethodImpl(Inline)]
//         public static Vec128<ushort> vsrl(in Vec128<ushort> src, byte offset)
//             => ShiftRightLogical(src.xmm, offset);

//         /// <summary>
//         /// __m128i _mm_srli_epi32 (__m128i a, int immediate) PSRLD xmm, imm8
//         /// Shifts each component of the source vector rightwards by a common number of bits
//         /// </summary>
//         /// <param name="src">The source vector</param>
//         /// <param name="offset">The number of bits to shift</param>
//         [MethodImpl(Inline)]
//         public static Vec128<int> vsrl(in Vec128<int> src, byte offset)
//             => ShiftRightLogical(src.xmm, offset);

//         /// <summary>
//         /// __m128i _mm_srli_epi32 (__m128i a, int immediate) PSRLD xmm, imm8
//         /// Shifts each component of the source vector rightwards by a common number of bits
//         /// </summary>
//         /// <param name="src">The source vector</param>
//         /// <param name="offset">The number of bits to shift</param>
//         [MethodImpl(Inline)]
//         public static Vec128<uint> vsrl(in Vec128<uint> src, byte offset)
//             => ShiftRightLogical(src.xmm, offset);

//         /// <summary>
//         /// __m128i _mm_srli_epi64 (__m128i a, int immediate) PSRLQ xmm, imm8
//         /// Shifts each component of the source vector right by a common number of bits
//         /// </summary>
//         /// <param name="src">The source vector</param>
//         /// <param name="offset">The number of bits to shift</param>
//         [MethodImpl(Inline)]
//         public static Vec128<long> vsrl(in Vec128<long> src, byte offset)
//             => ShiftRightLogical(src.xmm, offset);

//         /// <summary>
//         /// __m128i _mm_srli_epi64 (__m128i a, int immediate) PSRLQ xmm, imm8
//         /// Shifts each component of the source vector right by a common number of bits
//         /// </summary>
//         /// <param name="src">The source vector</param>
//         /// <param name="offset">The number of bits to shift</param>
//         [MethodImpl(Inline)]
//         public static Vec128<ulong> vsrl(in Vec128<ulong> src, byte offset)
//             => ShiftRightLogical(src.xmm, offset);

//         public static Vec256<byte> vsrl(in Vec256<byte> src, byte offset)
//         {
//             //Fan the hi/lo parts of the u8 source vector across 2 u16 vectors
//             var srcX = vconvert(dinx.vlo(src), out Vec256<ushort> _);
//             var srcY = vconvert(dinx.vhi(src), out Vec256<ushort> _);
            
//             //Shift each part with a concrete intrinsic anc convert back to bytes
//             var dstA = dinx.vsrl(srcX, offset).As<byte>();
//             var dstB = dinx.vsrl(srcY, offset).As<byte>();

//             // Truncate overflows to sets up the component pattern [X 0 X 0 ... X 0] in each vector
//             var trm = Vec256Pattern.ClearAlt<byte>();
//             var trA = dinx.vshuffle(in dstA, trm);
//             var trB = dinx.vshuffle(in dstB, trm);
                        
//             // Each vector contains 16 values that need to be merged
//             // back into a single vector. The strategey is to condense
//             // each vector via the "lane merge" pattern and construct
//             // the result vector via insertion of these condensed vectors
//             var permSpec = Vec256Pattern.LaneMerge<byte>();
//             var permA = dinx.vpermvar32x8(trA, permSpec);
//             var permB = dinx.vpermvar32x8(trB, permSpec);
//             return dinx.insert(dinx.vlo(in permA), dinx.vlo(in permB), out Vec256<byte> _);            
//         } 

//         /// <summary>
//         /// __m256i _mm256_srli_epi16 (__m256i a, int imm8) VPSRLW ymm, ymm, imm8
//         /// Shifts each component of the source vector right by a common number of bits
//         /// </summary>
//         /// <param name="src">The source vector</param>
//         /// <param name="offset">The number of bits to shift</param>
//         [MethodImpl(Inline)]
//         public static Vec256<short> vsrl(in Vec256<short> src, byte offset)
//             => ShiftRightLogical(src.ymm, offset);

//         /// <summary>
//         /// __m256i _mm256_srli_epi16 (__m256i a, int imm8) VPSRLW ymm, ymm, imm8
//         /// Shifts each component of the source vector right by a common number of bits
//         /// </summary>
//         /// <param name="src">The source vector</param>
//         /// <param name="offset">The number of bits to shift</param>
//         [MethodImpl(Inline)]
//         public static Vec256<ushort> vsrl(in Vec256<ushort> src, byte offset)
//             => ShiftRightLogical(src.ymm, offset);

//         /// <summary>
//         /// __m256i _mm256_srli_epi32 (__m256i a, int imm8) VPSRLD ymm, ymm, imm8
//         /// Shifts each component of the source vector right by a common number of bits
//         /// </summary>
//         /// <param name="src">The source vector</param>
//         /// <param name="offset">The number of bits to shift</param>
//         [MethodImpl(Inline)]
//         public static Vec256<int> vsrl(in Vec256<int> src, byte offset)
//             => ShiftRightLogical(src.ymm, offset);

//         /// <summary>
//         /// __m256i _mm256_srli_epi32 (__m256i a, int imm8) VPSRLD ymm, ymm, imm8
//         /// Shifts each component of the source vector right by a common number of bits
//         /// </summary>
//         /// <param name="src">The source vector</param>
//         /// <param name="offset">The number of bits to shift</param>
//         [MethodImpl(Inline)]
//         public static Vec256<uint> vsrl(in Vec256<uint> src, byte offset)
//             => ShiftRightLogical(src.ymm, offset);

//         /// <summary>
//         /// __m256i _mm256_srli_epi64 (__m256i a, int imm8) VPSRLQ ymm, ymm, imm8
//         /// Shifts each component of the source vector right by a common number of bits
//         /// </summary>
//         /// <param name="src">The source vector</param>
//         /// <param name="offset">The number of bits to shift</param>
//         [MethodImpl(Inline)]
//         public static Vec256<long> vsrl(in Vec256<long> src, byte offset)
//             => ShiftRightLogical(src.ymm, offset);

//         /// <summary>
//         /// __m256i _mm256_srli_epi64 (__m256i a, int imm8) VPSRLQ ymm, ymm, imm8
//         /// Shifts each component of the source vector right by a common number of bits
//         /// </summary>
//         /// <param name="src">The source vector</param>
//         /// <param name="offset">The number of bits to shift</param>
//         [MethodImpl(Inline)]
//         public static Vec256<ulong> vsrl(in Vec256<ulong> src, byte offset)
//             => ShiftRightLogical(src.ymm, offset); 
//     }
// }