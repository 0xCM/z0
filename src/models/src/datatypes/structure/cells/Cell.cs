//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Cell<T>
       where T : struct
     {
        public readonly uint Row;

        public readonly uint Col;

        public readonly T Data;

        [MethodImpl(Inline)]
        public Cell(uint row, uint col, T data)
        {
            Row = row;
            Col = col;
            Data = data;
        }        
    }
}