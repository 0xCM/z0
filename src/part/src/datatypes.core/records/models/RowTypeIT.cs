//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RowType<I,T> : IRowType<I,T>
        where T : struct, IRecord<T>
        where I : unmanaged
    {
        public TableId<I,T> Table {get;}

        public I TableIndex
        {
            [MethodImpl(Inline)]
            get => Table.Index;
        }


        [MethodImpl(Inline)]
        public RowType(TableId<I,T> id)
            => Table = id;

        public override string ToString()
            => Format();
        public string Format()
            => Table.Format();

        [MethodImpl(Inline)]
        public static implicit operator RowType<I,T>(TableId<I,T> src)
            => new RowType<I,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator RowType(RowType<I,T> src)
            => new RowType(src.Table);

        [MethodImpl(Inline)]
        public static implicit operator TableId<T>(RowType<I,T> src)
            => src.Table;

    }
}