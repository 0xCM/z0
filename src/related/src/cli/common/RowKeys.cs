//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Images
    {
        public readonly struct RowKeys : IIndex<RowKey>
        {
            readonly Index<RowKey> Data;

            [MethodImpl(Inline)]
            public RowKeys(Index<RowKey> src)
            {
                Data = src;
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

            public static implicit operator RowKeys(RowKey[] src)
                => new RowKeys(src);
        }
    }
}