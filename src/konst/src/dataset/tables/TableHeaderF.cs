//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    public readonly struct TableHeader<F>
        where F : unmanaged, Enum
    {
        readonly FieldInfo[] Fields;

        readonly F[] Values;

        [MethodImpl(Inline)]
        public TableHeader(FieldInfo[] fields, F[] values)
        {
            Fields = fields;
            Values = values;
        }

        public HeaderCell<F> this[byte index]
        {
            [MethodImpl(Inline)]
            get => Cell(index);
        }
        
        public int CellCount
        {
            [MethodImpl(Inline)]
            get => Fields.Length;
        }
        
        public string[] Names
        {
            [MethodImpl(Inline)]
            get => Fields.Map(f => f.Name);
        }
        
        [MethodImpl(Inline)]
        public string HeaderText(char delimiter)
            => text.join($" {delimiter} ", Names);

        [MethodImpl(Inline)]
        public HeaderCell<F> Cell(byte index)
            => new HeaderCell<F>(index, Fields[index], Value(index));

        [MethodImpl(Inline)]
        ref readonly F Value(byte index)
            => ref Values[index];
        
        [MethodImpl(Inline)]
        public ushort Width(byte index)
            => @as<F,ushort>(Value(index));
    }
}