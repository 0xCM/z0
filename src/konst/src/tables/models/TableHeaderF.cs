//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    using api = Z0.Table;

    public readonly struct TableHeader<F>
        where F : unmanaged, Enum
    {
        readonly LiteralFields<F> Fields;

        readonly char Delimiter;

        [MethodImpl(Inline)]
        public TableHeader(LiteralFields<F> fields, char delimiter = FieldDelimiter)
        {
            Fields = fields;
            Delimiter = delimiter;
        }

        public HeaderCell<F> this[byte index]
        {
            [MethodImpl(Inline)]
            get => Cell(index);
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => Fields.Count;
        }

        public string Format()
        {
            var formatter = TableFormat.formatter<F>(Fields, Delimiter);
            for(var i=0u; i<Fields.Count; i++)
            {
                if(i != 0)
                    formatter.Delimit(Fields[i], Fields.Name(i));
                else
                    formatter.Append(Fields[i], Fields.Name(i));
            }
            return formatter.Format();
        }

        public string HeaderText
            => Format();

        [MethodImpl(Inline)]
        public HeaderCell<F> Cell(byte index)
            => new HeaderCell<F>(index, Fields.Spec(index), Value(index));

        [MethodImpl(Inline)]
        ref readonly F Value(byte index)
            => ref Fields[index];

        [MethodImpl(Inline)]
        public ushort Width(byte index)
            => @as<F,ushort>(Value(index));
    }
}