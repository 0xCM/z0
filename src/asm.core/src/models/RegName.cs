//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = AsmRegs;

    public readonly struct RegName
    {
        readonly uint Data;

        [MethodImpl(Inline)]
        internal RegName(uint data)
        {
            Data = data;
        }
    }
}