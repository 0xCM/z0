//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct TableCellSpec
    {        
        public readonly string Name;

        public readonly Type Type;
        
        [MethodImpl(Inline)]
        public static implicit operator TableCellSpec((string name, Type type) src)
            => new TableCellSpec(src.name, src.type);
        
        [MethodImpl(Inline)]
        public TableCellSpec(string name, Type type)
        {
            Name = name;
            Type = type;
        }

        [MethodImpl(Inline)]
        public override string ToString()
            => string.Format("{0,-30} | {1}", Name, Type);
    }

    public readonly struct TableSpec
    {
        public readonly string Name;
        
        public readonly TableCellSpec[] Cells;

        [MethodImpl(Inline)]
        public TableSpec(string name, TableCellSpec[] cells)
        {
            Name = name;
            Cells = cells;
        }

        public override string ToString() 
        {
            var dst = new StringBuilder();
            dst.AppendLine(Name);
            for(var i=0; i<Cells.Length; i++)        
                dst.AppendLine(Cells[i].ToString());
            return dst.ToString();
        }
    }

    public readonly struct TableTypeBuilder
    {
        readonly List<TableCellSpec> Cells;     

        public static TableTypeBuilder create(int capacity = 20)
            => new TableTypeBuilder(capacity);
        
        public TableTypeBuilder(int capacity)
        {
            Cells = new List<TableCellSpec>(capacity);
        }

        public TableTypeBuilder WithCell(PropertyInfo src)   
        {
            Cells.Add((src.Name, src.PropertyType));
            return this;
        }

        public TableTypeBuilder WithCell(string name, Type type)   
        {
            Cells.Add((name, type));
            return this;
        }

        public TableTypeBuilder WithCell(FieldInfo src)   
        {
            Cells.Add((src.Name, src.FieldType));
            return this;
        }

        public TableTypeBuilder WithCells(params PropertyInfo[] src)   
        {
            foreach(var item in src)
            Cells.Add((item.Name, item.PropertyType));
            return this;
        }

        public TableTypeBuilder WithCells(params FieldInfo[] src)   
        {
            foreach(var item in src)
            Cells.Add((item.Name, item.FieldType));
            return this;
        }

        public TableSpec Complete(string name)
            => new TableSpec(name, Cells.ToArray());    
    }
}