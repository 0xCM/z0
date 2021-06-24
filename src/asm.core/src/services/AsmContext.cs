//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public unsafe struct AsmContext
    {
        byte* PState;

        [MethodImpl(Inline)]
        internal AsmContext(byte* pState)
        {
            PState = pState;
        }
    }
}