//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct MnemonicIndex
    {
        public static MnemonicIndex alloc(MemoryAddress @base, uint count)
            => new MnemonicIndex(@base, core.alloc<MnemonicIndexEntry>(count));

        [MethodImpl(Inline)]
        public static MnemonicIndex define(MemoryAddress @base, MnemonicIndexEntry[] entries)
            => new MnemonicIndex(@base, entries);

        public MemoryAddress BaseAddress {get;}

        readonly Index<MnemonicIndexEntry> Entries;

        [MethodImpl(Inline)]
        public MnemonicIndex(MemoryAddress @base, MnemonicIndexEntry[] entries)
        {
            BaseAddress = @base;
            Entries = entries;
        }

        public Span<MnemonicIndexEntry> Edit
        {
            [MethodImpl(Inline)]
            get => Entries.Edit;
        }

        public ReadOnlySpan<MnemonicIndexEntry> View
        {
            [MethodImpl(Inline)]
            get => Entries.View;
        }
    }
}