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
        [MethodImpl(Inline)]
        public static implicit operator Cell<T>(in Cell<T,uint> src)
            => new Cell<T>(src.Data, src.Row, src.Col);

        [MethodImpl(Inline)]
        public static implicit operator Cell<T>(in Cell<T,uint,uint> src)
            => new Cell<T>(src.Data, src.Row, src.Col);

        [MethodImpl(Inline)]
        public static implicit operator T(in Cell<T> src)
            => src.Data;

        public readonly T Data;

        public readonly uint Row;

        public readonly uint Col;

        [MethodImpl(Inline)]
        public Cell(T data, uint row, uint col)
        {
            Row = row;
            Col = col;
            Data = data;
        }        
    }
}