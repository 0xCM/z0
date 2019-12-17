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
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static System.Runtime.Intrinsics.X86.Avx2;    
     
    using static As;
    using static zfunc;

    partial class dinx
    {                
        // ~ 128x8i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// 16x8i -> (8x16i, 8x16i)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline)]
        public static void vconvert(Vector128<sbyte> src, out Vector128<short> lo, out Vector128<short> hi)
        {            
            vmaplo(src, out lo);
            vmaphi(src, out hi);            
        }

        /// <summary>
        /// 16x8i -> (8x16i, 8x16i)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline)]
        public static ConstPair<Vector128<short>> vconvert(Vector128<sbyte> src, N128 w, short t = default)
        {            
            vmaplo(src, out Vector128<short> x0);
            vmaphi(src, out Vector128<short> x1);            
            return Tuples.constant(x0,x1);
        }

        /// <summary>
        /// 16x8i -> (8x16u, 8x16u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline)]
        public static void vconvert(Vector128<sbyte> src, out Vector128<ushort> lo, out Vector128<ushort> hi)
        {
            vmaplo(src, out lo);
            vmaphi(src, out hi);            
        }

        /// <summary>
        /// __m256i _mm256_cvtepi8_epi16 (__m128i a) VPMOVSXBW ymm, xmm/m128
        /// 16x8i -> 16x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vconvert(Vector128<sbyte> src, out Vector256<short> dst)
            => dst = ConvertToVector256Int16(src);

        /// <summary>
        /// 16x8i -> (8x32i, 8x32i)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline)]
        public static void vconvert(Vector128<sbyte> src, out Vector256<int> lo, out Vector256<int> hi)
        {
            vmaplo(src, out lo);
            vmaphi(src, out hi);            
        }

        /// <summary>
        /// 16x8i -> (4x32i, 4x32i, 4x32i, 4x32i)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline)]
        public static ConstQuad<Vector128<int>> vconvert(Vector128<sbyte> src, N128 w, int t = default)
        {
            vmaplo(src, out Vector256<int> lo);
            vmaphi(src, out Vector256<int> hi);
            return Tuples.constant(vlo(lo), vhi(lo), vlo(hi), vhi(hi));

        }

        // ~ 128x8u -> X
        // ~ ------------------------------------------------------------------        

        /// <summary>
        /// 16x8u -> (8x16u, 8x16u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline)]
        public static void vconvert(Vector128<byte> src, out Vector128<ushort> lo, out Vector128<ushort> hi)
        {
            vmaplo(src, out lo);
            vmaphi(src, out hi);            
        }

        /// <summary>
        /// 16x8u -> (8x16i, 8x16i)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline)]
        public static void vconvert(Vector128<byte> src, out Vector128<short> lo, out Vector128<short> hi)
        {
            vmaplo(src, out lo);
            vmaphi(src, out hi);            
        }

        /// <summary>
        /// 16x8u -> (8x16u, 8x16u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline)]
        public static ConstPair<Vector128<ushort>> vconvert(Vector128<byte> src, N128 w, ushort t = default)
        {
            vmaplo(src, out Vector128<ushort> a);
            vmaphi(src, out Vector128<ushort> b);
            return Tuples.constant(a,b);
        }

        [MethodImpl(Inline)]
        public static ConstQuad<Vector128<uint>> vconvert(Vector128<byte> src, N128 w, uint t = default)        
        {
            vconvert(src, out Vector128<ushort> lo, out Vector128<ushort> hi);
            vmaplo(lo, out Vector128<uint> x0);
            vmaphi(lo, out Vector128<uint> x1);
            vmaplo(hi, out Vector128<uint> x2);
            vmaphi(hi, out Vector128<uint> x3);
            return Tuples.constant(x0,x0,x2,x3);
        }

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi16 (__m128i a) vpmovzxbw ymm, xmm
        /// 16x8u -> 16x16i
        /// src[i] -> dst[i], i = 0,...,15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vconvert(Vector128<byte> src, out Vector256<short> dst)
            => dst = ConvertToVector256Int16(src);

        /// <summary>
        ///  __m256i _mm256_cvtepu8_epi16 (__m128i a) VPMOVZXBW ymm, xmm
        /// 16x8u -> 16x16u
        /// src[i] -> dst[i], i = 0,...,15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vconvert(Vector128<byte> src, out Vector256<ushort> dst)
            => dst = v16u(ConvertToVector256Int16(src));        

        /// <summary>
        ///  __m256i _mm256_cvtepu8_epi16 (__m128i a) VPMOVZXBW ymm, xmm
        /// 16x8u -> 16x16u
        /// src[i] -> dst[i], i = 0,...,15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width selector</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vconvert(Vector128<byte> src, N256 w, ushort t = default)
            => v16u(ConvertToVector256Int16(src));        

        /// <summary>
        /// 16x8u -> (8x32u, 8x32u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline)]
        public static void vconvert(Vector128<byte> src, out Vector256<uint> lo, out Vector256<uint> hi)
        {            
            vmaplo(src, out lo);
            vmaphi(src, out hi);
        }

        /// <summary>
        /// 16x8u -> (8x32u, 8x32u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline)]
        public static ConstPair<Vector256<uint>> vconvert(Vector128<byte> src, N256 w, uint t = default)
        {            
            vmaplo(src, out Vector256<uint> lo);
            vmaphi(src, out Vector256<uint> hi);
            return Tuples.constant(lo,hi);
        }

        // ~ 128x16i -> X
        // ~ ------------------------------------------------------------------        

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// 8x16i -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vconvert(Vector128<short> src, out Vector256<int> dst)
        {
            dst = ConvertToVector256Int32(src);
            return dst;
        }

        /// <summary>
        /// 8x16i -> (4x32i, 4x32i)
        /// </summary>
        /// <param name="src"></param>
        /// <param name="x0"></param>
        /// <param name="x1"></param>
        [MethodImpl(Inline)]
        public static void vconvert(Vector128<short> src, out Vector128<int> x0, out Vector128<int> x1)
        {
            vconvert(src, out Vector256<int> dst);
            x0 = vlo(dst);
            x1 = vhi(dst);
        }

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi32 (__m128i a) VPMOVZXBD ymm, xmm
        /// 8x16i -> 8x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vconvert(Vector128<short> src, out Vector256<uint> dst)
            => dst = v32u(ConvertToVector256Int32(src));

        // ~ 128x16u -> X
        // ~ ------------------------------------------------------------------        

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi32 (__m128i a) VPMOVZXWD ymm, xmm
        /// 8x16u -> 8x32i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vconvert(Vector128<ushort> src, out Vector256<int> dst)
            => dst = ConvertToVector256Int32(src);

        /// <summary>
        /// __m256i _mm256_cvtepu16_epi32 (__m128i a) VPMOVZXWD ymm, xmm
        /// 8x16u -> 8x32u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vconvert(Vector128<ushort> src, out Vector256<uint> dst)
            => dst = v32u(ConvertToVector256Int32(src));

        /// <summary>
        /// 8x16u -> (4x32u, 4x32u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline)]
        public static void vconvert(Vector128<ushort> src, out Vector128<uint> lo, out Vector128<uint> hi)
        {
            vconvert(src, out Vector256<uint> dst);
            lo = vlo(dst);
            hi = vhi(dst);
        }

        // ~ 128x32i -> X
        // ~ ------------------------------------------------------------------        

        /// <summary>
        /// __m256i _mm256_cvtepi32_epi64 (__m128i a) VPMOVSXDQ ymm, xmm/m128
        /// 4x32i -> 4x64i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vconvert(Vector128<int> src, N256 w, long t = default)
            => ConvertToVector256Int64(src);

        // ~ 128x32u -> X
        // ~ ------------------------------------------------------------------        

        /// <summary>
        ///  __m256i _mm256_cvtepu32_epi64 (__m128i a) VPMOVZXDQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vconvert(Vector128<uint> src, N256 w, long t = default)
            => ConvertToVector256Int64(src);

        /// <summary>
        /// _m256i _mm256_cvtepu32_epi64 (__m128i a) VPMOVZXDQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vconvert(Vector128<uint> src, out Vector256<ulong> dst)
            => dst = v64u(ConvertToVector256Int64(src));

        /// <summary>
        /// 4x32u -> (2x64u, 2x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector</param>
        /// <param name="x1">The second target vector</param>
        [MethodImpl(Inline)]
        public static void vconvert(Vector128<uint> src, out Vector128<ulong> x0, out Vector128<ulong> x1)
        {
            vconvert(src, out Vector256<ulong> dst);
            x0 = vlo(dst);
            x1 = vhi(dst);
        }

        /// <summary>
        /// 4x32i -> (2x64i, 2x64i)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">The first target vector</param>
        /// <param name="x1">The second target vector</param>
        [MethodImpl(Inline)]
        public static void vconvert(Vector128<int> src, out Vector128<long> x0, out Vector128<long> x1)
        {
            var dst = vconvert(src,n256,z64i);
            x0 = vlo(dst);
            x1 = vhi(dst);
        }

        // ~ 256
        // ~ ------------------------------------------------------------------     

        /// <summary>
        /// src[i] -> lo[i], i = 1,..,15
        /// src[i] -> hi[i], i = 16,..,31
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline)]
        public static void vconvert(Vector256<sbyte> src, out Vector256<short> lo, out Vector256<short> hi)
        {
            vmaplo(src, out lo);
            vmaphi(src, out hi);
        }

        /// <summary>
        /// 32x8i -> (8x32i, 8x32i, 8x32i, 8x32i)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static ConstQuad<Vector256<int>> vconvert(Vector256<sbyte> src, N256 w, int t = default)
        {
            vconvert(src, out Vector256<short> lo, out Vector256<short> hi);
            vconvert(lo, out var x0, out var x1);
            vconvert(hi, out var x2, out var x3);
            return Tuples.constant(x0,x1,x2,x3);
        }

        /// <summary>
        /// 32x8u -> (16x16u, 16x16u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The first target vector</param>
        /// <param name="hi">The second target vector</param>
        [MethodImpl(Inline)]
        public static void vconvert(Vector256<byte> src, out Vector256<ushort> lo, out Vector256<ushort> hi)
        {
            lo = vmaplo(src, n256, z16);
            hi = vmaphi(src, n256, z16);
        }

        /// <summary>
        /// 32x8u -> (16x16u, 16x16u)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static ConstPair<Vector256<ushort>> vconvert(Vector256<byte> src, N256 w, ushort t = default)
             => Tuples.constant(vmaplo(src, n256, z16), vmaphi(src, n256, z16));

        /// <summary>
        /// 32x8u -> (16x16i, 16x16i)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static ConstPair<Vector256<short>> vconvert(Vector256<byte> src, N256 w, short t = default)
            => Tuples.constant(vmaplo(src, w, z16i),vmaphi(src, w, z16i));

        /// <summary>
        /// 32x8u -> (8x32u, 8x32u, 8x32u, 8x32u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="x1">A target cell type representative</param>
        [MethodImpl(Inline)]
        public static ConstQuad<Vector256<uint>> vconvert(Vector256<byte> src, N256 w, uint t = default)
        {
            (var lo, var hi) = vconvert(src, w, z16);            
            (var x0, var x1) = vconvert(lo, w, t);
            (var x2, var x3) = vconvert(hi, w, t);
            return Tuples.constant(x0,x1,x2,x3);
        }

        /// <summary>
        /// 8x16x -> (4x64u,4x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline)]
        public static void vconvert(Vector128<ushort> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
        {
            vmaplo(src, out lo);
            vmaphi(src, out hi);
        }

        /// <summary>
        /// 8x16x -> (4x64u,4x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline)]
        public static void vconvert(Vector128<short> src, out Vector256<long> lo, out Vector256<long> hi)
        {
            vmaplo(src, out lo);
            vmaphi(src, out hi);
        }

        /// <summary>
        /// 16x16u -> (4x64u, 4x64u, 4x64u, 4x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target cell type representative</param>
        [MethodImpl(Inline)]
        public static ConstQuad<Vector256<ulong>> vconvert(Vector256<ushort> src, N256 w, ulong t = default)
        {
            vconvert(vlo(src), out Vector256<ulong> x0, out var x1);
            vconvert(vhi(src), out Vector256<ulong> x2, out var x3);            
            return Tuples.constant(x0,x1,x2,x3);
        }

        /// <summary>
        /// 16x16i -> (8x32i, 8x32i)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline)]
        public static void vconvert(Vector256<short> src, out Vector256<int> lo, out Vector256<int> hi)
        {
            vmaplo(src, out lo);
            vmaphi(src, out hi);
        }

        /// <summary>
        /// 16x16i -> (8x32i, 8x32i)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline)]
        public static ConstPair<Vector256<int>> vconvert(Vector256<short> src, N256 w, int t = default)
        {
            vmaplo(src, out Vector256<int> lo);
            vmaphi(src, out Vector256<int> hi);
            return Tuples.constant(lo,hi);
        }

        /// <summary>
        /// 16x16u -> (8x32u, 8x32u)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline)]
        public static void vconvert(Vector256<ushort> src, out Vector256<uint> lo, out Vector256<uint> hi)
        {
            vmaplo(src, out lo);
            vmaphi(src, out hi);
        }

        [MethodImpl(Inline)]
        public static ConstPair<Vector256<uint>> vconvert(Vector256<ushort> src, N256 w, uint t = default)
        {
            vmaplo(src, out Vector256<uint> lo);
            vmaphi(src, out Vector256<uint> hi);
            return Tuples.constant(lo,hi);
        }

        /// <summary>
        /// 8x32i -> (4x64i, 4x64i)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static ConstPair<Vector256<long>> vconvert(Vector256<int> src, N256 w, long t = default)
        {
            vmaplo(src, out Vector256<long> lo);
            vmaphi(src, out Vector256<long> hi);
            return Tuples.constant(lo,hi);
        }

        /// <summary>
        /// 8x32u -> (4x64u, 4x64u)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static ConstPair<Vector256<ulong>> vconvert(Vector256<uint> src, N256 w, ulong t = default)
        {
            vmaplo(src, out Vector256<ulong> lo);
            vmaphi(src, out Vector256<ulong> hi);
            return Tuples.constant(lo,hi);
        }

        [MethodImpl(Inline)]
        static void vconvert8(Vector256<short> src, out Vector256<long> lo, out Vector256<long> hi)
        {
            lo = ConvertToVector256Int64(vlo(src));
            hi = ConvertToVector256Int64(vhi(src));
        }

        /// <summary>
        /// __m128i _mm_cvtepi8_epi32 (__m128i a) PMOVSXBD xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static Vector128<int> vconvert4(Vector128<sbyte> src, out Vector128<int> dst)
        {
            dst = ConvertToVector128Int32(src);
            return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepi8_epi32 (__m128i a) PMOVSXBD xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static Vector128<uint> vconvert4(Vector128<sbyte> src, out Vector128<uint> dst)
        {
            dst = v32u(ConvertToVector128Int32(src));
            return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepi8_epi64 (__m128i a) PMOVSXBQ xmm, xmm/m16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static Vector128<long> vconvert2(Vector128<sbyte> src, out Vector128<long> dst)
        {
            dst = ConvertToVector128Int64(src);
            return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepi8_epi64 (__m128i a) PMOVSXBQ xmm, xmm/m16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static Vector128<ulong> vconvert2(Vector128<sbyte> src, out Vector128<ulong> dst)
        {
            dst = v64u(ConvertToVector128Int64(src));
            return dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepi8_epi64 (__m128i a) VPMOVSXBQ ymm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static Vector256<long> vconvert4(Vector128<sbyte> src, out Vector256<long> dst)
        {
            dst = ConvertToVector256Int64(src);
            return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepu8_epi32 (__m128i a) PMOVZXBD xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static Vector128<int> vconvert4(Vector128<byte> src, out Vector128<int> dst)
        {
            dst = ConvertToVector128Int32(src);
            return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepu8_epi32 (__m128i a) PMOVZXBD xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static Vector128<uint> vconvert4(Vector128<byte> src, out Vector128<uint> dst)
        {
            dst = v32u(ConvertToVector128Int32(src));
            return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepi32_epi64 (__m128i a) PMOVSXDQ xmm, xmm/m64
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static Vector128<long> vconvert2(Vector128<byte> src, out Vector128<long> dst)
        {
            dst = ConvertToVector128Int64(src);
            return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepu8_epi64 (__m128i a) PMOVZXBQ xmm, xmm/m16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static Vector128<ulong> vconvert2(Vector128<byte> src, out Vector128<ulong> dst)
        {
            dst = v64u(ConvertToVector128Int64(src));
            return  dst;
        }

        /// <summary>
        ///  __m128i _mm_cvtepu16_epi64 (__m128i a) PMOVZXWQ xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static Vector128<long> vconvert2(Vector128<ushort> src, out Vector128<long> dst)
        {
           dst = ConvertToVector128Int64(src);
           return dst;
        }

        /// <summary>
        ///  __m128i _mm_cvtepu16_epi64 (__m128i a) PMOVZXWQ xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static Vector128<ulong> vconvert2(Vector128<ushort> src, out Vector128<ulong> dst)
        {
           dst = v64u(ConvertToVector128Int64(src));
           return dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi64 (__m128i a) VPMOVZXBQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static Vector256<long> vconvert4(Vector128<byte> src, out Vector256<long> dst)
        {
            dst = ConvertToVector256Int64(src);
            return dst;
        }

        /// <summary>
        /// __m256i _mm256_cvtepu8_epi64 (__m128i a) VPMOVZXBQ ymm, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static Vector256<ulong> vconvert4(Vector128<byte> src, out Vector256<ulong> dst)
        {
            dst = v64u(ConvertToVector256Int64(src));
            return dst;
        }

        /// <summary>
        /// __m128i _mm_cvtepi16_epi64 (__m128i a) PMOVSXWQ xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static Vector128<long> vconvert2(Vector128<short> src, out Vector128<long> dst)
        {
            dst = ConvertToVector128Int64(src);
            return dst;
        }
    }
}