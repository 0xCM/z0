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
        public readonly struct Call : IAsmInstruction<Call>
        {
            public AsmMnemonicCode Mnemonic => CALL;

            public static implicit operator AsmMnemonicCode(Call src) => src.Mnemonic;
        }

        [Op]
        public static Call call()
            => default;
    }
}