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

        protected static uint EntryCount;

        public StringTable Lookup
        {
            [MethodImpl(Inline)]
            get => new StringTable(Entries);
        }

        protected static void init(uint count)
        {
            EntryCount = count;
            Entries = core.alloc<string>(count);
        }
    }
}