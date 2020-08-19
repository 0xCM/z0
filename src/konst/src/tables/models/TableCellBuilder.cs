//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiDataType]
    public ref struct TableCellBuilder
    {
        readonly Span<TableCellSpec> Cells;

        uint Index;

        [MethodImpl(Inline)]
        public TableCellBuilder(uint capacity)
        {
            Index = 0;
            Cells = span<TableCellSpec>(capacity);
        }

        [MethodImpl(Inline)]
        public TableCellBuilder WithCell(PropertyInfo src)
        {
            seek(Cells, Index++) = (src.Name, src.PropertyType);
            return this;
        }

        [MethodImpl(Inline)]
        public TableCellBuilder WithCell(string name, Type type)
        {
            seek(Cells, Index++) = (name, type);
            return this;
        }

        [MethodImpl(Inline)]
        public TableCellBuilder WithCell(FieldInfo src)
        {
            seek(Cells, Index++) = (src.Name, src.FieldType);
            return this;
        }

        [MethodImpl(Inline)]
        public TableCellBuilder WithCells(params PropertyInfo[] src)
        {
            foreach(var item in src)
            seek(Cells, Index++) = (item.Name, item.PropertyType);
            return this;
        }

        [MethodImpl(Inline)]
        public TableCellBuilder WithCells(params FieldInfo[] src)
        {
            foreach(var item in src)
            seek(Cells, Index++) = (item.Name, item.FieldType);
            return this;
        }

        [MethodImpl(Inline)]
        public TableCellSpecs Complete(string name)
        {
            var cells = Cells.Slice(0,(int)Index).ToArray();
            Cells.Clear();
            return new TableCellSpecs(name, cells);
        }
    }
}