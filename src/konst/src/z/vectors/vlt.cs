//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// [10000000]
        /// </summary>
        const byte SignMask8 = Pow2.T07;

        /// <summary>
        /// [10000000 00000000]
        /// </summary>
        const ushort SignMask16 = Pow2.T15;
        
        /// <summary>
        /// [10000000 00000000 00000000 00000000]
        /// </summary>
        const uint SignMask32 = Pow2.T31;

        /// <summary>
        /// [10000000 00000000 00000000 00000000 00000000 00000000 00000000 00000000]
        /// </summary>
        const ulong SignMask64 = Pow2.T63;

        /// <summary>
        /// __m128i _mm_cmplt_epi8 (__m128i a, __m128i b)PCMPGTB xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Lt]
        public static Vector128<sbyte> vlt(Vector128<sbyte> x, Vector128<sbyte> y)
            => CompareLessThan(x,y);

        /// <summary>
        /// __m128i _mm_cmplt_epi8 (__m128i a, __m128i b)PCMPGTB xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Lt]
        public static Vector128<byte> vlt(Vector128<byte> x, Vector128<byte> y)
        {
            var mask = vbroadcast(n128, SignMask8);
            var mx = v8i(vxor(x,mask));
            var my = v8i(vxor(y,mask));
            return v8u(CompareLessThan(mx,my));
        }

        /// <summary>
        /// __m128i _mm_cmplt_epi16 (__m128i a, __m128i b)PCMPGTW xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Lt]
        public static Vector128<short> vlt(Vector128<short> x, Vector128<short> y)
            => CompareLessThan(x,y);

        /// <summary>
        /// __m128i _mm_cmplt_epi16 (__m128i a, __m128i b)PCMPGTW xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Lt]
        public static Vector128<ushort> vlt(Vector128<ushort> x, Vector128<ushort> y)
        {
            var mask = vbroadcast(n128, SignMask16);
            var mx = v16i(vxor(x,mask));
            var my = v16i(vxor(y,mask));
            return v16u(CompareLessThan(mx,my));
        }

        /// <summary>
        /// __m128i _mm_vcmplt_epi32 (__m128i a, __m128i b)PCMPGTD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Lt]
        public static Vector128<int> vlt(Vector128<int> x, Vector128<int> y)
            => CompareGreaterThan(y,x);

        /// <summary>
        /// __m128i _mm_vcmplt_epi32 (__m128i a, __m128i b)PCMPGTD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Lt]
        public static Vector128<uint> vlt(Vector128<uint> x, Vector128<uint> y)
        {
            var mask = vbroadcast(n128, SignMask32);
            return v32u(CompareLessThan(v32i(vxor(x,mask)), v32i(vxor(y,mask))));
        }

        /// <summary>
        /// __m256i _mm256_cmpgt_epi64 (__m256i a, __m256i b) VPCMPGTQ ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Lt]
        public static Vector128<long> vlt(Vector128<long> x, Vector128<long> y)
        {
            var a = vconcat(x,y);
            var b = vswaphl(a);            
            return vlo(vlt(a,b));
        }

        /// <summary>
        /// __m256i _mm256_cmpgt_epi64 (__m256i a, __m256i b) VPCMPGTQ ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Lt]
        public static Vector128<ulong> vlt(Vector128<ulong> x, Vector128<ulong> y)
        {
            var a = vconcat(x,y);
            var b = vswaphl(a);
            return vlo(vlt(a,b));
        }
        
        /// <summary>
        ///  __m256i _mm256_cmpgt_epi8 (__m256i a, __m256i b) VPCMPGTB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Lt]
        public static Vector256<sbyte> vlt(Vector256<sbyte> x, Vector256<sbyte> y)
            => CompareGreaterThan(y,x);

        /// <summary>
        ///  __m256i _mm256_cmpgt_epi8 (__m256i a, __m256i b) VPCMPGTB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Lt]
        public static Vector256<byte> vlt(Vector256<byte> x, Vector256<byte> y)
        {
            var mask = vbroadcast(n256, SignMask8);
            return v8u(vlt(v8i(vxor(x,mask)), v8i(vxor(y,mask))));
        }

        /// <summary>
        /// __m256i _mm256_cmpgt_epi16 (__m256i a, __m256i b)VPCMPGTW ymm, ymm, ymm/m256 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Lt]
        public static Vector256<short> vlt(Vector256<short> x, Vector256<short> y)
            => CompareGreaterThan(y,x);

        /// <summary>
        /// __m256i _mm256_cmpgt_epi16 (__m256i a, __m256i b) VPCMPGTW ymm, ymm, ymm/m256 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Lt]
        public static Vector256<ushort> vlt(Vector256<ushort> x, Vector256<ushort> y)
        {
            var mask = vbroadcast(n256, SignMask16);
            return v16u(vlt(v16i(vxor(x,mask)), v16i(vxor(y,mask))));
        }

        /// <summary>
        /// __m256i _mm256_cmpgt_epi32 (__m256i a, __m256i b) VPCMPGTD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Lt]
        public static Vector256<int> vlt(Vector256<int> x, Vector256<int> y)
            => CompareGreaterThan(y,x);

        /// <summary>
        /// __m256i _mm256_cmpgt_epi32 (__m256i a, __m256i b) VPCMPGTD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Lt]
        public static Vector256<uint> vlt(Vector256<uint> x, Vector256<uint> y)
        {
            var mask = vbroadcast(n256, SignMask32);
            return v32u(vlt(v32i(vxor(x,mask)), v32i(vxor(y,mask))));
        }

        /// <summary>
        /// __m256i _mm256_cmpgt_epi64 (__m256i a, __m256i b) VPCMPGTQ ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Lt]
        public static Vector256<long> vlt(Vector256<long> x, Vector256<long> y)
            => CompareGreaterThan(y,x);

        /// <summary>
        /// __m256i _mm256_cmpgt_epi64 (__m256i a, __m256i b) VPCMPGTQ ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Lt]
        public static Vector256<ulong> vlt(Vector256<ulong> x, Vector256<ulong> y)
        {
            var mask = vbroadcast(n256,SignMask64);
            return v64u(
                vlt(
                v64i(vxor(x,mask)),
                v64i(vxor(y,mask)))
                );
        }    
    }
}