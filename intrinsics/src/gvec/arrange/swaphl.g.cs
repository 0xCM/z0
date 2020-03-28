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
    using static vgeneric;

    partial class gvec
    {
        /// <summary>
        /// Swaps hi/lo 64 bit segments of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector128<T> vswaphl<T>(Vector128<T> x)
            where T : unmanaged
                => generic<T>(dvec.vswaphl(v64u(x)));        

        /// <summary>
        /// Swaps hi/lo 128-bit lanes of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector256<T> vswaphl<T>(Vector256<T> x)
            where T : unmanaged
                => vperm2x128(x,x,Perm2x4.DA);
    }
}