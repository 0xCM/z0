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
        /// Compares corresponding components in each vector for equality. For equal
        /// components, the corresponding component in the result vector has all bits 
        /// enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <algorithm>
        /// FOR j := 0 to 15
        /// 	i := j*8
        /// 	dst[i+7:i] := ( a[i+7:i] == b[i+7:i] ) ? 0xFF : 0
        /// ENDFOR        
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> vcmpeq(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => CompareEqual(lhs,rhs);
            
        /// <summary>
        /// __m128i _mm_cmpeq_epi8 (__m128i a, __m128i b) PCMPEQB xmm, xmm/m128
        /// Compares corresponding components in each vector for equality. For equal
        /// components, the corresponding component in the result vector has all bits 
        /// enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vcmpeq(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        ///  __m128i _mm_cmpeq_epi16 (__m128i a, __m128i b) PCMPEQW xmm, xmm/m128 
        /// Compares corresponding components in each vector for equality. For equal
        /// components, the corresponding component in the result vector has all bits 
        /// enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vcmpeq(in Vec128<short> lhs, in Vec128<short> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        ///  __m128i _mm_cmpeq_epi16 (__m128i a, __m128i b) PCMPEQW xmm, xmm/m128 
        /// Compares corresponding components in each vector for equality. For equal
        /// components, the corresponding component in the result vector has all bits 
        /// enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vcmpeq(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        /// __m128i _mm_cmpeq_epi32 (__m128i a, __m128i b) PCMPEQD xmm, xmm/m128
        /// </summary>
        /// Compares corresponding components in each vector for equality. For equal
        /// components, the corresponding component in the result vector has all bits 
        /// enabled; otherwise, all bits in the component are disabled
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vcmpeq(in Vec128<int> lhs, in Vec128<int> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        /// __m128i _mm_cmpeq_epi32 (__m128i a, __m128i b) PCMPEQD xmm, xmm/m128
        /// </summary>
        /// Compares corresponding components in each vector for equality. For equal
        /// components, the corresponding component in the result vector has all bits 
        /// enabled; otherwise, all bits in the component are disabled
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vcmpeq(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        /// __m128i _mm_cmpeq_epi64 (__m128i a, __m128i b) PCMPEQQ xmm, xmm/m128
        /// Compares corresponding components in each vector for equality. For equal
        /// components, the corresponding component in the result vector has all bits 
        /// enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vcmpeq(in Vec128<long> lhs, in Vec128<long> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        /// __m128i _mm_cmpeq_epi64 (__m128i a, __m128i b) PCMPEQQ xmm, xmm/m128
        /// Compares corresponding components in each vector for equality. For equal
        /// components, the corresponding component in the result vector has all bits 
        /// enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vcmpeq(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_cmpeq_epi8 (__m256i a, __m256i b) VPCMPEQB ymm, ymm, ymm/m256
        /// Compares corresponding components in each vector for equality. For equal
        /// components, the corresponding component in the result vector has all bits 
        /// enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vcmpeq(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => CompareEqual(lhs,rhs);
            
        /// <summary>
        /// __m256i _mm256_cmpeq_epi8 (__m256i a, __m256i b) VPCMPEQB ymm, ymm, ymm/m256
        /// Compares the operands for equality
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vcmpeq(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        ///  __m256i _mm256_cmpeq_epi16 (__m256i a, __m256i b) VPCMPEQW ymm, ymm, ymm/m256
        /// Compares corresponding components in each vector for equality. For equal
        /// components, the corresponding component in the result vector has all bits 
        /// enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vcmpeq(in Vec256<short> lhs, in Vec256<short> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_cmpeq_epi16 (__m256i a, __m256i b) VPCMPEQW ymm, ymm, ymm/m256 
        /// Compares corresponding components in each vector for equality. For equal
        /// components, the corresponding component in the result vector has all bits 
        /// enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vcmpeq(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        /// _mm256_cmpeq_epi32 (__m256i a, __m256i b) VPCMPEQD ymm, ymm, ymm/m256
        /// Compares corresponding components in each vector for equality. For equal
        /// components, the corresponding component in the result vector has all bits 
        /// enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vcmpeq(in Vec256<int> lhs, in Vec256<int> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_cmpeq_epi32 (__m256i a, __m256i b) VPCMPEQD ymm, ymm, ymm/m256
        /// Compares corresponding components in each vector for equality. For equal
        /// components, the corresponding component in the result vector has all bits 
        /// enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vcmpeq(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_cmpeq_epi64 (__m256i a, __m256i b) VPCMPEQQ ymm, ymm, ymm/m256
        /// Compares corresponding components in each vector for equality. For equal
        /// components, the corresponding component in the result vector has all bits 
        /// enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vcmpeq(in Vec256<long> lhs, in Vec256<long> rhs)
            => CompareEqual(lhs,rhs);

        /// <summary>
        ///  __m256i _mm256_cmpeq_epi64 (__m256i a, __m256i b) VPCMPEQQ ymm, ymm, ymm/m256
        /// Compares corresponding components in each vector for equality. For equal
        /// components, the corresponding component in the result vector has all bits 
        /// enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vcmpeq(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => CompareEqual(lhs,rhs);
    }

}