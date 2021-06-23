//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmMnemonicCode;
    using static RegCodes;

    partial struct AsmX
    {
        [Op]
        public AsmExpr mov(Gp64 a0, Imm64 a1)
            => Produce(S[MOV], S[a0], a1);
    }
}