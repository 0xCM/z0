//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmCaseKinds;

    partial class AsmCases
    {
        [MethodImpl(Inline), Op]
        public static AsmText<byte> pinsrb(N0 n, OpCodeCase kind)
            => opcode("66 0F 3A 20 /r ib");

        [MethodImpl(Inline), Op]
        public static AsmText<byte> pinsrb(N0 n, SigCase kind)
            => sig("PINSRB xmm1, r32/m8, imm8");

        [MethodImpl(Inline), Op]
        public static AsmText<byte> pinsrb_rule(N0 n, RuleCase kind)
            => rule("ModRM:reg (w) | ModRM:r/m (r) | imm8");
    }
}