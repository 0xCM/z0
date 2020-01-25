//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.CpuModel
{
    using System;

    /// <summary>
    ///  Classifies XMM registers
    /// </summary>
    [Flags]
    public enum XmmRegId : ulong
    {
        xmm0 = 0,

        xmm1 = xmm0 + 1,

        xmm2 = xmm1 + 1,

        xmm3 = xmm2 + 1,

        xmm4 = xmm3 + 1,

        xmm5 = xmm4 + 1,

        xmm6 = xmm5 + 1,

        xmm7 = xmm6 + 1,

        xmm8 = xmm7 + 1,

        xmm9 = xmm8 + 1,

        xmm10 = xmm9 + 1,

        xmm11 = xmm10 + 1,

        xmm12 = xmm11 + 1,

        xmm13 = xmm12 + 1,

        xmm14 = xmm13 + 1,

        xmm15 = xmm14 + 1,

        xmm16 = xmm15 + 1,

        xmm17 = xmm16 + 1,

        xmm18 = xmm17 + 1,

        xmm19 = xmm18 + 1,

        xmm20 = xmm19 + 1,

        xmm21 = xmm20 + 1,

        xmm22 = xmm21 + 1,

        xmm23 = xmm22 + 1,

        xmm24 = xmm23 + 1,

        xmm25 = xmm24 + 1,

        xmm26 = xmm25 + 1,

        xmm27 = xmm26 + 1,

        xmm28 = xmm27 + 1,

        xmm29 = xmm28 + 1,

        xmm30 = xmm29 + 1,

        xmm31 = xmm30 + 1,

    }
}