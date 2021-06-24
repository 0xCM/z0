//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct AsmSyntax
    {
        readonly AsmMnemonicCode Mnemonic;

        [MethodImpl(Inline)]
        public AsmSyntax(AsmMnemonicCode mnemonic)
        {
            Mnemonic = mnemonic;
        }
    }
}