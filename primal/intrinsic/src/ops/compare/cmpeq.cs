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
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vcmpeq(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
            => CompareEqual(lhs,rhs);
            
        /// <summary>
        /// __m128i _mm_cmpeq_epi8 (__m128i a, __m128i b) PCMPEQB xmm, xmm/m128
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vcmpeq(Vector128<byte> lhs, Vector128<byte> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        ///  __m128i _mm_cmpeq_epi16 (__m128i a, __m128i b) PCMPEQW xmm, xmm/m128 
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vcmpeq(Vector128<short> lhs, Vector128<short> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        ///  __m128i _mm_cmpeq_epi16 (__m128i a, __m128i b) PCMPEQW xmm, xmm/m128 
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vcmpeq(Vector128<ushort> lhs, Vector128<ushort> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        /// __m128i _mm_cmpeq_epi32 (__m128i a, __m128i b) PCMPEQD xmm, xmm/m128
        /// </summary>
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vcmpeq(Vector128<int> lhs, Vector128<int> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        /// __m128i _mm_cmpeq_epi32 (__m128i a, __m128i b) PCMPEQD xmm, xmm/m128
        /// </summary>
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vcmpeq(Vector128<uint> lhs, Vector128<uint> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        /// __m128i _mm_cmpeq_epi64 (__m128i a, __m128i b) PCMPEQQ xmm, xmm/m128
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vcmpeq(Vector128<long> lhs, Vector128<long> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        /// __m128i _mm_cmpeq_epi64 (__m128i a, __m128i b) PCMPEQQ xmm, xmm/m128
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vcmpeq(Vector128<ulong> lhs, Vector128<ulong> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_cmpeq_epi8 (__m256i a, __m256i b) VPCMPEQB ymm, ymm, ymm/m256
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vcmpeq(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
            => CompareEqual(lhs,rhs);
            
        /// <summary>
        /// __m256i _mm256_cmpeq_epi8 (__m256i a, __m256i b) VPCMPEQB ymm, ymm, ymm/m256
        /// Compares the operands for equality
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vcmpeq(Vector256<byte> lhs, Vector256<byte> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        ///  __m256i _mm256_cmpeq_epi16 (__m256i a, __m256i b) VPCMPEQW ymm, ymm, ymm/m256
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vcmpeq(Vector256<short> lhs, Vector256<short> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_cmpeq_epi16 (__m256i a, __m256i b) VPCMPEQW ymm, ymm, ymm/m256 
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vcmpeq(Vector256<ushort> lhs, Vector256<ushort> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        /// _mm256_cmpeq_epi32 (__m256i a, __m256i b) VPCMPEQD ymm, ymm, ymm/m256
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vcmpeq(Vector256<int> lhs, Vector256<int> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_cmpeq_epi32 (__m256i a, __m256i b) VPCMPEQD ymm, ymm, ymm/m256
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vcmpeq(Vector256<uint> lhs, Vector256<uint> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_cmpeq_epi64 (__m256i a, __m256i b) VPCMPEQQ ymm, ymm, ymm/m256
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vcmpeq(Vector256<long> lhs, Vector256<long> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        ///  __m256i _mm256_cmpeq_epi64 (__m256i a, __m256i b) VPCMPEQQ ymm, ymm, ymm/m256
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vcmpeq(Vector256<ulong> lhs, Vector256<ulong> rhs)
            => CompareEqual(lhs,rhs);
    }

}