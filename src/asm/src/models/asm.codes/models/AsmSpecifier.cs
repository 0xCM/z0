//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Captures an asm opcode together with an instruction string
    /// </summary>
    public readonly struct AsmSpecifier : ITextual
    {
        [MethodImpl(Inline)]
        public static AsmSpecifier create(in AsmInstructionPattern fx, in AsmOpCodePattern opcode)
            => new AsmSpecifier(fx, opcode);

        public AsmInstructionPattern Instruction {get;}

        public AsmOpCodePattern OpCode {get;}

        [MethodImpl(Inline)]
        public AsmSpecifier(in AsmInstructionPattern pattern, in AsmOpCodePattern opcode)
        {
            Instruction = pattern;
            OpCode = opcode;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(Instruction, OpCode);

        public override string ToString()
            => Format();
    }
}