//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Ssse3;
        
    using static zfunc;

    partial class dinx    
    {        

        /// <summary>
        /// __m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128
        /// </summary>
        /// <param name="src">The content vector</param>
        /// <param name="spec">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vperm16x8(Vector128<byte> src, Perm16Spec spec)
            => Shuffle(src, spec.data);


        [MethodImpl(Inline)]
        public static Vector256<byte> vperm32x8(Vector256<byte> src, Perm32Spec spec)
            => vshuf32x8(src,spec.data);


    }

}