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
    using Avx = System.Runtime.Intrinsics.X86.Avx;   
    using static zfunc;    

    partial class dinx
    {
        /// <summary>
        /// int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        /// <algorithm>
        /// IF (a[127:0] AND b[127:0] == 0)
        /// 	ZF := 1
        /// ELSE
        /// 	ZF := 0
        /// FI
        /// </algorithm>
        [MethodImpl(Inline)]
        public static bool testz(in Vec128<byte> src, in Vec128<byte> mask)
            => TestZ(src.xmm, mask.xmm);        

        /// <summary>
        /// int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(in Vec128<sbyte> src, in Vec128<sbyte> mask)
            => TestZ(src.xmm, mask.xmm);        

        /// <summary>
        /// int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(in Vec128<short> src, in Vec128<short> mask)
            => TestZ(src.xmm, mask.xmm);        

        /// <summary>
        /// int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(in Vec128<ushort> src, in Vec128<ushort> mask)
            => TestZ(src.xmm, mask.xmm);        

        /// <summary>
        /// int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(in Vec128<int> src, in Vec128<int> mask)
            => TestZ(src.xmm, mask.xmm);        

        /// <summary>
        /// int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(in Vec128<uint> src, in Vec128<uint> mask)
            => TestZ(src.xmm, mask.xmm);        

        /// <summary>
        /// int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(in Vec128<long> src, in Vec128<long> mask)
            => TestZ(src.xmm, mask.xmm);        

        /// <summary>
        /// int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(in Vec128<ulong> src, in Vec128<ulong> mask)
            => TestZ(src.xmm, mask.xmm);        

        /// <summary>
        /// int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(in Vec256<sbyte> src, in Vec256<sbyte> mask)
            => TestZ(src.ymm, mask.ymm);        

        /// <summary>
        /// int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(in Vec256<byte> src, in Vec256<byte> mask)
            => TestZ(src.ymm, mask.ymm);        

        /// <summary>
        /// int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(in Vec256<short> src, in Vec256<short> mask)
            => TestZ(src.ymm, mask.ymm);        

        /// <summary>
        /// int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(in Vec256<ushort> src, in Vec256<ushort> mask)
            => TestZ(src.ymm, mask.ymm);        

        /// <summary>
        /// int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(in Vec256<int> src, in Vec256<int> mask)
            => TestZ(src.ymm, mask.ymm);        

        /// <summary>
        /// int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(in Vec256<uint> src, in Vec256<uint> mask)
            => TestZ(src.ymm, mask.ymm);        

        /// <summary>
        /// int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(in Vec256<long> src, in Vec256<long> mask)
            => TestZ(src.ymm, mask.ymm);        

        /// <summary>
        /// int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        /// <algorithm>
        /// IF (a[255:0] AND b[255:0] == 0)
        /// 	ZF := 1
        /// ELSE
        /// 	ZF := 0
        /// FI
        /// </algorithm>
        [MethodImpl(Inline)]
        public static bool testz(in Vec256<ulong> src, in Vec256<ulong> mask)
            => TestZ(src.ymm, mask.ymm);        
    }    
}