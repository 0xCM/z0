//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Hex8Seq;

    public enum AsmPrefixCode : byte
    {
        LOCK = xf0,

        REPNE = xf2,

        REP = xf3,

        OP = x66,

        CS = x2e,

        DS = x3e,

        ES = x26,

        FS = x64,

        GS = x65,

        SS = x36,

        Address = x67,

        RexW = x48,

        RexWB = x49,

        RexWX = x4a,

        RexXB = x4b,

        RexWR = x4c,

        RexWRB = x4d,

        RexWRX = x4e,

        RexWRXB = x4f,
    }


}