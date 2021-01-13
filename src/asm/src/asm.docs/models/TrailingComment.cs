//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmDocParts
    {
        public readonly struct TrailingComment
        {
            public TextBlock Text {get;}

            public PartKind Kind
                => PartKind.BlockHeaderLine;

            [MethodImpl(Inline)]
            public TrailingComment(TextBlock text)
                => Text = text;

            [MethodImpl(Inline)]
            public string Format()
                => Text;

            public override string ToString()
                => Format();
        }

    }
}