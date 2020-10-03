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

    partial struct Buffers
    {
        /// <summary>
        /// Allocates a page
        /// </summary>
        /// <param name="n">A cell count representative</param>
        /// <param name="w">A cell width representative</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="N">The cell count type</typeparam>
        /// <typeparam name="W">The cell width type</typeparam>
        /// <typeparam name="T">The cell data type</typeparam>
        [MethodImpl(Inline)]
        public static MemoryPage<N,W,T> page<N,W,T>(N n = default, W w = default, T t = default)
            where T : unmanaged
            where W : unmanaged, ITypeWidth
            where N : unmanaged, ITypeNat
                => new MemoryPage<N,W,T>(sys.alloc<T>(n.NatValue));
    }
}