//-----------------------------------------------------------------------------
// Copymask   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static zfunc;    

    partial class dinx
    {

        /// <summary>
        /// int _mm_testnzc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <algorithm>
        /// IF (a[127:0] AND b[127:0] == 0)
        ///     ZF := 1
        /// ELSE
        ///     ZF := 0
        /// FI
        /// IF ((NOT a[127:0]) AND b[127:0] == 0)
        ///     CF := 1
        /// ELSE
        ///     CF := 0
        /// FI
        /// IF (ZF == 0 && CF == 0)
        ///     dst := 1
        /// ELSE
        ///     dst := 0
        /// FI        
        /// </algorithm>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec128<sbyte> x, in Vec128<sbyte> y)
            => TestNotZAndNotC(x.xmm, y.xmm);        

        /// <summary>
        /// int _mm_testnzc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec128<byte> x, in Vec128<byte> y)
            => TestNotZAndNotC(x.xmm, y.xmm);        

        /// <summary>
        /// int _mm_testnzc_si128 (__m128i a, __m128i b)PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec128<short> x, in Vec128<short> y)
            => TestNotZAndNotC(x.xmm, y.xmm);        

        /// <summary>
        /// int _mm_testnzc_si128 (__m128i a, __m128i b)PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec128<ushort> x, in Vec128<ushort> y)
            => TestNotZAndNotC(x.xmm, y.xmm);        

        /// <summary>
        /// int _mm_testnzc_si128 (__m128i a, __m128i b)PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec128<int> x, in Vec128<int> y)
            => TestNotZAndNotC(x.xmm, y.xmm);        

        /// <summary>
        /// int _mm_testnzc_si128 (__m128i a, __m128i b)PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec128<uint> x, in Vec128<uint> y)
            => TestNotZAndNotC(x.xmm, y.xmm);        

        /// <summary>
        /// int _mm_testnzc_si128 (__m128i a, __m128i b)PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec256<sbyte> x, in Vec256<sbyte> y)
            => TestNotZAndNotC(x.ymm, y.ymm);        

        /// <summary>
        /// int _mm256_testnzc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec256<byte> x, in Vec256<byte> y)
            => TestNotZAndNotC(x.ymm, y.ymm);        

        /// <summary>
        /// int _mm256_testnzc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec256<short> x, in Vec256<short> y)
            => TestNotZAndNotC(x.ymm, y.ymm);        

        /// <summary>
        /// int _mm256_testnzc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec256<ushort> x, in Vec256<ushort> y)
            => TestNotZAndNotC(x.ymm, y.ymm);        

        /// <summary>
        /// int _mm256_testnzc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec256<int> x, in Vec256<int> y)
            => TestNotZAndNotC(x.ymm, y.ymm);        

        /// <summary>
        /// int _mm256_testnzc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testznc(in Vec256<uint> x, in Vec256<uint> y)
            => TestNotZAndNotC(x.ymm, y.ymm);        
    }

}