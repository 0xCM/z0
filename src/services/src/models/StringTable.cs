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

    public readonly struct StringTable
    {
        public Identifier Name {get;}

        public readonly string Content;

        readonly Index<uint> _Offsets;

        [MethodImpl(Inline)]
        public StringTable(Identifier name, string src, Index<uint> offsets)
        {
            Name = name;
            Content = src;
            _Offsets = offsets;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> Entry(uint index)
            => api.chars(this, index);

        public ReadOnlySpan<char> this[uint index]
        {
            [MethodImpl(Inline)]
            get => api.chars(this, index);
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

        public ReadOnlySpan<uint> Offsets
        {
            [MethodImpl(Inline)]
            get => _Offsets.View;
        }

        public uint[] OffsetStorage
        {
            [MethodImpl(Inline)]
            get => _Offsets.Storage;
        }

        public string Format()
            => api.format(this);

        public string Format(uint margin)
            => api.format(this, margin);

        public override string ToString()
            => Format();
    }
}