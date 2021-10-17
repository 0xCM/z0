//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct BitRecords
    {
        public readonly struct RecordSchema
        {
            public text15 Scope {get;}

            /// <summary>
            /// Specifies record type name
            /// </summary>
            public text15 EntityName {get;}

            readonly Index<RecordField> _Fields;

            [MethodImpl(Inline)]
            public RecordSchema(text15 scope, text15 name, RecordField[] fields)
            {
                Scope = scope;
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