//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct GenSpecs
    {
        public readonly struct RecordSpec : ITextual
        {
            public Name TypeName {get;}

            readonly TableSpan<FieldSpec> FieldSpecs;

            [MethodImpl(Inline)]
            public RecordSpec(Name name, FieldSpec[] cells)
            {
                TypeName = name;
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
                => RecordBuilder.format(this);

            public override string ToString()
                => Format();
        }
    }
}