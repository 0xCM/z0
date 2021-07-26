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
        public static Table table(uint kind, TableColumn[] cols, TableRow[] rows)
            => new Table(kind, cols, rows);
    }
}