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
        public readonly struct m8 : IOperand<m8>
        {
            public AsmOpClass Class => AsmOpClass.M;

            public AsmSizeKind Size => AsmSizeKind.@byte;

        }

        public readonly struct m16 : IOperand<m16>
        {
            public AsmOpClass Class => AsmOpClass.M;

            public AsmSizeKind Size => AsmSizeKind.word;
        }


        public readonly struct m32 : IOperand<m32>
        {
            public AsmOpClass Class => AsmOpClass.M;

            public AsmSizeKind Size => AsmSizeKind.dword;
        }

        public readonly struct m64 : IOperand<m64>
        {
            public AsmOpClass Class => AsmOpClass.M;

            public AsmSizeKind Size => AsmSizeKind.qword;
        }
    }
}