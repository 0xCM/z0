//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct CSharpSourceBlock : ISourceCode<CSharpSourceBlock,TextLine>
    {
        public Index<TextLine> Code {get;}

        [MethodImpl(Inline)]
        public CSharpSourceBlock(Index<TextLine> lines)
        {
            Code  = lines;
        }

        public ReadOnlySpan<TextLine> View
        {
            [MethodImpl(Inline)]
            get => Code.View;
        }

        public Span<TextLine> Edit
        {
            [MethodImpl(Inline)]
            get => Code.Edit;
        }
    }
}