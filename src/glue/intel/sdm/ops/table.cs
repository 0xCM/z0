//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    partial struct IntelSdm
    {
        [MethodImpl(Inline), Op]
        public static Table table(TableHeader header, TableRow[] rows)
            => new Table(header,rows);
    }
}