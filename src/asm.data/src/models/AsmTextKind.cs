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

        Statement = P2ᐞ04,

        Comment = P2ᐞ05,

        Encoding = P2ᐞ06,

        EncodingRule = P2ᐞ31 | Rule,

        HexEncoding = P2ᐞ32 | Encoding,

        BitstringEncoding = P2ᐞ33 | Encoding,
    }
}