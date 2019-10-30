//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    
    using static As;
    
    partial class dinx
    {   
        /// <summary>
        /// __m128i _mm_cmpeq_epi8 (__m128i a, __m128i b) PCMPEQB xmm, xmm/m128
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> veq(Vector128<sbyte> x, Vector128<sbyte> y)
            => CompareEqual(x,y);
            
        /// <summary>
        /// __m128i _mm_cmpeq_epi8 (__m128i a, __m128i b) PCMPEQB xmm, xmm/m128
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> veq(Vector128<byte> x, Vector128<byte> y)
            => CompareEqual(x,y);

        /// <summary>
        ///  __m128i _mm_cmpeq_epi16 (__m128i a, __m128i b) PCMPEQW xmm, xmm/m128 
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<short> veq(Vector128<short> x, Vector128<short> y)
            => CompareEqual(x,y);

        /// <summary>
        ///  __m128i _mm_cmpeq_epi16 (__m128i a, __m128i b) PCMPEQW xmm, xmm/m128 
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> veq(Vector128<ushort> x, Vector128<ushort> y)
            => CompareEqual(x,y);

        /// <summary>
        /// __m128i _mm_cmpeq_epi32 (__m128i a, __m128i b) PCMPEQD xmm, xmm/m128
        /// </summary>
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> veq(Vector128<int> x, Vector128<int> y)
            => CompareEqual(x,y);

        /// <summary>
        /// __m128i _mm_cmpeq_epi32 (__m128i a, __m128i b) PCMPEQD xmm, xmm/m128
        /// </summary>
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> veq(Vector128<uint> x, Vector128<uint> y)
            => CompareEqual(x,y);

        /// <summary>
        /// __m128i _mm_cmpeq_epi64 (__m128i a, __m128i b) PCMPEQQ xmm, xmm/m128
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> veq(Vector128<long> x, Vector128<long> y)
            => CompareEqual(x,y);

        /// <summary>
        /// __m128i _mm_cmpeq_epi64 (__m128i a, __m128i b) PCMPEQQ xmm, xmm/m128
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> veq(Vector128<ulong> x, Vector128<ulong> y)
            => CompareEqual(x,y);

        /// <summary>
        /// __m256i _mm256_cmpeq_epi8 (__m256i a, __m256i b) VPCMPEQB ymm, ymm, ymm/m256
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> veq(Vector256<sbyte> x, Vector256<sbyte> y)
            => CompareEqual(x,y);
            
        /// <summary>
        /// __m256i _mm256_cmpeq_epi8 (__m256i a, __m256i b) VPCMPEQB ymm, ymm, ymm/m256
        /// Compares the operands for equality
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> veq(Vector256<byte> x, Vector256<byte> y)
            => CompareEqual(x,y);

        /// <summary>
        ///  __m256i _mm256_cmpeq_epi16 (__m256i a, __m256i b) VPCMPEQW ymm, ymm, ymm/m256
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> veq(Vector256<short> x, Vector256<short> y)
            => CompareEqual(x,y);

        /// <summary>
        /// __m256i _mm256_cmpeq_epi16 (__m256i a, __m256i b) VPCMPEQW ymm, ymm, ymm/m256 
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> veq(Vector256<ushort> x, Vector256<ushort> y)
            => CompareEqual(x,y);

        /// <summary>
        /// _mm256_cmpeq_epi32 (__m256i a, __m256i b) VPCMPEQD ymm, ymm, ymm/m256
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> veq(Vector256<int> x, Vector256<int> y)
            => CompareEqual(x,y);

        /// <summary>
        /// __m256i _mm256_cmpeq_epi32 (__m256i a, __m256i b) VPCMPEQD ymm, ymm, ymm/m256
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> veq(Vector256<uint> x, Vector256<uint> y)
            => CompareEqual(x,y);

        /// <summary>
        /// __m256i _mm256_cmpeq_epi64 (__m256i a, __m256i b) VPCMPEQQ ymm, ymm, ymm/m256
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> veq(Vector256<long> x, Vector256<long> y)
            => CompareEqual(x,y);

        /// <summary>
        ///  __m256i _mm256_cmpeq_epi64 (__m256i a, __m256i b) VPCMPEQQ ymm, ymm, ymm/m256
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> veq(Vector256<ulong> x, Vector256<ulong> y)
            => CompareEqual(x,y);
    }

}