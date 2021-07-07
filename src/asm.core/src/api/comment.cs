//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmComment comment(string src)
            => new AsmComment(src);

        [MethodImpl(Inline), Op]
        public static AsmBlockComment comment(ReadOnlySpan<TextLine> src)
            => new AsmBlockComment(src);
    }
}