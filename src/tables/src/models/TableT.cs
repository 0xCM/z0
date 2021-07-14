//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public class Table<T> : Table
        where T : struct
    {
        Index<T> Data;

        public Table(T[] data)
            : base(TableId.identify<T>())
        {
            Data = data;
        }

        public Span<T> Rows
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public override uint RowCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }
    }
}