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
    
    using static Core;
    using static VCore;

    partial class VectorExtensions
    {
       /// <summary>
        /// Returns the number of source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int Length<T>(this Vector128<T> src)
            where T : unmanaged            
                => vcount<T>(n128);

        /// <summary>
        /// Returns the number of source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int Length<T>(this Vector256<T> src)
            where T : unmanaged            
                => vcount<T>(n256);
    }
}