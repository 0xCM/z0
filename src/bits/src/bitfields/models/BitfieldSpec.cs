//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct BitfieldSpec
    {
        readonly Index<BitfieldSpecEntry> _Entries;

        [MethodImpl(Inline)]
        public BitfieldSpec(Index<BitfieldSpecEntry> src)
        {
            _Entries = src;
        }

        public utf8 BitfieldName
        {
            [MethodImpl(Inline)]
            get => IsEmpty ? utf8.Empty : _Entries.First.Bitfield;
        }

        public ReadOnlySpan<BitfieldSpecEntry> Entries
        {
            [MethodImpl(Inline)]
            get => _Entries.View;
        }

        [MethodImpl(Inline)]
        public ref readonly byte SegOffset(byte index)
            => ref _Entries[index].Offset;

        [MethodImpl(Inline)]
        public ref readonly byte SegWidth(byte index)
            => ref _Entries[index].Width;

        public uint SegCount
        {
            [MethodImpl(Inline)]
            get => _Entries.Count;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => _Entries.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => _Entries.IsNonEmpty;
        }

        public static BitfieldSpec Empty
        {
            [MethodImpl(Inline)]
            get => new BitfieldSpec(sys.empty<BitfieldSpecEntry>());
        }
    }
}