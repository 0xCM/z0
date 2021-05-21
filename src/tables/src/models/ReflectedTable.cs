//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public class ReflectedTable
    {
        public TableId Id {get;}

        public Index<RecordField> Fields {get;}

        [MethodImpl(Inline)]
        public ReflectedTable(TableId id, RecordFields fields)
        {
            Id = id;
            Fields = fields.Storage;
        }

        public Type Type
        {
            [MethodImpl(Inline)]
            get => Id.RecordType;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Id.IsEmpty || Fields.IsEmpty;
        }
    }
}