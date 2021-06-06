//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Pow2x64;

    [Flags]
    public enum AsmTextKind : ulong
    {
        None = 0,

        Expr = P2ᐞ00,

        OpCode = P2ᐞ01,

        Form = P2ᐞ02,

        Rule = P2ᐞ03,

        EncodingRule = P2ᐞ31 | Rule,
    }
}