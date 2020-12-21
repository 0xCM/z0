//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct GridCalcs
    {

        [MethodImpl(Inline)]
        public static GridCell<T,K> define<T,K>(T data, K row, K col)
            where T : struct
            where K : unmanaged
                => new GridCell<T,K>(data, row, col);

        [MethodImpl(Inline)]
        public static GridCell<T,M,N> define<T,M,N>(T data, M row, N col)
            where T : struct
            where M : unmanaged
            where N : unmanaged
                => new GridCell<T,M,N>(data, row, col);
    }
}