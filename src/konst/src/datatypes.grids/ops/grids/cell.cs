//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Grids
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static GridCell<T,byte> cell<T>(byte row, byte col)
            where T : struct
                => cell<T,byte,byte>(row,col);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static GridCell<T,uint,uint> cell<T>(uint row, uint col)
            where T : struct
                => cell<T,uint,uint>(row,col);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static GridCell<T,byte,uint> cell<T>(byte row, uint col)
            where T : struct
                => cell<T,byte,uint>(row,col);

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
