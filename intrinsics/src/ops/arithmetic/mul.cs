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

    using static System.Runtime.Intrinsics.X86.Pclmulqdq;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Ssse3;

    using static zfunc;
    using static As;

    partial class dinx
    {
        /// <summary>
        /// Computes the full 16-bit product of corresponding left and right source components
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="lo">Receiver for the product of the lower components</param>
        /// <param name="hi">Receiver for the product of the upper components</param>
        [MethodImpl(Inline)]
        public static void vmul(Vector128<sbyte> x, Vector128<sbyte> y, out Vector128<short> lo, out Vector128<short> hi)
        {
            vinflate(x, out Vector128<short> x1, out var x2);
            vinflate(y, out Vector128<short> y1, out var y2);
            lo = vmullo(x1,y1);
            hi = vmullo(x2,y2);
        }

        /// <summary>
        /// Computes the full 16-bit product of corresponding left and right source components
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="lo">Receiver for the product of the lower components</param>
        /// <param name="hi">Receiver for the product of the upper components</param>
        [MethodImpl(Inline)]
        public static void vmul(Vector128<byte> x, Vector128<byte> y, out Vector128<ushort> lo, out Vector128<ushort> hi)
        {
            vinflate(x, out Vector128<ushort> x1, out var x2);
            vinflate(y, out Vector128<ushort> y1, out var y2);
            lo = vmullo(x1,y1);
            hi = vmullo(x2,y2);
        }

        /// <summary>
        /// Computes the full 32-bit product of corresponding left and right source components
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="lo">Receiver for the product of the lower components</param>
        /// <param name="hi">Receiver for the product of the upper components</param>
        [MethodImpl(Inline)]
        public static void vmul(Vector128<short> x, Vector128<short> y, out Vector128<int> lo, out Vector128<int> hi)
        {
            vinflate(x, out Vector128<int> x1, out var x2);
            vinflate(y, out Vector128<int> y1, out var y2);
            lo = vmullo(x1,y1);
            hi = vmullo(x2,y2);
        }

        /// <summary>
        /// Computes the full 32-bit product of corresponding left and right source components
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="lo">Receiver for the product of the lower components</param>
        /// <param name="hi">Receiver for the product of the upper components</param>
        [MethodImpl(Inline)]
        public static void vmul(Vector128<ushort> x, Vector128<ushort> y, out Vector128<uint> lo, out Vector128<uint> hi)
        {
            vinflate(x, out Vector128<uint> x1, out var x2);
            vinflate(y, out Vector128<uint> y1, out var y2);
            lo = vmullo(x1,y1);
            hi = vmullo(x2,y2);
        }

        /// <summary>
        /// Computes the full 16-bit product of corresponding left and right source components
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="lo">Receiver for the product of the lower components</param>
        /// <param name="hi">Receiver for the product of the upper components</param>
        [MethodImpl(Inline)]
        public static void vmul(Vector256<sbyte> x, Vector256<sbyte> y, out Vector256<short> lo, out Vector256<short> hi)
        {
            vinflate(x, out var x1, out var x2);
            vinflate(y, out var y1, out var y2);
            lo = vmullo(x1,y1);
            hi = vmullo(x2,y2);
        }

        /// <summary>
        /// Computes the full 16-bit product of corresponding left and right source components
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="lo">Receiver for the product of the lower components</param>
        /// <param name="hi">Receiver for the product of the upper components</param>
        [MethodImpl(Inline)]
        public static void vmul(Vector256<byte> x, Vector256<byte> y, out Vector256<ushort> lo, out Vector256<ushort> hi)
        {
            vinflate(x, out var x1, out var x2);
            vinflate(y, out var y1, out var y2);
            lo = vmullo(x1,y1);
            hi = vmullo(x2,y2);
        }

        /// <summary>
        /// Computes the full 32-bit product of corresponding left and right source components
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="lo">Receiver for the product of the lower components</param>
        /// <param name="hi">Receiver for the product of the upper components</param>
        [MethodImpl(Inline)]
        public static void vmul(Vector256<ushort> x, Vector256<ushort> y, out Vector256<uint> lo, out Vector256<uint> hi)
        {
            vinflate(x, out var x1, out var x2);
            vinflate(y, out var y1, out var y2);
            lo = vmullo(x1,y1);
            hi = vmullo(x2,y2);
        }

        /// <summary>
        /// Computes the full 32-bit product of corresponding left and right source components
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="lo">Receiver for the product of the lower components</param>
        /// <param name="hi">Receiver for the product of the upper components</param>
        [MethodImpl(Inline)]
        public static void vmul(Vector256<short> x, Vector256<short> y, out Vector256<int> lo, out Vector256<int> hi)
        {
            vinflate(x, out var x1, out var x2);
            vinflate(y, out var y1, out var y2);
            lo = vmullo(x1,y1);
            hi = vmullo(x2,y2);
        }

        /// <summary>
        ///  __m128i _mm_mul_epi32 (__m128i a, __m128i b)PMULDQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vmul(Vector128<int> x, Vector128<int> y)
            => Multiply(x, y);

        /// <summary>
        /// __m128i _mm_mul_epu32 (__m128i a, __m128i b) PMULUDQ xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vmul(Vector128<uint> x, Vector128<uint> y)
            => Multiply(x, y);

        /// <summary>
        /// __m256i _mm256_mul_epi32 (__m256i a, __m256i b) VPMULDQ ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vmul(Vector256<int> x,Vector256<int> y)
            => Multiply(x, y);

        /// <summary>
        ///  __m256i _mm256_mul_epu32 (__m256i a, __m256i b) VPMULUDQ ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vmul(Vector256<uint> x,Vector256<uint> y)
            => Multiply(x, y);                        

        /// <summary>
        /// Multiplies two two 256-bit/u64 vectors to yield a 256-bit/u64 vector; only provides reasonable
        /// results if there's no 64-bit overflow
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        static Vector256<ulong> vmul(Vector256<ulong> x, Vector256<ulong> y)    
        {
            var loMask = vbroadcast(n256, 0x00000000fffffffful);                
            var xh = v32u(vsrl(x, 32));
            var yl = v32u(vand(y, loMask));
            return vadd(
                vmul(v32u(vand(x, loMask)), yl), 
                vadd(vsll(vmul(xh, yl), 32), 
                    vsll(vmul(xh, v32u(vsrl(y, 32))), 32)));
        }

        /// <summary>
        /// __m128i _mm_mulhrs_epi16 (__m128i a, __m128i b)PMULHRSW xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vmulhrs(Vector128<short> x, Vector128<short> y)
            => MultiplyHighRoundScale(x,y);

        /// <summary>
        ///  __m256i _mm256_mulhrs_epi16 (__m256i a, __m256i b)VPMULHRSW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vmulhrs(Vector256<short> x, Vector256<short> y)
            => MultiplyHighRoundScale(x,y);

    }
}