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
            public DocLine Content {get;}

            public PartKind Kind
                => PartKind.BlockHeaderLine;

            [MethodImpl(Inline)]
            public StatementLine(DocLine src)
                => Content = src;

            [MethodImpl(Inline)]
            public string Format()
                => Content.Format();

            public override string ToString()
                => Format();
        }
    }
}