//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Root;    
    using static gvec;
    using static Nats;

    partial class dinx
    {         
        /// <summary>
        /// Computes z[i] := x[i] >> s[i] for i = 0..15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vsrlv(Vector128<sbyte> src, Vector128<sbyte> counts)
        {
            var x = vinflate(src, n256, z16i);
            var y = vinflate(counts, n256, z16i);
            var z = vsrlv(x,y);            
            return vcompact(z,n128,z8i);
        }

        /// <summary>
        /// Computes z[i] := x[i] >> s[i] for i = 0..15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vsrlv(Vector128<byte> src, Vector128<byte> counts)
        {
            var x = vinflate(src, n256, z16);
            var y = vinflate(counts, n256, z16);
            var z = vsrlv(x,y);
            return vcompact(z,n128,z8);
        }

        /// <summary>
        /// Computes z[i] := x[i] >> s[i] for i = 0..7
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vsrlv(Vector128<short> src, Vector128<short> counts)
        {
            var x = vinflate(src, n256, z32i);
            var y = v32u(vinflate(counts,n256,z32i));
            var z = ShiftRightLogicalVariable(x,y);
            return vcompact(z,n128,z16i);
        }

        /// <summary>
        /// Computes z[i] := x[i] >> s[i] for i = 0..7
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vsrlv(Vector128<ushort> src, Vector128<ushort> counts)
        {
            var x = vinflate(src, n256, z32);
            var y = vinflate(counts, n256, z32);
            var z = ShiftRightLogicalVariable(x,y);
            return vcompact(z, n128, z16);
        }

        /// <summary>
        ///  __m128i _mm_srlv_epi32 (__m128i a, __m128i count) VPSRLVD xmm, xmm, xmm/m128
        /// Computes z[i] := x[i] >> offsets[i] for i = 0...3
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="counts">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vsrlv(Vector128<int> x, Vector128<int> counts)
            => ShiftRightLogicalVariable(x, v32u(counts));

        /// <summary>
        /// __m128i _mm_srlv_epi32 (__m128i a, __m128i count) VPSRLVD xmm, xmm, xmm/m128
        /// Computes z[i] := x[i] >> offsets[i] for i = 0...3
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="counts">The offsets offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vsrlv(Vector128<uint> x, Vector128<uint> counts)
            => ShiftRightLogicalVariable(x, counts);

        /// <summary>
        /// __m128i _mm_srlv_epi64 (__m128i a, __m128i count) VPSRLVQ xmm, xmm, xmm/m128
        /// Computes z[i] := x[i] >> offsets[i] for i = 0,1
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="counts">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vsrlv(Vector128<long> x, Vector128<long> counts)
            => ShiftRightLogicalVariable(x, v64u(counts));

        /// <summary>
        /// __m128i _mm_srlv_epi64 (__m128i a, __m128i count) VPSRLVQ xmm, xmm, xmm/m128
        /// Computes z[i] := x[i] >> offsets[i] for i = 0,1
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="counts">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vsrlv(Vector128<ulong> x, Vector128<ulong> counts)
            => ShiftRightLogicalVariable(x, counts);       

        /// <summary>
        /// Computes z[i] := x[i] >> s[i] for i = 0..31
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vsrlv(Vector256<sbyte> src, Vector256<sbyte> counts)
        {
            (var x0, var x1) = vinflate(src, n512, z16i); 
            (var s0, var s1) = vinflate(counts, n512, z16i);
            return vcompact(vsrlv(x0,s0),vsrlv(x1,s1),n256,z8i);            
        }

        /// <summary>
        /// Computes z[i] := x[i] >> s[i] for i = 0..31
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vsrlv(Vector256<byte> src, Vector256<byte> counts)
        {
            (var x0, var x1) = vinflate(src, n512, z16); 
            (var s0, var s1) = vinflate(counts, n512, z16);
            return vcompact(vsrlv(x0,s0),vsrlv(x1,s1),n256,z8);            
        }

        /// <summary>
        /// Computes z[i] := x[i] >> s[i] for i = 0..15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vsrlv(Vector256<short> src, Vector256<short> counts)
        {
            (var x0, var x1) = vinflate(src, n512, z32i); 
            (var s0, var s1) = vinflate(counts, n512, z32i);
            return vcompact(vsrlv(x0,s0),vsrlv(x1,s1),n256,z16i);            
        }

        /// <summary>
        /// Computes z[i] := x[i] >> s[i] for i = 0..15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="counts">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vsrlv(Vector256<ushort> src, Vector256<ushort> counts)
        {
            (var x0, var x1) = vinflate(src, n512, z32); 
            (var s0, var s1) = vinflate(counts, n512, z32);
            return vcompact(vsrlv(x0,s0),vsrlv(x1,s1),n256,z16);            
        }

        /// <summary>
        /// __m256i _mm256_srlv_epi32 (__m256i a, __m256i count) VPSRLVD ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] >> offsets[i] for i = 0...7
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="counts">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vsrlv(Vector256<int> x, Vector256<int> counts)
            => ShiftRightLogicalVariable(x, v32u(counts));

        /// <summary>
        /// __m256i _mm256_srlv_epi32 (__m256i a, __m256i count) VPSRLVD ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] >> offsets[i] for i = 0...7
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="counts">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vsrlv(Vector256<uint> x, Vector256<uint> counts)
            => ShiftRightLogicalVariable(x, counts);

        /// <summary>
        /// __m256i _mm256_srlv_epi64 (__m256i a, __m256i count) VPSRLVQ ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] >> offsets[i] for i = 0...3
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="counts">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vsrlv(Vector256<long> x, Vector256<long> counts)
            => ShiftRightLogicalVariable(x, v64u(counts));

        /// <summary>
        ///  __m256i _mm256_srlv_epi64 (__m256i a, __m256i count) VPSRLVQ ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] >> offsets[i] for i = 0...3
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="counts">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vsrlv(Vector256<ulong> x, Vector256<ulong> counts)
            => ShiftRightLogicalVariable(x, counts);     
    }
}