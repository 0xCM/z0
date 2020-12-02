//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct GridCalcs
    {
        /// <summary>
        /// Computes the minimum number of T-cells required to store N bits
        /// </summary>
        /// <param name="n">The bit count representative</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="N">The bit count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int minimum<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatCalc.lteqT(n,t) ? 1 : (int)NatCalc.divceilT(n,t);
    }
}