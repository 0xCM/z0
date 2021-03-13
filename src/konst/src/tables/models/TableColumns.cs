//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TableColumns : IIndex<TableColumn>
    {
        readonly Index<TableColumn> Data;

        [MethodImpl(Inline)]
        public TableColumns(TableColumn[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref TableColumn this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public TableColumn[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public ReadOnlySpan<TableColumn> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        [MethodImpl(Inline)]
        public static implicit operator TableColumns(TableColumn[] src)
            => new TableColumns(src);

        [MethodImpl(Inline)]
        public static implicit operator TableColumn[](TableColumns src)
           => src.Storage;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<TableColumn>(TableColumns src)
            => src.View;
    }
}