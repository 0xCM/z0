//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    

    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static Konst; 
    using static V0;

    partial class dvec    
    {        
        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8
        /// Permutes vector content across lanes at 64-bit granularity
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vperm4x64(Vector256<sbyte> x, [Imm] byte spec)
            => v8i(Permute4x64(v64i(x), spec)); 

        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8
        /// Permutes vector content across lanes at 64-bit granularity
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vperm4x64(Vector256<byte> x, [Imm] byte spec)
            => v8u(Permute4x64(v64u(x), spec));

        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8
        /// Permutes vector content across lanes at 64-bit granularity
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vperm4x64(Vector256<short> x, [Imm] byte spec)
            => v16i(Permute4x64(v64i(x), spec).AsInt16());

        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8
        /// Permutes vector content across lanes at 64-bit granularity
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vperm4x64(Vector256<ushort> x, [Imm] byte spec)
            => v16u(Permute4x64(v64u(x), spec));

        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8)VPERMQ ymm, ymm/m256, imm8
        /// Permutes vector content across lanes at 64-bit granularity
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vperm4x64(Vector256<int> x, [Imm] byte spec)
            => v32i(Permute4x64(v64i(x), spec)); 

        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8
        /// Permutes vector content across lanes at 64-bit granularity
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The control byte</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vperm4x64(Vector256<uint> x, [Imm] byte spec)
            => v32u(Permute4x64(v64u(x), (byte)spec));

        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8
        /// Permutes vector content across lanes at 64-bit granularity
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The control byte</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vperm4x64(Vector256<ulong> x, [Imm] byte spec)
            => Permute4x64(x, spec); 

        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8
        /// Permutes vector content across lanes at 64-bit granularity
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The control byte</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vperm4x64(Vector256<long> x, [Imm] byte spec)
            => Permute4x64(x, (byte)spec);
         
        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8
        /// Permutes vector content across lanes at 64-bit granularity
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vperm4x64(Vector256<sbyte> x, [Imm] Perm4L spec)
            => vperm4x64(x,(byte)spec);

        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8
        /// Permutes vector content across lanes at 64-bit granularity
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vperm4x64(Vector256<byte> x, [Imm] Perm4L spec)
             => vperm4x64(x,(byte)spec);

        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8
        /// Permutes vector content across lanes at 64-bit granularity
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vperm4x64(Vector256<short> x, [Imm] Perm4L spec)
            => vperm4x64(x,(byte)spec);

        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8
        /// Permutes vector content across lanes at 64-bit granularity
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vperm4x64(Vector256<ushort> x, [Imm] Perm4L spec)
            => vperm4x64(x,(byte)spec);

        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8)VPERMQ ymm, ymm/m256, imm8
        /// Permutes vector content across lanes at 64-bit granularity
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vperm4x64(Vector256<int> x, [Imm] Perm4L spec)
            => vperm4x64(x,(byte)spec);

        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8
        /// Permutes vector content across lanes at 64-bit granularity
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The control byte</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vperm4x64(Vector256<uint> x, [Imm] Perm4L spec)
            => vperm4x64(x,(byte)spec);

        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8
        /// Permutes vector content across lanes at 64-bit granularity
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The control byte</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vperm4x64(Vector256<ulong> x, [Imm] Perm4L spec)
            => vperm4x64(x,(byte)spec);

        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8) VPERMQ ymm, ymm/m256, imm8
        /// Permutes vector content across lanes at 64-bit granularity
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The control byte</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vperm4x64(Vector256<long> x, [Imm] Perm4L spec)
            => vperm4x64(x,(byte)spec);             
    }
}