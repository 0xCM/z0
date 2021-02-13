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
        public readonly struct Lea : IAsmInstruction<Lea>
        {
            public AsmMnemonicCode Mnemonic => LEA;

            public static implicit operator AsmMnemonicCode(Lea src) => src.Mnemonic;
        }

        [Op]
        public static Lea lea()
            => default;
    }
}