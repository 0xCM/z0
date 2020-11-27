//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public enum ClaimKind : byte
    {
        Eq,

        Close,

        EqItem,

        NEq,

        Lt,

        LtEq,

        Gt,

        GtEq,

        False,

        True,

        Fail,

        Nonzero,

        Between,

        NotIn,

        Invariant
    }
}