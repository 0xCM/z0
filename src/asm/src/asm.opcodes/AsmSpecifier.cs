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
        public AsmSig Sig {get;}

        public AsmOpCode OpCode {get;}

        [MethodImpl(Inline)]
        public AsmSpecifier(in AsmSig pattern, in AsmOpCode opcode)
        {
            Sig = pattern;
            OpCode = opcode;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(Sig, OpCode);

        public override string ToString()
            => Format();
    }
}