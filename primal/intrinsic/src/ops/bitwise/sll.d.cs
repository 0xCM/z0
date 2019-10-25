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
        /// Shifts the entire 128-bit vector leftwards at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits the shift leftward</param>
        /// <remarks>Taken from http://programming.sirrida.de</remarks>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsllx(Vector128<ulong> src, byte offset)        
        {
            var x = dinx.vbsll(src, 8);
            var y = dinx.vsll(src, offset);
            return dinx.vor(y, dinx.vsrl(x, (byte)(64 - offset)));
        }

        [MethodImpl(Inline)]
        public static Vector256<sbyte> vsll(Vector256<sbyte> src, byte offset)
            => vsll(src.AsByte(), offset).AsSByte();

        [MethodImpl(Inline)]
        public static Vector256<byte> vsll(Vector256<byte> src, byte offset)
        {
            //Fan the hi/lo parts of the u8 source vector across 2 u16 vectors
            var srcX = vconvert(dinx.vlo(src), out Vector256<ushort> _);
            var srcY = vconvert(dinx.vhi(src), out Vector256<ushort> _);

            //Shift each part with a concrete intrinsic anc convert back to bytes
            var dstA = dinx.vsll(srcX, offset).AsByte();
            var dstB = dinx.vsll(srcY, offset).AsByte();

            // Truncate overflows to sets up the component pattern [X 0 X 0 ... X 0] in each vector
            var trm =  Vec256Pattern.ClearAltVector<byte>();
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

        public static Vector128<sbyte> vsll(Vector128<sbyte> src, byte offset)
        {
            dinx.vconvert(src, out Vector256<short> dst);
            Span<short> data = stackalloc short[Vector256<short>.Count];
            vstore(dinx.vsll(dst, offset), ref head(data));
            var i = 0;
            return Vector128.Create(
                (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], 
                (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++],
                (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++],
                (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++], (sbyte)data[i++]
            );
        }

        public static Vector128<byte> vsll(Vector128<byte> src, byte offset)
        {
            Span<ushort> data = stackalloc ushort[Vector256<ushort>.Count];
            vconvert(src, out Vector256<ushort> dst);
            vstore(dinx.vsll(dst, offset), ref head(data));
            var i = 0;
            return Vector128.Create(
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
        public static Vector128<short> vsll(Vector128<short> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m128i _mm_slli_epi16 (__m128i a, int immediate) PSLLW xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vsll(Vector128<ushort> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m128i _mm_slli_epi32 (__m128i a, int immediate) PSLLD xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vsll(Vector128<int> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m128i _mm_slli_epi32 (__m128i a, int immediate) PSLLD xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vsll(Vector128<uint> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m128i _mm_slli_epi64 (__m128i a, int immediate) PSLLQ xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vsll(Vector128<long> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m128i _mm_slli_epi64 (__m128i a, int immediate) PSLLQ xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsll(Vector128<ulong> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_slli_epi16 (__m256i a, int imm8) VPSLLW ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vsll(Vector256<short> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_slli_epi16 (__m256i a, int imm8) VPSLLW ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vsll(Vector256<ushort> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_slli_epi32 (__m256i a, int imm8) VPSLLD ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vsll(Vector256<int> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_slli_epi32 (__m256i a, int imm8) VPSLLD ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vsll(Vector256<uint> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vsll(Vector256<long> src, byte offset)
            => ShiftLeftLogical(src, offset);

        /// <summary>
        /// __m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsll(Vector256<ulong> src, byte offset)
            => ShiftLeftLogical(src, offset); 



    }
}