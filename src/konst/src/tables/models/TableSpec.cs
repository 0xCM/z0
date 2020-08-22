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

    public readonly struct TableSpec : ITextual
    {
        public readonly ClrTypeName TableName;

        readonly TableSpan<FieldSpec> FieldSpecs;

        [MethodImpl(Inline)]
        public TableSpec(ClrTypeName name, FieldSpec[] cells)
        {
            TableName = name;
            FieldSpecs = cells;
        }

        public ReadOnlySpan<FieldSpec> Fields
        {
            [MethodImpl(Inline)]
            get => FieldSpecs.View;
        }

        public CellCount FieldCount
        {
            [MethodImpl(Inline)]
            get => FieldSpecs.Count;
        }

        public string Format()
        {
            var dst = text.build();
            dst.AppendLine(TableName);
            for(var i=0; i<FieldSpecs.Length; i++)
                dst.AppendLine(FieldSpecs[i].ToString());
            return dst.ToString();
        }
    }
}