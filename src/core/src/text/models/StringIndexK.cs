//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct StringIndex<K> : IIndex<K,string>
        where K : unmanaged
    {
        readonly Index<K,string> Data;

        [MethodImpl(Inline)]
        public StringIndex(string[] src)
        {
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

        public ref string this[K i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public Span<string> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<string> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public string[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public static implicit operator StringIndex(StringIndex<K> src)
            => new StringIndex(src.Storage);

        public static StringIndex<K> Empty
        {
            [MethodImpl(Inline)]
            get => new StringIndex<K>(array<string>());
        }
    }
}
