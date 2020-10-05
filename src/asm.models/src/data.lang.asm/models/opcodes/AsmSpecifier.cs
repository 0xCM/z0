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
    /// Captures an asm opcode together with an instruction string
    /// </summary>
    public readonly struct AsmSpecifier : ITextual
    {
        public readonly AsmInstructionPattern Instruction;

        public readonly AsmOpCodePattern OpCode;

        [MethodImpl(Inline)]
        public AsmSpecifier(string pattern, string opcode)
        {
            Instruction = pattern;
            OpCode = opcode;
        }

        [MethodImpl(Inline)]
        public AsmSpecifier(in AsmInstructionPattern pattern, in AsmOpCodePattern opcode)
        {
            Instruction = pattern;
            OpCode = opcode;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(Instruction, OpCode);

        public override string ToString()
            => Format();
    }
}