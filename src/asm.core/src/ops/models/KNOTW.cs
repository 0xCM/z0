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
        public struct KNOTW : IAsmOp<KNOTW>
        {
            public const string OpCode = "VEX.L0.0F.W0 44 /r";

            public const string Sig = "KNOTW k, k";

            public const string Name = "knotw";

            public rK Op0;

            public rK Op1;

            [MethodImpl(Inline)]
            public KNOTW(rK op0, rK op1)
            {
                Op0 = op0;
                Op1 = op1;
            }
        }
    }
}