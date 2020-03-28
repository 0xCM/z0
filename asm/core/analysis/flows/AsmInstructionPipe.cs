//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;

    public readonly struct AsmInstructionPipe : IAsmInstructionPipe
    {
        [MethodImpl(Inline)]
        public static IAsmInstructionPipe From(Func<AsmInstructionList,AsmInstructionList> f)
            => new AsmInstructionPipe(f);

        readonly Func<AsmInstructionList,AsmInstructionList> F;

        [MethodImpl(Inline)]
        AsmInstructionPipe(Func<AsmInstructionList,AsmInstructionList> f)
            => this.F = f;

        [MethodImpl(Inline)]
        public AsmInstructionList Flow(AsmInstructionList instruction)
            => F(instruction);
    }
}