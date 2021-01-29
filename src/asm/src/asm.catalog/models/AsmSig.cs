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
        public AsmSigIdentifier Identifier {get;}

        public AsmMnemonicClass Mnemonic {get;}

        public Index<AsmSigOperand> Operands {get;}

        [MethodImpl(Inline)]
        public AsmSig(AsmSigIdentifier identifier, AsmMnemonicClass mnenonic, Index<AsmSigOperand> operands)
        {
            Identifier = identifier;
            Mnemonic = mnenonic;
            Operands = operands;
        }

        public static AsmSig Empty
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}