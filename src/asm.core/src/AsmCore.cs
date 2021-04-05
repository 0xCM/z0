//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct AsmCore
    {
        public static string[] operands(string instruction)
            => instruction.RightOfFirst(Chars.Space).Split(Chars.Comma).Select(x => x.Trim());

        [MethodImpl(Inline), Op]
        public static AsmLabel label(Identifier name)
            => new AsmLabel(name);

        [MethodImpl(Inline), Op]
        public static AsmStatementExpr statement(string src)
            => new AsmStatementExpr(src);

        [MethodImpl(Inline), Op]
        public static AsmComment comment(string src)
            => new AsmComment(src);
    }
}