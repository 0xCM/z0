//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    partial class AsmMetaSpecs
    {
        public readonly struct imm8 : IOperand<imm8>
        {
            public AsmOpClass Class => AsmOpClass.Imm;

            public AsmSizeKind Size => AsmSizeKind.@byte;
        }

        public readonly struct imm16 : IOperand<imm16>
        {
            public AsmOpClass Class => AsmOpClass.Imm;

            public AsmSizeKind Size => AsmSizeKind.word;
        }

        public readonly struct imm32 : IOperand<imm32>
        {
            public AsmOpClass Class => AsmOpClass.Imm;

            public AsmSizeKind Size => AsmSizeKind.dword;
        }

        public readonly struct imm64 : IOperand<imm64>
        {
            public AsmOpClass Class => AsmOpClass.Imm;

            public AsmSizeKind Size => AsmSizeKind.qword;
        }
    }
}