//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Pow2x32;

    public enum ComparisonKind : uint
    {
        None = 0,

        Eq = P2ᐞ00,

        Neq = P2ᐞ01,

        Lt = P2ᐞ02,

        LtEq = P2ᐞ03,

        Gt = P2ᐞ04,

        GtEq = P2ᐞ05,
    }
}