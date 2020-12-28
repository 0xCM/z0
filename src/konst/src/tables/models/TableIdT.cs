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
        public Name RecordType
            => typeof(T).Name;

        public Name Identifier
            => Records.tableid<T>().Identifier;

        [MethodImpl(Inline)]
        public string Format()
            => Identifier.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator TableId(TableId<T> src)
            => Records.tableid<T>();
    }
}