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

    using M = AsmMnemonicCode;

    public readonly partial struct AsmInstructions
    {
        public readonly struct Cmp : IAsmInstruction<Cmp>
        {
            public M Mnemonic => CMP;
        }

        public readonly struct Jmp : IAsmInstruction<Jmp>
        {
            public M Mnemonic => JMP;
        }

        public static Jmp jmp()
            => default;

        public static Jmp cmp()
            => default;
    }
}