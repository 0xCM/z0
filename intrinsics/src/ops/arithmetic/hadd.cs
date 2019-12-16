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
    
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Ssse3;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;

    partial class dinx
    {
        /// <summary>
        /// Computes the horizontal sum of the source vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vhadd(Vector128<sbyte> x, Vector128<sbyte> y)
        {
            vinflate(x, out var x0, out var x1);
            vinflate(x, out var y0, out var y1);
            var z0 = vhadd(x0,y0);
            var z1 = vhadd(x1,y1);
            return vcompact(z0,z1);
        }

        /// <summary>
        /// Computes the horizontal sum of the source vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vhadd(Vector128<byte> x, Vector128<byte> y)
        {
            vinflate(x, out Vector128<short>  x0, out Vector128<short> x1);
            vinflate(x, out Vector128<short>  y0, out Vector128<short> y1);
            var z0 = vhadd(x0,y0);
            var z1 = vhadd(x1,y1);
            return vcompact(z0,z1, out Vector128<byte> _);
        }

        /// <summary>
        /// __m128i _mm_hadd_epi16 (__m128i a, __m128i b) PHADDW xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vhadd(Vector128<short> x, Vector128<short> y)
            => HorizontalAdd(x, y);

        /// <summary>
        /// __m128i _mm_hadd_epi32 (__m128i a, __m128i b) PHADDD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vhadd(Vector128<int> x, Vector128<int> y)
            => HorizontalAdd(x, y);

        /// <summary>
        /// Computes the horizontal sum of the source vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vhadd(Vector256<sbyte> x, Vector256<sbyte> y)
        {
            vinflate(x, out var x0, out var x1);
            vinflate(x, out var y0, out var y1);
            var z0 = vhadd(x0,y0);
            var z1 = vhadd(x1,y1);
            return vcompact(z0,z1);
        }

        // [MethodImpl(Inline)]
        // public static Vector256<byte> vhadd(Vector256<byte> x, Vector256<byte> y)
        // {
        //     vinflate(x, out Vector256<short>  x0, out Vector256<short> x1);
        //     vinflate(x, out Vector256<short>  y0, out Vector256<short> y1);
        //     var z0 = vhadd(x0,y0);
        //     var z1 = vhadd(x1,y1);
        //     return vcompact(z0,z1, out Vector256<byte> _);
        // }


        /// <summary>
        /// __m256i _mm256_hadd_epi16 (__m256i a, __m256i b) VPHADDW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vhadd(Vector256<short> x, Vector256<short> y)
            => HorizontalAdd(x, y);

        /// <summary>
        /// m256i _mm256_hadd_epi32 (__m256i a, __m256i b) VPHADDD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vhadd(Vector256<int> x, Vector256<int> y)
            => HorizontalAdd(x, y);
   }
}