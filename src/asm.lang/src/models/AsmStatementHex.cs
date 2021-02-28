//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct AsmStatementHex
    {
        readonly Cell128 Data;

        [MethodImpl(Inline)]
        internal AsmStatementHex(Cell128 data)
        {
            Data = data;
        }

    }
}
