//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly ref struct AsmBlockComment
    {
        public ReadOnlySpan<TextLine> Content {get;}

        [MethodImpl(Inline)]
        public AsmBlockComment(ReadOnlySpan<TextLine> src)
        {
            Content = src;
        }
    }
}