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

    using api = StringTables;

    public readonly struct StringTable<T>
        where T : unmanaged
    {
        public Identifier Name {get;}

        public readonly string Content;

        readonly Index<T> _Offsets;

        [MethodImpl(Inline)]
        public StringTable(Identifier name, string src, Index<T> offsets)
        {
            Name = name;
            Content = src;
            _Offsets = offsets;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> Entry(T index)
            => api.entry(this, index);

        public ReadOnlySpan<char> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => api.entry(this, index);
        }

        public ReadOnlySpan<char> this[long index]
        {
            [MethodImpl(Inline)]
            get => api.entry(this, (ulong)index);
        }

        public uint EntryCount
        {
            [MethodImpl(Inline)]
            get => _Offsets.Count;
        }

        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => Content;
        }

        public ReadOnlySpan<T> Offsets
        {
            [MethodImpl(Inline)]
            get => _Offsets.View;
        }

        public T[] OffsetStorage
        {
            [MethodImpl(Inline)]
            get => _Offsets.Storage;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}