//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ItemList : IIndex<ListItem>
    {
        readonly Index<ListItem> Data;

        public Identifier ListName {get;}

        public Span<ListItem> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<ListItem> View
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ListItem[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public ItemList(Identifier name, ListItem[] src)
        {
            ListName = name;
            Data = src;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }
    }
}