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
        public readonly struct HeaderLine
        {
            public TextLine Text {get;}

            public AsmDocPartKind Kind
                => AsmDocPartKind.BlockHeaderLine;

            [MethodImpl(Inline)]
            public HeaderLine(TextLine text)
                => Text = text;

            [MethodImpl(Inline)]
            public string Format()
                => Text.Content;

            public override string ToString()
                => Format();
        }
    }
}