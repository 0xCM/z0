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

    partial struct StringTables
    {
        public static StringTableSpec specify(Identifier ns, Identifier table, ListItem<string>[] entries)
            => new StringTableSpec(ns, table, entries);

        public static StringTableSpec specify(Identifier ns, StringTable src)
        {
            var count = src.EntryCount;
            var buffer = alloc<ListItem<string>>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = (i, text.format(src[i]));
            return specify(ns, src.Name, buffer);
        }
    }
}