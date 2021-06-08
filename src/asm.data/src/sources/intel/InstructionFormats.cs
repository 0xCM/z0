//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    partial struct IntelSdm
    {
        partial struct InstructionFormats
        {
            internal const string Reg1Name = "register1";

            internal const string Reg2Name = "register2";

            internal const string MemoryName = "memory";

            internal const string Reg1Op = "reg1";

            internal const string Reg2Op = "reg2";

            internal const string Imm = "immediate";

            internal const string Imm8Op = "imm8";

            internal const string Imm32Op = "imm32";

            internal const string RegOp = "reg";

            internal const string QWordRegOp = "qwordreg";

        }
    }
}