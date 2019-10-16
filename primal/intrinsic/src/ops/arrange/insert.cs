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
        
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Sse41.X64;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;
    
    partial class dinx
    {
        /// <summary>
        /// __m128i _mm_insert_epi8 (__m128i a, int i, const int imm8)PINSRB xmm, reg/m8, imm8
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The 0-based index of the component to overwrite</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vinsert(byte src, in Vec128<byte> dst, byte index)        
            => Insert(dst.xmm, src, index);

        /// <summary>
        /// _mm_insert_epi8: 
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The 0-based index of the component to overwrite</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> vinsert(sbyte src, in Vec128<sbyte> dst, byte index)        
            => Insert(dst.xmm, src, index);

        /// <summary>
        /// __m128i _mm_insert_epi16 (__m128i a, int i, int immediate) PINSRW xmm, reg/m16, imm8
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The 0-based index of the component to overwrite</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vinsert(short src, in Vec128<short> dst, byte index)        
            => Insert(dst.xmm, src, index);

        /// <summary>
        /// __m128i _mm_insert_epi16 (__m128i a, int i, int immediate) PINSRW xmm, reg/m16, imm8
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The 0-based index of the component to overwrite</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vinsert(ushort src, in Vec128<ushort> dst, byte index)        
            => Insert(dst.xmm, src, index);

        /// <summary>
        /// __m128i _mm_insert_epi32 (__m128i a, int i, const int imm8) PINSRD xmm, reg/m32, xmm8
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The 0-based index of the component to overwrite</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vinsert(int src, in Vec128<int> dst, byte index)        
            => Insert(dst.xmm, src, index);

        /// <summary>
        /// __m128i _mm_insert_epi32 (__m128i a, int i, const int imm8) PINSRD xmm, reg/m32, xmm8
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The 0-based index of the component to overwrite</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vinsert(uint src, in Vec128<uint> dst, byte index)        
            => Insert(dst.xmm, src, index);

        /// <summary>
        /// __m128i _mm_insert_epi64 (__m128i a, __int64 i, const int imm8) PINSRQ xmm, reg/m64,imm8
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The 0-based index of the component to overwrite</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vinsert(long src, in Vec128<long> dst, byte index)        
            => Insert(dst.xmm, src, index);

        /// <summary>
        /// _mm_insert_epi64:
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The 0-based index of the component to overwrite</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vinsert(ulong src, in Vec128<ulong> dst, byte index)        
            => Insert(dst.xmm, src, index);

        /// <summary>
        ///  __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128 ymm, ymm, xmm, imm8
        /// Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vinsert(in Vec128<sbyte> src, in Vec256<sbyte> dst, byte index)        
            => InsertVector128(dst.ymm, src.xmm, index);

        /// <summary>
        ///  __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128 ymm, ymm, xmm, imm8
        /// Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vinsert(in Vec128<byte> src, in Vec256<byte> dst, byte index)        
            => InsertVector128(dst.ymm, src.xmm, index);

        /// <summary>
        ///  __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128 ymm, ymm, xmm, imm8
        /// Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vinsert(in Vec128<short> src, in Vec256<short> dst, byte index)        
            => InsertVector128(dst.ymm, src.xmm, index);

        /// <summary>
        ///  __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128 ymm, ymm, xmm, imm8
        /// Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vinsert(in Vec128<ushort> src, in Vec256<ushort> dst, byte index)        
            => InsertVector128(dst.ymm, src.xmm, index);

        /// <summary>
        ///  __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128 ymm, ymm, xmm, imm8
        /// Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vinsert(in Vec128<int> src, in Vec256<int> dst, byte index)        
            => InsertVector128(dst.ymm, src.xmm, index);

        /// <summary>
        ///  __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128 ymm, ymm, xmm, imm8
        /// Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> insert(in Vec128<uint> src, in Vec256<uint> dst, byte index)        
            => InsertVector128(dst.ymm, src.xmm, index);

        /// <summary>
        ///  __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128 ymm, ymm, xmm, imm8
        /// Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vinsert(in Vec128<long> src, in Vec256<long> dst, byte index)        
            => InsertVector128(dst.ymm, src.xmm, index);

        /// <summary>
        ///  __m256i _mm256_inserti128_si256 (__m256i a, __m128i b, const int imm8) VINSERTI128 ymm, ymm, xmm, imm8
        /// Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vinsert(in Vec128<ulong> src, in Vec256<ulong> dst, byte index)        
            => InsertVector128(dst.ymm, src.xmm, index);

        /// <summary>
        /// Overwrites the target vector with two 128-bit source vectors
        /// </summary>
        /// <param name="lo">The vector that will be inserted into the lo 128-bit lane of the target</param>
        /// <param name="hi">The vector that will be inserted into the hi 128-bit lane of the target</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vec256<byte> insert(in Vec128<byte> lo, in Vec128<byte> hi, out Vec256<byte> dst)        
        {
            dst = InsertVector128(InsertVector128(default, lo.xmm, 0), hi.xmm, 1);
            return ref dst;
        }    
    }
}