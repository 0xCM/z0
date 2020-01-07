//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
    

    partial class ginx
    {        
        /// <summary>
        /// __m128i _mm_move_epi64 (__m128i a) MOVQ xmm, xmm
        /// Clears the high 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static Vector128<T> vzerohi<T>(Vector128<T> src)
            where T : unmanaged
                => MoveScalar(v64u(src)).As<ulong,T>();

        /// <summary>
        /// Clears the high 128 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static Vector256<T> vzerohi<T>(Vector256<T> src)
            where T : unmanaged
                => vinsert(vlo(src), default,0);

    }

}