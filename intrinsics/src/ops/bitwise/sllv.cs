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

    partial class dinx
    {
        /// <summary>
        /// Computes z[i] := x[i] << s[i] for i = 0..15
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vsllv(Vector128<byte> src, Vector128<byte> shift)
        {
            vinflate(src, out Vector128<ushort> x0, out Vector128<ushort> x1);
            vinflate(shift, out Vector128<ushort> s0, out Vector128<ushort> s1);   
            return vcompact(vsllv(x0,s0),vsllv(x1,s1));            
        }

        /// <summary>
        /// Computes z[i] := x[i] << s[i] for i = 0..7
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vsllv(Vector128<ushort> src, Vector128<ushort> shift)
        {
            vinflate(src, out Vector128<uint> x0, out Vector128<uint> x1);
            vinflate(shift, out Vector128<uint> s0, out Vector128<uint> s1);   
            return vcompact(vsllv(x0,s0),vsllv(x1,s1));            
        }

        /// <summary>
        /// __m128i _mm_sllv_epi32 (__m128i a, __m128i count) VPSLLVD xmm, ymm, xmm/m128
        /// Computes z[i] := x[i] << s[i] for i = 0..3
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vsllv(Vector128<int> src, Vector128<uint> shift)
            => ShiftLeftLogicalVariable(src, shift);

        /// <summary>
        /// __m128i _mm_sllv_epi32 (__m128i a, __m128i count) VPSLLVD xmm, ymm, xmm/m128
        /// Computes z[i] := x[i] << s[i] for i = 0..3
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vsllv(Vector128<uint> src, Vector128<uint> shift)
            => ShiftLeftLogicalVariable(src, shift);

        /// <summary>
        ///  __m128i _mm_sllv_epi64 (__m128i a, __m128i count) VPSLLVQ xmm, ymm, xmm/m128
        /// Computes z[i] := x[i] << s[i] for i = 0,1
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vsllv(Vector128<long> src, Vector128<ulong> offsets)
            => ShiftLeftLogicalVariable(src, offsets);

        /// <summary>
        /// __m128i _mm_sllv_epi64 (__m128i a, __m128i count) VPSLLVQ xmm, ymm, xmm/m128
        /// Computes z[i] := x[i] << s[i] for i = 0,1
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsllv(Vector128<ulong> src, Vector128<ulong> offsets)
            => ShiftLeftLogicalVariable(src, offsets);           

        /// <summary>
        /// Computes z[i] := x[i] >> s[i] for i = 0..31
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vsllv(Vector256<byte> src, Vector256<byte> offsets)
        {
            vinflate(src, out Vector256<ushort> x0, out Vector256<ushort> x1);
            vinflate(offsets, out Vector256<ushort> s0, out Vector256<ushort> s1);   
            return vcompact(vsllv(x0,s0),vsllv(x1,s1));            
        }

        /// <summary>
        /// Computes z[i] := x[i] << s[i] for i = 0..7
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vsllv(Vector256<ushort> src, Vector256<ushort> offsets)
        {
            vinflate(src, out Vector256<uint> x0, out Vector256<uint> x1);
            vinflate(offsets, out Vector256<uint> s0, out Vector256<uint> s1);   
            return vcompact(vsllv(x0,s0),vsllv(x1,s1));            
        }

        /// <summary>
        /// __m256i _mm256_sllv_epi32 (__m256i a, __m256i count) VPSLLVD ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] << s[i] for i = 0...7
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vsllv(Vector256<int> src, Vector256<int> offsets)
            => ShiftLeftLogicalVariable(src, v32u(offsets));

        /// <summary>
        ///  __m256i _mm256_sllv_epi32 (__m256i a, __m256i count) VPSLLVD ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] << s[i] for i = 0...7
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vsllv(Vector256<uint> src, Vector256<uint> offsets)
            => ShiftLeftLogicalVariable(src, offsets);

        /// <summary>
        ///  __m256i _mm256_sllv_epi64 (__m256i a, __m256i count) VPSLLVQ ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] << s[i] for i = 0...3
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vsllv(Vector256<long> src, Vector256<long> offsets)
            => ShiftLeftLogicalVariable(src, v64u(offsets));

        /// <summary>
        /// __m256i _mm256_sllv_epi64 (__m256i a, __m256i count) VPSLLVQ ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] << s[i] for i = 0...3
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsllv(Vector256<ulong> src, Vector256<ulong> offsets)
            => ShiftLeftLogicalVariable(src, offsets);  

    }
}