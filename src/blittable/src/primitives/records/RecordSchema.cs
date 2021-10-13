//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct BitFlow
    {
        public readonly struct RecordSchema
        {
            /// <summary>
            /// Specifies record type name
            /// </summary>
            public Label EntityName {get;}

            readonly Index<RecordField> _Fields;

            [MethodImpl(Inline)]
            public RecordSchema(Label name, RecordField[] fields)
            {
                EntityName = name;
                _Fields = fields;
            }

            public Span<RecordField> Fields
            {
                [MethodImpl(Inline)]
                get => _Fields.Edit;
            }

            public uint FieldCount
            {
                [MethodImpl(Inline)]
                get => _Fields.Count;
            }

            public ref RecordField this[uint i]
            {
                [MethodImpl(Inline)]
                get => ref _Fields[i];
            }

            public ref RecordField this[int i]
            {
                [MethodImpl(Inline)]
                get => ref _Fields[i];
            }

        }
    }
}