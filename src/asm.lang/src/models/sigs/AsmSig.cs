//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmSig
    {
        public AsmMnemonicCode Mnemonic {get;}

        public Index<AsmSigOperand> Operands {get;}

        [MethodImpl(Inline)]
        public AsmSig(AsmMnemonicCode monic, Index<AsmSigOperand> operands)
        {
            Mnemonic = monic;
            Operands = operands;
        }
    }
}