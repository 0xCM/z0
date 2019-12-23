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

    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;
    using static As;

    partial class dinx
    {         
        /// <summary>
        /// Computes z[i] := x[i] >> s[i] for i = 0..15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vsrlv(Vector128<byte> src, Vector128<byte> offsets)
        {
            var x = vinflate(src, n256, z16);
            var y = vinflate(offsets, n256, z16);
            var z = vsrlv(x,y);            
            return vcompact2(z,n128,z8);
        }

        /// <summary>
        /// Computes z[i] := x[i] >> s[i] for i = 0..7
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vsrlv(Vector128<ushort> src, Vector128<ushort> offsets)
        {
            var x = vinflate(src, n256, z32);
            var y = vinflate(offsets, n256, z32);
            return vcompact2(vsrlv(x,y), n128, z16);
        }

        /// <summary>
        ///  __m128i _mm_srlv_epi32 (__m128i a, __m128i count) VPSRLVD xmm, xmm, xmm/m128
        /// Computes z[i] := x[i] >> offsets[i] for i = 0...3
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vsrlv(Vector128<int> x, Vector128<uint> offsets)
            => ShiftRightLogicalVariable(x, offsets);

        /// <summary>
        /// __m128i _mm_srlv_epi32 (__m128i a, __m128i count) VPSRLVD xmm, xmm, xmm/m128
        /// Computes z[i] := x[i] >> offsets[i] for i = 0...3
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offsets">The offsets offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vsrlv(Vector128<uint> x, Vector128<uint> offsets)
            => ShiftRightLogicalVariable(x, offsets);

        /// <summary>
        /// __m128i _mm_srlv_epi64 (__m128i a, __m128i count) VPSRLVQ xmm, xmm, xmm/m128
        /// Computes z[i] := x[i] >> offsets[i] for i = 0,1
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vsrlv(Vector128<long> x, Vector128<ulong> offsets)
            => ShiftRightLogicalVariable(x, offsets);

        /// <summary>
        /// __m128i _mm_srlv_epi64 (__m128i a, __m128i count) VPSRLVQ xmm, xmm, xmm/m128
        /// Computes z[i] := x[i] >> offsets[i] for i = 0,1
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsrlv(Vector128<ulong> x, Vector128<ulong> offsets)
            => ShiftRightLogicalVariable(x, offsets);       
 
        /// <summary>
        /// Computes z[i] := x[i] >> s[i] for i = 0..31
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vsrlv(Vector256<byte> src, Vector256<byte> offsets)
        {
            (var x0, var x1) = vinflate(src, n512, z16); 
            (var s0, var s1) = vinflate(offsets, n512, z16);
            return vcompact2(vsrlv(x0,s0),vsrlv(x1,s1),n256,z8);            
        }

        /// <summary>
        /// Computes z[i] := x[i] >> s[i] for i = 0..15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vsrlv(Vector256<ushort> src, Vector256<ushort> offsets)
        {
            (var x0, var x1) = vinflate(src, n512, z32); 
            (var s0, var s1) = vinflate(offsets, n512, z32);
            return vcompact2(vsrlv(x0,s0),vsrlv(x1,s1),n256,z16);            
        }

        /// <summary>
        /// __m256i _mm256_srlv_epi32 (__m256i a, __m256i count) VPSRLVD ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] >> offsets[i] for i = 0...7
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vsrlv(Vector256<int> x, Vector256<int> offsets)
            => ShiftRightLogicalVariable(x, v32u(offsets));

        /// <summary>
        /// __m256i _mm256_srlv_epi32 (__m256i a, __m256i count) VPSRLVD ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] >> offsets[i] for i = 0...7
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vsrlv(Vector256<uint> x, Vector256<uint> offsets)
            => ShiftRightLogicalVariable(x, offsets);

        /// <summary>
        /// __m256i _mm256_srlv_epi64 (__m256i a, __m256i count) VPSRLVQ ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] >> offsets[i] for i = 0...3
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vsrlv(Vector256<long> x, Vector256<long> offsets)
            => ShiftRightLogicalVariable(x, v64u(offsets));

        /// <summary>
        ///  __m256i _mm256_srlv_epi64 (__m256i a, __m256i count) VPSRLVQ ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] >> offsets[i] for i = 0...3
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsrlv(Vector256<ulong> x, Vector256<ulong> offsets)
            => ShiftRightLogicalVariable(x, offsets); 
    
    }
}