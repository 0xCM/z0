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
        /// Clears the high 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> zeroupper<T>(Vector128<T> src)
            where T : unmanaged
                => dinx.vmovelo(v64u(src)).As<ulong,T>();

        /// <summary>
        /// Clears the high 128 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> zeroupper<T>(Vector256<T> src)
            where T : unmanaged
                => vinsert(vlo(src), default,0);

    }

}