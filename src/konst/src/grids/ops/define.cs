//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct GridCells
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static GridCell<T,byte> define<T>(T data, byte row, byte col)
            where T : struct
                => define<T,byte,byte>(data,row,col);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static GridCell<T,uint,uint> define<T>(T data, uint row, uint col)
            where T : struct
                => define<T,uint,uint>(data,row,col);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static GridCell<T,byte,uint> define<T>(T data, byte row, uint col)
            where T : struct
                => define<T,byte,uint>(data,row,col);

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