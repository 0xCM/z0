//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    
    partial class ginx
    {                        
        /// <summary>
        /// Creates a 256-bit vector from two 128-bit vectors    
        /// This mimics the _mm256_set_m128i intrinsic which does not appear to be available
        /// </summary>
        /// <param name="lo">The lo part</param>
        /// <param name="hi">The hi part</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> vset<T>(in Vec128<T> lo, in Vec128<T> hi)
            where T : unmanaged
                => insert(hi, insert(lo, default,0), 1);        
    }
}