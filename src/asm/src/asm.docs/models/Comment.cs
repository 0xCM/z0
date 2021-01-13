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
        public readonly struct Comment
        {
            public TextLine Text {get;}

            public PartKind Kind
                => PartKind.BlockHeaderLine;

            [MethodImpl(Inline)]
            public Comment(TextLine text)
                => Text = text;

            [MethodImpl(Inline)]
            public string Format()
                => Text.Content;

            public override string ToString()
                => Format();
        }

    }
}