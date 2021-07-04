//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct IntelSdm
    {
        [MethodImpl(Inline), Op]
        public static TableCell cell(TableKind table, ColumnKind colkind, ushort rowidx, ushort colidx, string content)
            => new TableCell(table, colkind, rowidx, colidx, content);
    }
}