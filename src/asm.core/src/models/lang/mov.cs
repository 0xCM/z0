//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmMnemonicCode;
    using static AsmRegTokens;

    partial struct AsmLang
    {
        [Op]
        public AsmExpr mov(Gp64Reg a0, imm64 a1)
            => Produce(S[MOV], S[a0], a1);
    }
}