//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static TextRules;

    [ApiHost]
    public readonly partial struct AsmExprTest
    {
        public static bool compound(in SigOperandExpr src)
            => Query.contains(src.Text, Chars.FSlash);
    }
}