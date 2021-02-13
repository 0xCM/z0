//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmMnemonicCode;
    using static AsmMem;

    partial struct AsmInstructions
    {
        public readonly struct Jmp : IAsmInstruction<Jmp>
        {
            public AsmMnemonicCode Mnemonic => JMP;

            public static implicit operator AsmMnemonicCode(Jmp src) => src.Mnemonic;
        }

        [Op]
        public static Jmp jmp()
            => default;
    }
}