//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    // 0008h movzx edx,dl                            ; MOVZX r32, r/m8                  | 0F B6 /r                         | 3   | 0f b6 d2
    public readonly struct AsmStatementLine : IAsmDocPart<AsmStatementLine>
    {
        public MemoryAddress Address {get;}

        public AsmLineLabel Label {get;}

        public AsmStatement Statement {get;}

        public AsmComment Comment {get;}

        [MethodImpl(Inline)]
        public AsmStatementLine(AsmLineLabel label, AsmStatement statement)
        {
            Address= 0;
            Label = label;
            Statement = statement;
            Comment = AsmComment.Empty;
        }

        [MethodImpl(Inline)]
        public AsmStatementLine(MemoryAddress address, AsmLineLabel label, AsmStatement statement, AsmComment comment)
        {
            Address= address;
            Label = label;
            Statement = statement;
            Comment = comment;
        }

        [MethodImpl(Inline)]
        public AsmStatementLine(MemoryAddress address, AsmLineLabel label, AsmStatement statement)
        {
            Address= address;
            Label = label;
            Statement = statement;
            Comment = AsmComment.Empty;
        }

        [MethodImpl(Inline)]
        public string Format()
            => "";

        public override string ToString()
            => Format();
    }
}