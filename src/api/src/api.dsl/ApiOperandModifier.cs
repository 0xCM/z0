//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Pow2x16;

    [Flags]
    public enum ApiOperandModifier : ushort
    {
        None,

        In = P2ᐞ00,

        Out = P2ᐞ01,

        Ref = P2ᐞ02,

        Ptr = P2ᐞ03,

        Imm = P2ᐞ04,
    }
}