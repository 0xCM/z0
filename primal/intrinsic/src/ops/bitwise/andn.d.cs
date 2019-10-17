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
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vandn(Vector128<sbyte> x, Vector128<sbyte> y)
            => AndNot(x, y);

        /// <summary>
        /// __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vandn(Vector128<byte> x, Vector128<byte> y)
            => AndNot(x, y);

        /// <summary>
        ///  __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vandn(Vector128<short> x, Vector128<short> y)
            => AndNot(x, y);

        /// <summary>
        ///  __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vandn(Vector128<ushort> x, Vector128<ushort> y)
            => AndNot(x, y);

        /// <summary>
        ///  __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vandn(Vector128<int> x, Vector128<int> y)
            => AndNot(x, y);

        /// <summary>
        ///  __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vandn(Vector128<uint> x, Vector128<uint> y)
            => AndNot(x, y);

        /// <summary>
        ///  __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vandn(Vector128<long> x, Vector128<long> y)
            => AndNot(x, y);
 
        /// <summary>
        ///  __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vandn(Vector128<ulong> x, Vector128<ulong> y)
            => AndNot(x, y);
 
        /// <summary>
        /// __m128 _mm_andnot_ps (__m128 a, __m128 b) ANDNPS xmm, xmm/m128
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<float> vandn(Vector128<float> x, Vector128<float> y)
            => AndNot(x, y);

        /// <summary>
        /// _mm_andnot_pd:
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<double> vandn(Vector128<double> x, Vector128<double> y)
            => AndNot(x, y);        
    
        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vandn(Vector256<sbyte> x, Vector256<sbyte> y)
            => AndNot(x, y);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vandn(Vector256<byte> x, Vector256<byte> y)
            => AndNot(x, y);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vandn(Vector256<short> x, Vector256<short> y)
            => AndNot(x, y);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vandn(Vector256<ushort> x, Vector256<ushort> y)
            => AndNot(x, y);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vandn(Vector256<int> x, Vector256<int> y)
            => AndNot(x, y);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vandn(Vector256<uint> x, Vector256<uint> y)
            => AndNot(x, y);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vandn(Vector256<long> x, Vector256<long> y)
            => AndNot(x, y);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vandn(Vector256<ulong> x, Vector256<ulong> y)
            => AndNot(x, y);

        /// <summary>
        /// __m256 _mm256_andnot_ps (__m256 a, __m256 b) VANDNPS ymm, ymm, ymm/m256
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vandn(Vector256<float> x, Vector256<float> y)
            => AndNot(x, y);

        /// <summary>
        /// __m256d _mm256_andnot_pd (__m256d a, __m256d b) VANDNPD ymm, ymm, ymm/m256
        /// Effects the composite operation (~ x) & y for the left and right operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vandn(Vector256<double> x, Vector256<double> y)
            => AndNot(x, y);
    }
}