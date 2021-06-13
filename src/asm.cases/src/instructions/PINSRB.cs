//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmTextBuilder;

    partial class AsmCases
    {
        [ApiComplete]
        public readonly struct PINSRB
        {
            [MethodImpl(Inline)]
            public static AsmText<byte> OpCodeSig()
                => asmtext("66 0F 3A 20 /r ib", AsmTextKind.OpCode);

            [MethodImpl(Inline)]
            public static AsmText<byte> FormSig()
                => asmtext("PINSRB xmm1, r32/m8, imm8", AsmTextKind.OpCode);

            [MethodImpl(Inline)]
            public static AsmText<byte> EncodingRule()
                => asmtext("ModRM:reg (w) | ModRM:r/m (r) | imm8", AsmTextKind.EncodingRule);
        }
    }
}