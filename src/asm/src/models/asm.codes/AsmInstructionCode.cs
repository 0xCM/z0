//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Pairs an instruction definition together with the corresponding source code representation
    /// </summary>
    public readonly struct AsmInstructionCode
    {
        public readonly PackedInstruction Instruction;

        public readonly AsmStatementCode SourceCode;

        public PackedInstruction Source
            => Instruction;

        public AsmStatementCode Target
            => SourceCode;

        [MethodImpl(Inline)]
        public AsmInstructionCode(in PackedInstruction detail, in AsmStatementCode asm)
        {
            Instruction = detail;
            SourceCode = asm;
        }

        public string Format()
            => Render.format(SourceCode, Instruction);

        [MethodImpl(Inline)]
        public static implicit operator AsmInstructionCode(Paired<PackedInstruction,AsmStatementCode> src)
            => new AsmInstructionCode(src.Left, src.Right);
    }
}