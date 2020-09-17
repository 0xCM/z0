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

    /// <summary>
    /// Pairs an instruction definition together with the corresponding source code representation
    /// </summary>
    public readonly struct AsmInstructionCode : IDataFlow<PackedInstruction,AsmStatementCode>
    {
        public readonly PackedInstruction Instruction;

        public readonly AsmStatementCode SourceCode;

        [MethodImpl(Inline)]
        public AsmInstructionCode(in PackedInstruction detail, in AsmStatementCode asm)
        {
            Instruction = detail;
            SourceCode = asm;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmInstructionCode(Paired<PackedInstruction,AsmStatementCode> src)
            => new AsmInstructionCode(src.Left, src.Right);

        public string Format()
            => Render.format(SourceCode, Instruction);

        PackedInstruction IArrow<PackedInstruction, AsmStatementCode>.Source
            => Instruction;

        AsmStatementCode IArrow<PackedInstruction, AsmStatementCode>.Target
            => SourceCode;
    }
}