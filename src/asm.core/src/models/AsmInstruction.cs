//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct AsmInstruction
    {
        readonly Cell256 Data;

        [MethodImpl(Inline)]
        internal AsmInstruction(Cell256 data)
        {
            Data = data;
        }
    }
}