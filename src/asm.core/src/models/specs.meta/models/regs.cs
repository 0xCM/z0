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
        public readonly struct r8 : IOperand<r8>
        {
            public AsmOpClass Class => AsmOpClass.R;

            public AsmSizeKind Size => AsmSizeKind.@byte;

        }

        public readonly struct r16 : IOperand<r16>
        {
            public AsmOpClass Class => AsmOpClass.R;

            public AsmSizeKind Size => AsmSizeKind.word;
        }

        public readonly struct r32 : IOperand<r32>
        {
            public AsmOpClass Class => AsmOpClass.R;

            public AsmSizeKind Size => AsmSizeKind.dword;
        }

        public readonly struct r64 : IOperand<r64>
        {
            public AsmOpClass Class => AsmOpClass.R;

            public AsmSizeKind Size => AsmSizeKind.qword;
        }
    }
}