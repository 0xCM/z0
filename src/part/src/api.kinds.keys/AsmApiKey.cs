//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Id = ApiOpId;

    public enum AsmApiKey : ushort
    {
        CVTSS2SI = Id.Intrinsic + 1,

        CVTSD2SI,

        PAVGB,

        PAVGW,

        VPAVGB,

        VPAVGW
    }
}