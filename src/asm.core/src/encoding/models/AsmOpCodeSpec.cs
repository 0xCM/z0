//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmOpCodeSpec
    {
        readonly uint Data;

        [MethodImpl(Inline)]
        internal AsmOpCodeSpec(uint data)
        {
            Data = data;
        }
    }
}