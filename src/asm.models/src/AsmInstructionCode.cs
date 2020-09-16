//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct AsmInstructionCode : ITextual
    {
        public readonly InstructionDetail Instruction;

        public readonly AsmStatementCode SourceCode;

        [MethodImpl(Inline)]
        public AsmInstructionCode(in InstructionDetail fx, in AsmStatementCode asm)
        {
            Instruction = fx;
            SourceCode = asm;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmInstructionCode(Paired<InstructionDetail,AsmStatementCode> src)
            => new AsmInstructionCode(src.Left, src.Right);

        public string Format()
            => SourceCode.Format();
    }
}