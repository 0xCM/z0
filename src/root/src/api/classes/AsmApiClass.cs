//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Id = ApiClass;

    [ApiClass]
    public enum AsmApiClass : ushort
    {
        CVTSS2SI = Id.CVTSS2SI,

        CVTSD2SI = Id.CVTSD2SI,

        PAVGB = Id.PAVGB,

        PAVGW = Id.PAVGW,

        VPAVGB = Id.VPAVGB,

        VPAVGW = Id.VPAVGW,

        PSHUFLW = Id.PSHUFLW,

        PSHUFHW = Id.PSHUFHW,

    }
}