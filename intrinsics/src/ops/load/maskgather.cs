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
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;
    using static As;

    partial class dinx
    {    
        /// <summary>
        /// __m128i _mm_mask_i32gather_epi32 (__m128i src, int const* base_addr, __m128i vindex, __m128i mask, const int scale) VPGATHERDD xmm, vm32x, xmm
        /// </summary>
        /// <param name="n">The target vector width</param>
        /// <param name="vsrc">The vector-based source for target component data as controlled by the mask vector</param>
        /// <param name="msrc">The memory-based source for taget component data as controlled by the mask vector</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask">The vector that determines whether target vector components are loaded from the vector or memory source</param>
        /// <remarks>Elements are copied from the source vector when the highest bit of the corresponding element in the mask vector is not set
        /// If, for example, all hi bits in the mask vector are set then the corresponding target element is loaded from the index-identified cell
        /// and this operation reduces to the coresponding maskless gather function
        /// </remarks>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vmaskgather(N128 n, Vector128<uint> vsrc, ref uint msrc, Vector128<int> vidx, Vector128<uint> mask)
            => GatherMaskVector128(vsrc, ptr(ref msrc), vidx, mask, 4);

        /// <summary>
        /// __m128i _mm_mask_i64gather_epi64 (__m128i src, __int64 const* base_addr, __m128i vindex, __m128i mask, const int scale) VPGATHERQQ xmm, vm64x, xmm
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="vsrc">The vector-based source for target component data as controlled by the mask vector</param>
        /// <param name="msrc">The memory-based source for taget component data as controlled by the mask vector</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask">The vector that determines whether target vector components are loaded from the vector or memory source</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vmaskgather(N128 w, Vector128<ulong> vsrc, ref ulong msrc, Vector128<long> vidx, Vector128<ulong> mask)
            => GatherMaskVector128(vsrc, ptr(ref msrc), vidx, mask, 8);

        /// <summary>
        /// __m128i _mm_mask_i32gather_epi64 (__m128i src, __int64 const* base_addr, __m128i vindex, __m128i mask, const int scale) VPGATHERDQ xmm, vm32x, xmm
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="vsrc">The vector-based source for target component data as controlled by the mask vector</param>
        /// <param name="msrc">The memory-based source for taget component data as controlled by the mask vector</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask">The vector that determines whether target vector components are loaded from the vector or memory source</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vmaskgather(N128 w, Vector128<ulong> vsrc, ref ulong msrc, Vector128<int> vidx, Vector128<ulong> mask)
            => GatherMaskVector128(vsrc, ptr(ref msrc), vidx, mask, 8);

        /// <summary>
        /// __m128i _mm_mask_i64gather_epi32 (__m128i src, int const* base_addr, __m128i vindex, __m128i mask, const int scale) VPGATHERQD xmm, vm64x, xmm
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="vsrc">The vector-based source for target component data as controlled by the mask vector</param>
        /// <param name="msrc">The memory-based source for taget component data as controlled by the mask vector</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask">The vector that determines whether target vector components are loaded from the vector or memory source</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vmaskgather(N128 w, Vector128<uint> vsrc, ref uint msrc, Vector128<long> vidx, Vector128<uint> mask)
            => GatherMaskVector128(vsrc, ptr(ref msrc), vidx, mask, 4);

        /// <summary>
        /// __m128i _mm256_mask_i64gather_epi32 (__m128i src, int const* base_addr, __m256i vindex, __m128i mask, const int scale) VPGATHERQD xmm, vm32y, xmm
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="vsrc">The vector-based source for target component data as controlled by the mask vector</param>
        /// <param name="msrc">The memory-based source for taget component data as controlled by the mask vector</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask">The vector that determines whether target vector components are loaded from the vector or memory source</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vmaskgather(N128 w, Vector128<uint> vsrc, ref uint msrc, Vector256<long> vidx, Vector128<uint> mask)
            => GatherMaskVector128(vsrc, ptr(ref msrc), vidx, mask, 4);

        /// <summary>
        ///   __m256i _mm256_mask_i32gather_epi32 (__m256i src, int const* base_addr, __m256i vindex, __m256i mask, const int scale) VPGATHERDD ymm, vm32y, ymm
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="vsrc">The vector-based source for target component data as controlled by the mask vector</param>
        /// <param name="msrc">The memory-based source for taget component data as controlled by the mask vector</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask">The vector that determines whether target vector components are loaded from the vector or memory source</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vmaskgather(N256 w, Vector256<uint> vsrc, ref uint msrc, Vector256<int> vidx, Vector256<uint> mask)
            => GatherMaskVector256(vsrc, ptr(ref msrc), vidx, mask, 4);

        /// <summary>
        /// __m256i _mm256_mask_i64gather_epi64 (__m256i src, __int64 const* base_addr, __m256i vindex, __m256i mask, const int scale) VPGATHERQQ ymm, vm32y, ymm
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="vsrc">The vector-based source for target component data as controlled by the mask vector</param>
        /// <param name="msrc">The memory-based source for taget component data as controlled by the mask vector</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask">The vector that determines whether target vector components are loaded from the vector or memory source</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vmaskgather(N256 w, Vector256<ulong> vsrc, ref ulong msrc, Vector256<long> vidx, Vector256<ulong> mask)
            => GatherMaskVector256(vsrc, ptr(ref msrc), vidx, mask, 8);

        /// <summary>
        ///  __m256i _mm256_mask_i32gather_epi64 (__m256i src, __int64 const* base_addr, __m128i vindex, __m256i mask, const int scale) VPGATHERDQ ymm, vm32y, ymm
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="vsrc">The vector-based source for target component data as controlled by the mask vector</param>
        /// <param name="msrc">The memory-based source for taget component data as controlled by the mask vector</param>
        /// <param name="vidx">The index vector</param>
        /// <param name="mask">The vector that determines whether target vector components are loaded from the vector or memory source</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vmaskgather(N256 w, Vector256<ulong> vsrc, ref ulong msrc, Vector128<int> vidx, Vector256<ulong> mask)
            => GatherMaskVector256(vsrc, ptr(ref msrc), vidx, mask, 8);
    }

}