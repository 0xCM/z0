//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm.records
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Entity : IFieldProvider
    {
        public static Entity load(IFieldProvider src)
            => new Entity(src.EntityName, src.Fields.ToArray());

        readonly Index<RecordField> _Fields;

        public Identifier EntityName {get;}

        [MethodImpl(Inline)]
        public Entity(Identifier name, RecordField[] fields)
        {
            EntityName = name;
            _Fields = fields;
        }

        public ReadOnlySpan<RecordField> Fields
        {
            [MethodImpl(Inline)]
            get => _Fields.View;
        }
    }
}