//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using api = StringHeaps;

    public sealed class StringHeap
    {
        Index<char> _Chars;

        Index<uint> _Offsets;

        [MethodImpl(Inline)]
        internal StringHeap(Index<char> src, Index<uint> offsets)
        {
            _Chars = src;
            _Offsets = offsets;
        }

        internal ReadOnlySpan<char> Chars
        {
            [MethodImpl(Inline)]
            get => _Chars.View;
        }

        internal ref readonly char First
        {
            [MethodImpl(Inline)]
            get => ref _Chars.First;
        }

        internal ReadOnlySpan<uint> Offsets
        {
            [MethodImpl(Inline)]
            get => _Offsets.View;
        }

        [MethodImpl(Inline)]
        internal ref readonly uint Offset(uint index)
            => ref _Offsets[index];

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> Entry(uint index)
            => api.entry(this, index);

        public uint EntryCount
        {
            [MethodImpl(Inline)]
            get => _Offsets.Count;
        }

        public uint CharCount
        {
            [MethodImpl(Inline)]
            get => _Chars.Count;
        }
    }
}