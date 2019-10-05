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
        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8)VPERMQ ymm, ymm/m256, imm8
        /// Permutes components in the source vector across lanes as specified by the control byte
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control byte</param>
        [MethodImpl(Inline)]
        public static Vec256<long> perm4x64(in Vec256<long> value, byte control)
            => Permute4x64(value.ymm, control);

        [MethodImpl(Inline)]
        public static Vec256<long> perm4x64(in Vec256<long> value, Perm4 control)
            => Permute4x64(value.ymm, (byte)control);

        /// <summary>
        /// __m256i _mm256_permute4x64_epi64 (__m256i a, const int imm8)VPERMQ ymm, ymm/m256, imm8
        /// Permutes components in the source vector across lanes as specified by the control byte
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The control byte</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> perm4x64(in Vec256<ulong> value, byte control)
            => Permute4x64(value.ymm, control); 

        [MethodImpl(Inline)]
        public static Vec256<ulong> perm4x64(in Vec256<ulong> value, Perm4 control)
            => Permute4x64(value.ymm, (byte)control); 
    }

}