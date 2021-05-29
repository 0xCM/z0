//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmOps;

    partial struct AsmX
    {
        [Op, AsmSig(AsmOc.vlddqu_xmm_m128)]
        public AsmExpr vlddqu(xmm a0, mem<xmm> a1)
            => default;
    }
}