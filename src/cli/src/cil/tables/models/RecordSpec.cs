//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct CilTables
    {
        public readonly struct RecordSpec : ITextual
        {
            public TypeName TableName {get;}

            readonly TableSpan<FieldSpec> FieldSpecs;

            [MethodImpl(Inline)]
            public RecordSpec(TypeName name, FieldSpec[] cells)
            {
                TableName = name;
                FieldSpecs = cells;
            }

            public ReadOnlySpan<FieldSpec> Fields
            {
                [MethodImpl(Inline)]
                get => FieldSpecs.View;
            }

            public Count FieldCount
            {
                [MethodImpl(Inline)]
                get => FieldSpecs.Count;
            }

            public string Format()
                => CilTables.format(this);

            public override string ToString()
                => Format();
        }
    }
}