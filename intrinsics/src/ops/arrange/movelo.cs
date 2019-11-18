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
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;    
    
    using static zfunc;

    partial class dinx    
    {                
        /// <summary>
        /// __m128i _mm_move_epi64 (__m128i a) MOVQ xmm, xmm
        /// Extracts the lower 64 bits from the source vector to create a scalar vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vmovelo(Vector128<long> xmm)
            => MoveScalar(xmm);

        /// <summary>
        /// __m128i _mm_move_epi64 (__m128i a) MOVQ xmm, xmm
        /// Extracts the lower 64 bits from the source vector to create a scalar vector
        /// </summary>
        /// <param name="xmm">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vmovelo(Vector128<ulong> xmm)
            => MoveScalar(xmm);
    }
}