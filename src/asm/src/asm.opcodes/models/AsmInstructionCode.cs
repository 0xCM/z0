//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmDocParts;

    /// <summary>
    /// Pairs an instruction definition together with the corresponding source code representation
    /// </summary>
    public readonly struct AsmInstructionCode
    {
        public PackedInstruction Instruction {get;}

        public StatementSource SourceCode {get;}

        public PackedInstruction Source
            => Instruction;

        public StatementSource Target
            => SourceCode;

        [MethodImpl(Inline)]
        public AsmInstructionCode(in PackedInstruction detail, in StatementSource asm)
        {
            Instruction = detail;
            SourceCode = asm;
        }

        public string Format()
            => TextFormatter.format(SourceCode, Instruction);

        [MethodImpl(Inline)]
        public static implicit operator AsmInstructionCode(Paired<PackedInstruction,StatementSource> src)
            => new AsmInstructionCode(src.Left, src.Right);
    }
}