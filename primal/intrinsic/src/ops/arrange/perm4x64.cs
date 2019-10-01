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

        [MethodImpl(Inline)]
        internal static Vec256<ulong> perm4x64_ABCD(Vec256<ulong> src)
            => Permute4x64(src.ymm, (byte)Perm4.ABCD);             

        [MethodImpl(Inline)]
        internal static Vec256<ulong> perm4x64_ACBD(Vec256<ulong> src)
            => Permute4x64(src.ymm, (byte)Perm4.ACBD);             

        [MethodImpl(Inline)]
        internal static Vec256<ulong> perm4x64_ACDB(Vec256<ulong> src)
            => Permute4x64(src.ymm, (byte)Perm4.ACDB);             

        [MethodImpl(Inline)]
        internal static Vec256<ulong> perm4x64_ADBC(Vec256<ulong> src)
            => Permute4x64(src.ymm, (byte)Perm4.ADBC);             

        [MethodImpl(Inline)]
        internal static Vec256<ulong> perm4x64_ADCB(Vec256<ulong> src)
            => Permute4x64(src.ymm, (byte)Perm4.ADCB); 

        [MethodImpl(Inline)]
        internal static Vec256<ulong> perm4x64_BACD(Vec256<ulong> src)
            => Permute4x64(src.ymm, (byte)Perm4.BACD);             

        [MethodImpl(Inline)]
        internal static Vec256<ulong> perm4x64_BADC(Vec256<ulong> src)
            => Permute4x64(src.ymm, (byte)Perm4.BADC);             

        [MethodImpl(Inline)]
        internal static Vec256<ulong> perm4x64_BCAD(Vec256<ulong> src)
            => Permute4x64(src.ymm, (byte)Perm4.BCAD);             

        [MethodImpl(Inline)]
        internal static Vec256<ulong> perm4x64_BCDA(Vec256<ulong> src)
            => Permute4x64(src.ymm, (byte)Perm4.BCDA);             

        [MethodImpl(Inline)]
        internal static Vec256<ulong> perm4x64_BDCA(Vec256<ulong> src)
            => Permute4x64(src.ymm, (byte)Perm4.BDCA); 

        [MethodImpl(Inline)]
        internal static Vec256<ulong> perm4x64_BDAC(Vec256<ulong> src)
            => Permute4x64(src.ymm, (byte)Perm4.BDAC); 

    }

}