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
        // 0008h movzx edx,dl                            ; MOVZX r32, r/m8                  | 0F B6 /r                         | 3   | 0f b6 d2
        public readonly struct StatementLine
        {
            public TextLine Text {get;}

            public PartKind Kind
                => PartKind.BlockHeaderLine;

            [MethodImpl(Inline)]
            public StatementLine(TextLine text)
                => Text = text;

            [MethodImpl(Inline)]
            public string Format()
                => Text.Content;

            public override string ToString()
                => Format();
        }
    }
}