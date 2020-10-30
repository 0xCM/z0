//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct GridCell<T>
       where T : struct
     {
        public readonly T Data;

        public readonly uint Row;

        public readonly uint Col;

        [MethodImpl(Inline)]
        public GridCell(T data, uint row, uint col)
        {
            Row = row;
            Col = col;
            Data = data;
        }

        [MethodImpl(Inline)]
        public static implicit operator GridCell<T>(in GridCell<T,uint> src)
            => new GridCell<T>(src.Data, src.Row, src.Col);

        [MethodImpl(Inline)]
        public static implicit operator GridCell<T>(in GridCell<T,uint,uint> src)
            => new GridCell<T>(src.Data, src.Row, src.Col);

        [MethodImpl(Inline)]
        public static implicit operator T(in GridCell<T> src)
            => src.Data;
    }
}