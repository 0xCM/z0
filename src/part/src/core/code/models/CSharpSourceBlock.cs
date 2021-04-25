//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CSharpSourceBlock : ISourceCode<CSharpSourceBlock>
    {
        public Index<TextLine> Code {get;}

        [MethodImpl(Inline)]
        public CSharpSourceBlock(Index<TextLine> lines)
        {
            Code  = lines;
        }

        public ReadOnlySpan<TextLine> Lines
        {
            [MethodImpl(Inline)]
            get => Code.View;
        }
    }
}