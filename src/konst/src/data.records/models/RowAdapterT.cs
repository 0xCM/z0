//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = Records;

    public struct RowAdapter<T>
        where T : struct
    {
        public readonly RecordFields Fields;

        uint Index;

        T Source;

        DynamicRow<T> Row;

        [MethodImpl(Inline)]
        public RowAdapter(in RecordFields fields, uint index = 0)
        {
            Source = default;
            Index = index;
            Fields = fields;
            Row = api.row<T>(fields.Count);
        }

        [MethodImpl(Inline)]
        public RowAdapter<T> Adapt(in T src)
        {
            Source = src;
            api.load(Fields, Index++, Source, ref Row);
            return this;
        }

        public DynamicRow<T> Adapted
        {
            [MethodImpl(Inline)]
            get => Row;
        }
    }
}