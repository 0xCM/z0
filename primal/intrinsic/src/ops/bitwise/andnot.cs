//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
    using System.Runtime.Intrinsics;    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
 
    using static zfunc;
    
    public static partial class dinx
    {                
        /// <summary>
        /// __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> vandnot(in Vec128<sbyte> x, in Vec128<sbyte> y)
            => AndNot(y.xmm, x.xmm);

        /// <summary>
        /// __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vandnot(in Vec128<byte> x, in Vec128<byte> y)
            => AndNot(y.xmm, x.xmm);

        /// <summary>
        ///  __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vandnot(in Vec128<short> x, in Vec128<short> y)
            => AndNot(y.xmm, x.xmm);

        /// <summary>
        ///  __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vandnot(in Vec128<ushort> x, in Vec128<ushort> y)
            => AndNot(y.xmm, x.xmm);

        /// <summary>
        ///  __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vandnot(in Vec128<int> x, in Vec128<int> y)
            => AndNot(y.xmm, x.xmm);

        /// <summary>
        ///  __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vandnot(in Vec128<uint> x, in Vec128<uint> y)
            => AndNot(y.xmm, x.xmm);

        /// <summary>
        ///  __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vandnot(in Vec128<long> x, in Vec128<long> y)
            => AndNot(y.xmm, x.xmm);
 
        /// <summary>
        ///  __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vandnot(in Vec128<ulong> x, in Vec128<ulong> y)
            => AndNot(y.xmm, x.xmm);
 
    
        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vandnot(in Vec256<sbyte> x, in Vec256<sbyte> y)
            => AndNot(y.ymm, x.ymm);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vandnot(in Vec256<byte> x, in Vec256<byte> y)
            => AndNot(y.ymm, x.ymm);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vandnot(in Vec256<short> x, in Vec256<short> y)
            => AndNot(y.ymm, x.ymm);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vandnot(in Vec256<ushort> x, in Vec256<ushort> y)
            => AndNot(y.ymm, x.ymm);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vandnot(in Vec256<int> x, in Vec256<int> y)
            => AndNot(y.ymm, x.ymm);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vandnot(in Vec256<uint> x, in Vec256<uint> y)
            => AndNot(y.ymm, x.ymm);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vandnot(in Vec256<long> x, in Vec256<long> y)
            => AndNot(y.ymm, x.ymm);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation x & (~y) for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vandnot(in Vec256<ulong> x, in Vec256<ulong> y)
            => AndNot(y.ymm, x.ymm);

    }
}