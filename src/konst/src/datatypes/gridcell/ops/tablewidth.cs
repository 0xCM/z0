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
    
    partial struct GridCells
    {
        /// <summary>
        /// Computes the number of bits covered by a rectangular region and predicated on natural dimensions
        /// </summary>
        /// <param name="rows">The grid row count</param>
        /// <param name="cols">The grid col count</param>
        [MethodImpl(Inline)]
        public static int tablebits<M,N>(M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => (int)NatCalc.mul(m,n);         
    }
}