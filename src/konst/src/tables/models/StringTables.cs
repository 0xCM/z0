//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Data;

    using static Konst;
    
    [ApiHost]
    public readonly struct StringTables
    {
        [MethodImpl(Inline), Op]
        public static StringTableRow row(string[] data)
            => new StringTableRow(data);

        [MethodImpl(Inline), Op]
        public static StringTable table(string name, TableHeader header, StringTableRow[] rows)
            => new StringTable(name, header,rows);
    }
}