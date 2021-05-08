//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct Table<T> : ITable<T>
        where T : struct, IRecord<T>
    {
        readonly Index<T> Data;

        [MethodImpl(Inline)]
        public Table(T[] rows)
        {
            Data = rows;
        }

        public Span<T> Rows
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint RowCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }
    }
}