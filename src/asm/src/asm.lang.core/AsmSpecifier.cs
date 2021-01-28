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
        public AsmOpCode OpCode {get;}

        public AsmSig Sig {get;}

        [MethodImpl(Inline)]
        public AsmSpecifier(in AsmOpCode opcode, in AsmSig pattern)
        {
            OpCode = opcode;
            Sig = pattern;
        }

        public bool Equals(AsmSpecifier src)
            => Sig.Equals(src.Sig) && OpCode.Equals(src.OpCode);

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(Sig, OpCode);

        public override string ToString()
            => Format();
    }
}