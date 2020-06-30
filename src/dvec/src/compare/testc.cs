//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static Konst; 
    using static Typed;    
    using static V0;
    
    partial class dvec
    {
        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector128<sbyte> src)
            => TestC(src, vones<sbyte>(w128));

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b)PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector128<byte> src)
            => TestC(src, vones<byte>(w128));

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b)PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector128<ushort> src)
            => TestC(src, vones<ushort>(w128));
        
        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b)PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector128<int> src)
            => TestC(src, vones<int>(w128));

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b)PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector128<uint> src)
            => TestC(src, vones<uint>(w128));

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b)PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector128<long> src)
            => TestC(src, vones<long>(w128));

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b)PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector128<ulong> src)
            => TestC(src, vones<ulong>(w128));

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all mask-identified source bits are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        /// <algorithm>
        /// IF (a[127:0] AND b[127:0] == 0)
        ///     ZF := 1
        /// ELSE
        ///     ZF := 0        
        /// <algorithm>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector128<sbyte> src, Vector128<sbyte> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all mask-identified source bits are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector128<byte> src, Vector128<byte> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all mask-identified source bits are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector128<short> src, Vector128<short> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all mask-identified source bits are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector128<ushort> src, Vector128<ushort> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all mask-identified source bits are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector128<int> src, Vector128<int> mask)
            => TestC(src, mask);        
        
        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all mask-identified source bits are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector128<uint> src, Vector128<uint> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all mask-identified source bits are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector128<long> src, Vector128<long> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all mask-identified source bits are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector128<ulong> src, Vector128<ulong> mask)
            => TestC(src, mask);                     

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all mask-identified source bits are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector256<sbyte> src, Vector256<sbyte> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all mask-identified source bits are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector256<byte> src, Vector256<byte> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all mask-identified source bits are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector256<short> src, Vector256<short> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all mask-identified source bits are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector256<ushort> src, Vector256<ushort> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all mask-identified source bits are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector256<int> src, Vector256<int> mask)
            => TestC(src, mask);        
        
        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all mask-identified source bits are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector256<uint> src, Vector256<uint> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all mask-identified source bits are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector256<long> src, Vector256<long> mask)
            => TestC(src, mask);        

        /// <summary>
        /// _mm256_testc_si256
        /// Returns true if all mask-identified source bits are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline), TestC]
        public static bit vtestc(Vector256<ulong> src, Vector256<ulong> mask)
            => TestC(src, mask);                             
    }
}