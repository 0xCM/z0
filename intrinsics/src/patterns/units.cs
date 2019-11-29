//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Linq;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;
    
    partial class ginx
    {
        /// <summary>
        /// Returns a 128-bit vector where each component is assigned the value 1
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vpunits<T>(N128 n)
            where T : unmanaged
                => PatternData.uints<T>(n);

        /// <summary>
        /// Returns a 256-bit vector where each component is assigned the value 1
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vpunits<T>(N256 n)
            where T : unmanaged
                => PatternData.uints<T>(n);

    }

}