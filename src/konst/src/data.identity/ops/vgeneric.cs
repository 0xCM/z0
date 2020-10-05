//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct ApiIdentify
    {
        /// <summary>
        /// Produces an identifier for a kinded generic vectorized operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector operand width</param>
        /// <typeparam name="W">The vector operand width</typeparam>
        /// <typeparam name="T">The vector cell type</typeparam>
        public static OpIdentity vgeneric<W,T>(ApiOpId k, W w = default, T t = default)
            where T : unmanaged
            where W : unmanaged, ITypeWidth
                => ApiIdentify.build(vname(k), w.TypeWidth, NumericKinds.kind<T>(), true);
    }
}