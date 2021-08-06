//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Tables
    {
        [MethodImpl(Inline), Op]
        public static Table table(string src, uint kind, TableColumn[] cols, TableRow[] rows)
            => new Table(src,kind, cols, rows);
    }
}