//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AsmInstructionPipe : IInstructionPipe
    {
        [MethodImpl(Inline)]
        public static IInstructionPipe From(Func<AsmInstructionList,AsmInstructionList> f)
            => new AsmInstructionPipe(f);

        readonly Func<AsmInstructionList,AsmInstructionList> F;

        [MethodImpl(Inline)]
        AsmInstructionPipe(Func<AsmInstructionList,AsmInstructionList> f)
            => this.F = f;

        [MethodImpl(Inline)]
        public AsmInstructionList Flow(in AsmInstructionList instruction)
            => F(instruction);
    }
}