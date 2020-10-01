//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = TableRows;

    public ref struct RowAdapter<T>
        where T : struct
    {
        public readonly TableFieldIndex Fields;

        T Source;

        TableRow<T> Row;

        [MethodImpl(Inline)]
        public RowAdapter(TableFieldIndex fields)
        {
            Source = default;
            Fields = fields;
            Row = api.alloc<T>(fields.Count);
        }

        [MethodImpl(Inline)]
        public RowAdapter<T> Adapt(uint index, in T src)
        {
            Source = src;
            api.load(Fields, index, Source, ref Row);
            return this;
        }
    }
}