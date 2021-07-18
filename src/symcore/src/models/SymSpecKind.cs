//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Pow2x16;

    [Flags]
    public enum SymSpecKind : ushort
    {
        None,

        Index = P2ᐞ00,

        Kind = P2ᐞ01,

        Name = P2ᐞ02,

        Expression = P2ᐞ03,

        Value = P2ᐞ04,

        Description = P2ᐞ05,

        ValueKind = P2ᐞ06,
    }
}