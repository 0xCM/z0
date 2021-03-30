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

    public readonly struct AsmMnemonicCase
    {
        public AsmMnemonicCode Mnemonic {get;}

        public Index<AsmOps> Operands {get;}

        [MethodImpl(Inline)]
        public AsmMnemonicCase(AsmMnemonicCode code, Index<AsmOps> ops)
        {
            Mnemonic = code;
            Operands = ops;
        }
    }
}