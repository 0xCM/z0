//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static AsmOperands;
    using static Root;

    partial class AsmOps
    {
        public struct KNOTD : IAsmOp<KNOTD>
        {
            public const string OpCode = "VEX.L0.66.0F.W1 44 /r";

            public const string Sig = "KNOTD k, k";

            public const string Name = "knotd";

            public rK Op0;

            public rK Op1;

            [MethodImpl(Inline)]
            public KNOTD(rK op0, rK op1)
            {
                Op0 = op0;
                Op1 = op1;
            }

        }
    }
}