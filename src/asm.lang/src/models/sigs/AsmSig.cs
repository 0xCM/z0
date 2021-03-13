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

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Mnemonic == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Mnemonic != 0;
        }

        public static AsmSig Empty
        {
            [MethodImpl(Inline)]
            get => new AsmSig(0, sys.empty<AsmSigOperand>());
        }
    }
}