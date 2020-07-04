//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Cells
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell<T,byte> define<T>(T data, byte row, byte col)
            where T : struct
                => define<T,byte,byte>(data,row,col);
        
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell<T,uint,uint> define<T>(T data, uint row, uint col)
            where T : struct
                => define<T,uint,uint>(data,row,col);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell<T,byte,uint> define<T>(T data, byte row, uint col)
            where T : struct
                => define<T,byte,uint>(data,row,col);

        [MethodImpl(Inline)]
        public static Cell<T,K> define<T,K>(T data, K row, K col)
            where T : struct
            where K : unmanaged
                => new Cell<T,K>(data, row, col);

        [MethodImpl(Inline)]
        public static Cell<T,M,N> define<T,M,N>(T data, M row, N col)
            where T : struct
            where M : unmanaged
            where N : unmanaged
                => new Cell<T,M,N>(data, row, col);        
    }
}