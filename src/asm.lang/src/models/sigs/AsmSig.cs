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

        public Index<AsmSigOp> Operands {get;}

        [MethodImpl(Inline)]
        public AsmSig(AsmMnemonicCode mnenonic, Index<AsmSigOp> operands)
        {
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