//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static zfunc;

    partial class dinx    
    {        

        [MethodImpl(Inline)]
        public static Vec256<long> vperm4x64(in Vec256<long> x, Perm4 spec)
            => Permute4x64(x.ymm, (byte)spec);

        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8)VPERMQ ymm, ymm/m256, imm8
        /// Permutes components in the source vector across lanes per the supplied specification
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The control byte</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vperm4x64(in Vec256<ulong> x, Perm4 spec)
            => Permute4x64(x.ymm, (byte)spec); 
    }

}