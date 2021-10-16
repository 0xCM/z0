//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ItemList<T> : IIndex<ListItem<T>>
    {
        readonly Index<ListItem<T>> Data;

        public Identifier ListName {get;}

        public Span<ListItem<T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<ListItem<T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ListItem<T>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public ItemList(Identifier name, ListItem<T>[] src)
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