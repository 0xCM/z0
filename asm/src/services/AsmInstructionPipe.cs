//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.AsmSpecs;

    using static zfunc;

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