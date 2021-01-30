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
    /// Captures an asm opcode together with an instruction signature
    /// </summary>
    public readonly struct AsmInstructionSpecExprLegacy : ITextual
    {
        public AsmOpCodeExprLegacy OpCode {get;}

        public AsmSigExpr Sig {get;}

        [MethodImpl(Inline)]
        public AsmInstructionSpecExprLegacy(in AsmOpCodeExprLegacy opcode, in AsmSigExpr pattern)
        {
            OpCode = opcode;
            Sig = pattern;
        }

        public bool Equals(AsmInstructionSpecExprLegacy src)
            => Sig.Equals(src.Sig) && OpCode.Equals(src.OpCode);

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(Sig, OpCode);

        public override string ToString()
            => Format();
    }
}