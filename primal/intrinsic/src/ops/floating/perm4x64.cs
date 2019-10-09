//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static As;
    using static zfunc;    

    partial class dfp
    {

        /// <summary>
        /// __m256d _mm256_permute4x64_pd (__m256d a, const int imm8) VPERMPD ymm, ymm/m256, imm8
        /// Permutes components in the source vector across lanes as specified by the control byte
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control byte</param>
        [MethodImpl(Inline)]
        public static Vec256<double> vperm4x64(in Vec256<double> x, byte control)
            => Permute4x64(x,control); 


    }

}