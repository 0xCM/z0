//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ImageRecords
    {
        public readonly struct RowKeys : IIndex<RowKey>
        {
            readonly Index<RowKey> Data;

            public CliTableKind Table {get;}

            [MethodImpl(Inline)]
            public RowKeys(Index<RowKey> src, CliTableKind table = default)
            {
                Data = src;
                Table = table;
            }

            public ref RowKey First
            {
                [MethodImpl(Inline)]
                get => ref Data.First;
            }
            public ref RowKey this[int index]
            {
                [MethodImpl(Inline)]
                get => ref Data[index];
            }

            public ref RowKey this[uint index]
            {
                [MethodImpl(Inline)]
                get => ref Data[index];
            }
            public uint Count
            {
                [MethodImpl(Inline)]
                get => Data.Count;
            }

            public ReadOnlySpan<RowKey> View
            {
                [MethodImpl(Inline)]
                get => Data.View;
            }

            public RowKey[] Storage
            {
                [MethodImpl(Inline)]
                get => Data.Storage;
            }

            [MethodImpl(Inline)]
            public static implicit operator RowKeys(RowKey[] src)
                => new RowKeys(src);

            [MethodImpl(Inline)]
            public static implicit operator RowKeys((RowKey[] keys, CliTableKind table) src)
                => new RowKeys(src.keys, src.table);
        }
    }
}