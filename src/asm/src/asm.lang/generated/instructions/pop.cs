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
        public readonly struct Pop : IAsmInstruction<Pop>
        {
            public AsmMnemonicCode Mnemonic => POP;

            public static implicit operator AsmMnemonicCode(Pop src) => src.Mnemonic;
        }

        [Op]
        public static Pop pop()
            => default;

        public static AsmStatement<R> pop<R>(R r)
            where R : unmanaged, IRegOp
                => asm.statement(pop(), r);
    }
}