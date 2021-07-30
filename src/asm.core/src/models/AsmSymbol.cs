//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmSymbol
    {
        readonly TextBlock Data;

        [MethodImpl(Inline)]
        public AsmSymbol(string src)
        {
            Data = src;
        }
    }
}