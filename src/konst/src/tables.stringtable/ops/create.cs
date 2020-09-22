//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct StringTables
    {
        [MethodImpl(Inline), Op]
        public static StringTable create(string name, TableHeader header, StringTableRow[] rows)
            => new StringTable(name, header,rows);

        [MethodImpl(Inline), Op]
        public static StringTable create(string name, HeaderCell[] cells, StringTableRow[] rows)
            => new StringTable(name, cells, rows);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static StringTable<T> create<T>(string name, TableHeader header, StringTableRow<T>[] rows)
            => new StringTable<T>(name, header, rows);
    }
}