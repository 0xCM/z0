//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public abstract class StringTable<T>
        where T : StringTable<T>, new()
    {
        public static T create() => new T();

        protected static Index<string> Entries;

        protected static MemoryAddress Location
            => core.address(Entries);

        public StringTable Lookup
        {
            [MethodImpl(Inline)]
            get => new StringTable(Entries);
        }

    }

    public readonly struct StringTable
    {
        readonly Index<string> Entries;

        [MethodImpl(Inline)]
        public StringTable(Index<string> entries)
        {
            Entries = entries;
        }


        public ReadOnlySpan<string> View
        {
            [MethodImpl(Inline)]
            get => Entries.View;
        }

        public uint EntryCount
        {
            [MethodImpl(Inline)]
            get => Entries.Count;
        }

        public ref readonly string this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Entries[index];
        }
    }
}