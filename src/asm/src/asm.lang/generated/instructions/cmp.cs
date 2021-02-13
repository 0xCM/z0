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
        public readonly struct Cmp : IAsmInstruction<Cmp>
        {
            public AsmMnemonicCode Mnemonic => CMP;

            public static implicit operator AsmMnemonicCode(Cmp src) => src.Mnemonic;
        }

        [Op]
        public static Cmp cmp()
            => default;
    }
}