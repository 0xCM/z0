//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a fully-specified instruction
    /// </summary>
    public readonly struct AsmInstruction
    {
        public AsmMnemonicCode Mnemonic {get;}

        public Index<AsmOp> Operands {get;}

        [MethodImpl(Inline)]
        public AsmInstruction(AsmMnemonicCode mnemonic, Index<AsmOp> operands)
        {
            Mnemonic = mnemonic;
            Operands = operands;
        }
    }
}