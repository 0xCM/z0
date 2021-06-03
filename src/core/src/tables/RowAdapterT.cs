//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct RowAdapter
    {
        public static void load<T>(in RecordField[] fields, uint index, in T src, ref DynamicRow<T> dst)
            where T : struct
        {
            dst = dst.UpdateSource(index, src);
            var tr = __makeref(edit(src));
            var count = fields.Length;
            var fv = @readonly(fields);
            var target = dst.Edit;
            for(var i=0u; i<count; i++)
                seek(target, i) = skip(fv, i).Definition.GetValueDirect(tr);
        }
    }

    /// <summary>
    /// Defines a row over a specified record type
    /// </summary>
    /// <typeparam name="T">The record type</typeparam>
    public struct RowAdapter<T>
        where T : struct, IRecord<T>
    {
        public RecordFields Fields {get;}

        uint Index;

        T Source;

        DynamicRow<T> Row;

        [MethodImpl(Inline)]
        public RowAdapter(RecordFields fields)
        {
            Source = default;
            Index = 0;
            Fields = fields;
            Row = new DynamicRow<T>(0, default(T), new dynamic[Fields.Length]);
        }

        [MethodImpl(Inline)]
        public RowAdapter<T> Adapt(in T src)
        {
            Source = src;
            RowAdapter.load(Fields.Storage, Index++, Source, ref Row);
            return this;
        }

        public DynamicRow<T> Adapted
        {
            [MethodImpl(Inline)]
            get => Row;
        }

        public Span<dynamic> Cells
        {
            [MethodImpl(Inline)]
            get => Row.Cells;
        }

        public uint ColumnCount
        {
            [MethodImpl(Inline)]
            get => Fields.Count;
        }
    }
}