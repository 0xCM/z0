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
    
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static As;
    using static zfunc;
 
    partial class Bits
    {    
        [MethodImpl(Inline)]
        public static Vec128<sbyte> vpackss(in Vec128<short> lhs, in Vec128<short> rhs)
            => PackSignedSaturate(lhs,rhs);

        /// <summary>
        ///  __m128i _mm_packus_epi16 (__m128i a, __m128i b)PACKUSWB xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vpackus(in Vec128<short> lhs, in Vec128<short> rhs)
            => PackUnsignedSaturate(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> vpackss(in Vec128<int> lhs, in Vec128<int> rhs)
            => PackSignedSaturate(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_packs_epi16 (__m256i a, __m256i b)VPACKSSWB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vpackss(in Vec256<short> lhs, in Vec256<short> rhs)
            => PackSignedSaturate(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_packs_epi32 (__m256i a, __m256i b)VPACKSSDW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec256<short> vpackss(in Vec256<int> lhs, in Vec256<int> rhs)
            => PackSignedSaturate(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_packus_epi32 (__m256i a, __m256i b)VPACKUSDW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vpackus(in Vec256<int> lhs, in Vec256<int> rhs)
            => PackUnsignedSaturate(lhs,rhs);
    }

}