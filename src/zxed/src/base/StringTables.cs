//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct StringTables
    {
        [MethodImpl(Inline)]
        public static StringTableRow row(string[] data)
            => new StringTableRow(data);

        [MethodImpl(Inline)]
        public static TableHeaderCell header(uint index, string label)
            => new TableHeaderCell(index,label);

        [MethodImpl(Inline)]
        public static TableHeader header(TableHeaderCell[] data)
            => data;

        [MethodImpl(Inline)]
        public static StringTable table(string name, TableHeader header, StringTableRow[] rows)
            => new StringTable(name, header,rows);
    }
}