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

    public readonly struct TableHeader<F>
        where F : unmanaged
    {
        readonly LiteralFieldValues<F> Fields;

        readonly char Delimiter;

        [MethodImpl(Inline)]
        public TableHeader(LiteralFieldValues<F> fields, char delimiter = FieldDelimiter)
        {
            Fields = fields;
            Delimiter = delimiter;
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => Fields.Count;
        }

        public string Format()
        {
            var formatter = Table.formatter<F>(Fields, Delimiter);
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
        ref readonly F Value(byte index)
            => ref Fields[index];

        [MethodImpl(Inline)]
        public ushort Width(byte index)
            => @as<F,ushort>(Value(index));
    }
}