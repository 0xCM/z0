//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct TableCellSpecs : ITextual
    {
        public readonly string TableName;

        readonly TableSpan<TableCellSpec> Storage;

        [MethodImpl(Inline)]
        public TableCellSpecs(string table, TableCellSpec[] cells)
        {
            TableName = table;
            Storage = cells;
        }

        public ReadOnlySpan<TableCellSpec> View
        {
            [MethodImpl(Inline)]
            get => Storage.View;
        }

        public Span<TableCellSpec> Edit
        {
            [MethodImpl(Inline)]
            get => Storage.Edit;
        }

        public CellCount Count
        {
            [MethodImpl(Inline)]
            get => Storage.Count;
        }

        public string Format()
        {
            var dst = text.build();
            dst.AppendLine(TableName);
            for(var i=0; i<Storage.Length; i++)
                dst.AppendLine(Storage[i].ToString());
            return dst.ToString();
        }
    }
}