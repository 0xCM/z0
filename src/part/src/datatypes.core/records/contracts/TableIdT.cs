//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct TableId<T> : ITableId<T>
        where T : struct, IRecord<T>
    {
        public TableId Value {get;}

        [MethodImpl(Inline)]
        public TableId(TableId src)
            => Value = src;

        public Name RecordType
            => Value.RecordType;

        public Name Identifier
            => Value.Identifier;

        [MethodImpl(Inline)]
        public string Format()
            => Identifier.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator TableId(TableId<T> src)
            => src.Value;
    }
}