//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Captures the data required to specify an asm statement, e.g. 'mov rcx,rsi
    /// </summary>
    public readonly struct AsmStatement<T>
    {
        public Mnemonic Mnemonic {get;}

        public T Operand {get;}
    }
}