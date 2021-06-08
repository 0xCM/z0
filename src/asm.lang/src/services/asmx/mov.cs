//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmMnemonicCode;
    using static AsmRegCodes;

    partial struct AsmX
    {
        [Op, AsmSig(AsmOcPrototype.mov_r64_imm64)]
        public AsmExpr mov(Gp64 a0, Imm64 a1)
            => Produce(S[MOV], S[a0], a1);
    }
}