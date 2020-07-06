//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    
    using static Konst;

    partial struct V0
    {        
        /// <summary>
        /// Creates a 128-bit vector where each component is of unit value 
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vunits<T>(N128 w, T t = default)
            where T : unmanaged
                => V0p.vunits<T>(w);

        /// <summary>
        /// Creates a 256-bit vector where each component is of unit value 
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vunits<T>(N256 w, T t = default)
            where T : unmanaged
                => V0p.vunits<T>(w);
    }
}