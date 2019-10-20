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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;
    using static As;

    partial class dinx
    {
        /// <summary>
        /// _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        /// </summary>
        /// <param name="src"></param>
        /// <param name="mask"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskmove(Vector128<sbyte> src, Vector128<sbyte> mask, ref sbyte dst)
            => MaskMove(src, mask, refptr(ref dst));

        /// <summary>
        /// _mm_maskmoveu_si128 (__m128i a, __m128i mask, char* mem_address) MASKMOVDQU xmm, xmm
        /// Conditionally stores components from the source vector into memory per the supplied mask
        /// where the hi bit of each corresponding mask component determines whether source component data
        /// is written. If the hi bit is on, component content is written, otherwise it is not
        /// </summary>
        /// <param name="src"></param>
        /// <param name="mask"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskmove(Vector128<byte> src, Vector128<byte> mask, ref byte dst)
            =>  MaskMove(src, mask, refptr(ref dst));

        /// <summary>
        /// _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static int vmovemask(Vector128<byte> src)
            => MoveMask(src);

        /// <summary>
        /// Constructs an integer from the most significant bit of each source vector component
        /// int _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// </summary>
        [MethodImpl(Inline)]
        public static int vmovemask(Vector128<sbyte> src)
            => MoveMask(src);
 
        /// <summary>
        /// int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static int vmovemask(Vector256<sbyte> src)
            => MoveMask(src);
                
        /// <summary>
        /// int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static int vmovemask(Vector256<byte> src)
            => MoveMask(src);
                 

        /// <summary>
        /// void _mm_maskstore_epi32 (int* mem_addr, __m128i mask, __m128i a) VPMASKMOVD m128, xmm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector128<int> src, Vector128<int> mask, ref int dst)
            => MaskStore(refptr(ref dst), src,mask);

        /// <summary>
        /// void _mm256_maskstore_epi32 (int* mem_addr, __m256i mask, __m256i a) VPMASKMOVD m256, ymm, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector256<int> src, Vector256<int> mask, ref int dst)
            => MaskStore(refptr(ref dst), src,mask);

        /// <summary>
        /// void _mm256_maskstore_epi32 (int* mem_addr, __m256i mask, __m256i a) VPMASKMOVD m256, ymm, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector256<uint> src, Vector256<uint> mask, ref uint dst)
            => MaskStore(refptr(ref dst), src,mask);

        /// <summary>
        /// void _mm256_maskstore_epi64 (__int64* mem_addr, __m256i mask, __m256i a) VPMASKMOVQ m256, ymm, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector256<long> src, Vector256<long> mask, ref long dst)
            => MaskStore(refptr(ref dst), src,mask);

        /// <summary>
        /// void _mm256_maskstore_epi64 (__int64* mem_addr, __m256i mask, __m256i a) VPMASKMOVQ m256, ymm, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask</param>
        /// <param name="dst">The memory reference</param>
        [MethodImpl(Inline)]
        public static unsafe void vmaskstore(Vector256<ulong> src, Vector256<ulong> mask, ref ulong dst)
            => MaskStore(refptr(ref dst), src,mask);
 
         /// <summary>
        /// __m128i _mm_maskload_epi32 (int const* mem_addr, __m128i mask) VPMASKMOVD xmm, xmm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vmaskload(ref int src, Vector128<int> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi32 (int const* mem_addr, __m256i mask) VPMASKMOVD ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vmaskload(ref int src, Vector256<int> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi32 (int const* mem_addr, __m256i mask) VPMASKMOVD ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vmaskload(ref uint src, Vector256<uint> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi64 (__int64 const* mem_addr, __m256i mask) VPMASKMOVQ ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vmaskload(ref long src, Vector256<long> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi64 (__int64 const* mem_addr, __m256i mask) VPMASKMOVQ ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vmaskload(ref ulong src, Vector256<ulong> mask)
            => MaskLoad(refptr(ref src), mask); 
    }

}