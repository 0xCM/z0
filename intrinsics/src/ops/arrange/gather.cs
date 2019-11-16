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
        ///__m128i _mm_i32gather_epi32 (int const* base_addr, __m128i vindex, const int scale) VPGATHERDD xmm, vm32x, xmm 
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="mem">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vgather(N128 n, ref int mem, Vector128<int> index, byte scale)
            => GatherVector128(refptr(ref mem), index, scale);         

        /// <summary>
        /// __m128i _mm_i64gather_epi32 (int const* base_addr, __m128i vindex, const int scale) VPGATHERQD xmm, vm64x, xmm
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="mem">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vgather(N128 n, ref int mem, Vector128<long> index, byte scale)
            => GatherVector128(refptr(ref mem), index, scale);         

        /// <summary>
        ///  __m128i _mm_i32gather_epi32 (int const* base_addr, __m128i vindex, const int scale) VPGATHERDD xmm, vm32x, xmm
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="mem">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vgather(N128 n, ref uint mem, Vector128<int> index, byte scale)
            => GatherVector128(refptr(ref mem), index, scale);         

        /// <summary>
        /// __m128i _mm_i64gather_epi32 (int const* base_addr, __m128i vindex, const int scale) VPGATHERQD xmm, vm64x, xmm
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="mem">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vgather(N128 n, ref uint mem, Vector128<long> index, byte scale)
            => GatherVector128(refptr(ref mem), index, scale);         

        /// <summary>
        /// __m128i _mm_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERDQ xmm, vm32x, xmm
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="mem">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale">1, 2, 4 or 8</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vgather(N128 n, ref ulong mem, Vector128<int> index, byte scale)
            => GatherVector128(refptr(ref mem), index, scale);         

        /// <summary>
        /// __m128i _mm_i64gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERQQ xmm, vm64x, xmm
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="mem">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vgather(N128 n, ref ulong mem, Vector128<long> index, byte scale)
            => GatherVector128(refptr(ref mem), index, scale);         

        /// <summary>
        /// __m256i _mm256_i32gather_epi32 (int const* base_addr, __m256i vindex, const int, scale)VPGATHERDD ymm, vm32y, ymm
        /// </summary>
        /// <param name="n"></param>
        /// <param name="src"></param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vgather(N256 n, ref int src, Vector256<int> index, byte scale)
            => GatherVector256(refptr(ref src), index, scale);         

        /// <summary>
        /// __m256i _mm256_i32gather_epi32 (int const* base_addr, __m256i vindex, const int scale)VPGATHERDD ymm, vm32y, ymm
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="mem">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vgather(N256 n, ref uint mem, Vector256<int> index, byte scale)
            => GatherVector256(refptr(ref mem), index, scale);         

        /// <summary>
        /// __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const int scale) VPGATHERQQ ymm, vm64y, ymm
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="mem">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vgather(N256 n, ref long mem, Vector256<long> index, byte scale)
            => GatherVector256(refptr(ref mem), index, scale);         

        /// <summary>
        ///  __m256i _mm256_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale)VPGATHERDQ ymm, vm32y, ymm
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="mem">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vgather(N256 n, ref long mem, Vector128<int> index, byte scale)
            => GatherVector256(refptr(ref mem), index, scale);         

        /// <summary>
        /// __m256i _mm256_i64gather_epi64 (__int64 const* base_addr, __m256i vindex, const int scale) VPGATHERQQ ymm, vm64y, ymm
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="mem">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vgather(N256 n, ref ulong mem, Vector256<long> index, byte scale)
            => GatherVector256(refptr(ref mem), index, scale);         

        /// <summary>
        /// __m256i _mm256_i32gather_epi64 (__int64 const* base_addr, __m128i vindex, const int scale) VPGATHERDQ ymm, vm32y, ymm
        /// </summary>
        /// <param name="n">The cpu vector width selector</param>
        /// <param name="mem">The base memory location</param>
        /// <param name="index"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vgather(N256 n, ref ulong mem, Vector128<int> index, byte scale)
            => GatherVector256(refptr(ref mem), index, scale);         


        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vmgather(N256 n, Vector256<uint> src, ref uint mem, Vector256<int> index, Vector256<uint> mask, byte scale)
            => GatherMaskVector256(src, refptr(ref mem), index, mask, scale);
    }
}