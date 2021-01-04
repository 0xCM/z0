//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Records;

    public readonly struct TableId<I,T> : ITableId<I,T>
        where T : struct, IRecord<T>
        where I : unmanaged
    {
        public I Index {get;}

        [MethodImpl(Inline)]
        public TableId(I index)
            => Index = index;

        public Name RecordType
            => typeof(T).Name;

        public Name Identifier
            => api.tableid(typeof(T)).Identifier;

        [MethodImpl(Inline)]
        public string Format()
            => Identifier.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator TableId(TableId<I,T> src)
            => api.tableid(typeof(T));

        [MethodImpl(Inline)]
        public static implicit operator TableId<T>(TableId<I,T> src)
            => default;
    }
}