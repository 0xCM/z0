//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct AsmStatementSyntax
    {
        public readonly AsmMnemonic Mnemonic;

        public readonly AsmOperandSyntax[] Operands;
    }
}
