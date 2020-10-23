//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmStatementInfo
    {
        public Sequential Sequence {get;}

        public AsmMnemonic Mnemonic {get;}

        public AsmOpCodeExpression OpCode {get;}

        public AsmInstructionPattern Instruction {get;}

        public AsmOperatingMode Mode {get;}

        public CpuidExpression Cpuid {get;}
    }
}