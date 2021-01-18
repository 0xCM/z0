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
        public static GridCell<T> cell<T>(uint row, uint col)
            where T : struct
                => new GridCell<T>(row, col);

        [MethodImpl(Inline)]
        public static GridCell<T,K> cell<T,K>(K row, K col)
            where T : struct
            where K : unmanaged
                => new GridCell<T,K>(row, col);

        [MethodImpl(Inline)]
        public static GridCell<T,M,N> cell<T,M,N>(M row, N col)
            where T : struct
            where M : unmanaged
            where N : unmanaged
                => new GridCell<T,M,N>(row, col);
    }
}