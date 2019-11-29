//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    

    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static zfunc;

    partial class dinx    
    {        
        /// <summary>
        /// __m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx)VPERMD ymm, ymm/m256, ymm
        /// Applies a cross-lane permutation over 8 32-bit segments in the source vector as indicated by the perm spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The perm spec</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vperm8x32(Vector256<byte> src, Vector256<uint> spec)
            => PermuteVar8x32(src.AsUInt32(), spec).AsByte();

        /// <summary>
        /// __m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx)VPERMD ymm, ymm/m256, ymm
        /// Applies a cross-lane permutation over 8 32-bit segments in the source vector as indicated by the perm spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The perm spec</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vperm8x32(Vector256<ushort> src, Vector256<uint> spec)
            => PermuteVar8x32(src.AsUInt32(), spec).AsUInt16();

        /// <summary>
        /// __m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx)VPERMD ymm, ymm/m256, ymm
        /// Applies a cross-lane permutation over 8 32-bit segments in the source vector as indicated by the perm spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The perm spec</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vperm8x32(Vector256<int> src, Vector256<uint> spec)
            => PermuteVar8x32(src, spec.AsInt32());

        /// <summary>
        /// __m256 _mm256_permutevar8x32_ps (__m256 a, __m256i idx)VPERMPS ymm, ymm/m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The perm spec</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vperm8x32(Vector256<float> src, Vector256<uint> spec)
            => PermuteVar8x32(src, spec.AsInt32());

        /// <summary>
        /// __m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx)VPERMD ymm, ymm/m256, ymm
        /// Applies a cross-lane permutation over 8 32-bit segments in the source vector as indicated by the perm spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The perm spec</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vperm8x32(Vector256<uint> src, Vector256<uint> spec)
            => PermuteVar8x32(src, spec);

        /// <summary>
        /// __m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx)VPERMD ymm, ymm/m256, ymm
        /// Applies a cross-lane permutation over 8 32-bit segments in the source vector as indicated by the perm spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The perm spec</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vperm8x32(Vector256<ulong> src, Vector256<uint> spec)
            => PermuteVar8x32(src.AsUInt32(), spec.AsUInt32()).AsUInt64();
    }
}