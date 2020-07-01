//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly partial struct DataCells
    {
        [MethodImpl(Inline)]
        public static Cell<T> define<T>(uint row, uint col, T data)
            where T : struct
                => new Cell<T>(row,col,data);
    }       
}