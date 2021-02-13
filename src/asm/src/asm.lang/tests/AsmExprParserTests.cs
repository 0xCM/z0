//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct AsmExprTestCase
    {

    }


    [ApiHost]
    public sealed partial class AsmExprParserTests : WfService<AsmExprParserTests,AsmExprParserTests>
    {

        public void Run()
        {

        }

        readonly struct SigExpressionCases
        {
            public const string Add_Al_Imm8 = "04 ib";

            public const string Add_Ax_Imm16 = "05 iw";

            public const string Add_Eax_Imm32 = "05 id";

            public const string Add_Rax_Imm32 = "REX.W+ 05 id";
        }
    }
}