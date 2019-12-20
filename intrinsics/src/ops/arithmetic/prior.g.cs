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
    
    using static zfunc;

    partial class ginx
    {

        /// <summary>
        /// Decrements each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vprior<T>(Vector128<T> src)
            where T : unmanaged
                => vsub<T>(src, CpuVector.units<T>(n128));

        /// <summary>
        /// Decrements each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vprior<T>(Vector256<T> src)
            where T : unmanaged
                => vsub<T>(src, CpuVector.units<T>(n256));
    }
}