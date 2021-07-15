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
        public static TableCell cell(string content)
            => new TableCell(content);
    }
}