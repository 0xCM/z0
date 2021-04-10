//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Part;
    using static AsmMnemonicCode;
    using static AsmOps;

    partial struct AsmX
    {
        // 22 /r            | AND r8, r/m8     | RM    | Valid       | Valid           | r8 AND r/m8.                              |
        [Op, AsmSig(AsmSigKind.and_r8_r8)]
        public AsmExpr and(r8 a0, r8 a1)
            => Produce(S[AND], S[a0], S[a1]);

        // | 23 /r            | AND r16, r/m16   | RM    | Valid       | Valid           | r16 AND r/m16.                            |
        [Op, AsmSig(AsmSigKind.and_r16_r16)]
        public AsmExpr and(r16 a0, r16 a1)
            => Produce(S[AND], S[a0], S[a1]);

        // 80 /4 ib         | AND r/m8, imm8   | MI    | Valid       | Valid           | r/m8 AND imm8.
        [Op, AsmSig(AsmSigKind.and_r8_imm8)]
        public AsmExpr and(r8 a0, Imm8 imm8)
            => Produce(S[AND], S[a0], imm8);
    }
}