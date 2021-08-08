//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmSourceLine
    {
        public uint LineNumber {get;}

        public TextBlock Label {get;}

        public AsmExpr Statement {get;}

        public AsmComment Comment {get;}

        [MethodImpl(Inline)]
        public AsmSourceLine(uint number, TextBlock label, AsmExpr statement, AsmComment? comment = null)
        {
            LineNumber = number;
            Label = TextBlock.Empty;
            Statement = statement;
            Comment = comment ?? AsmComment.Empty;
        }

        public static AsmSourceLine Empty
        {
            [MethodImpl(Inline)]
            get => new AsmSourceLine(0, TextBlock.Empty, AsmExpr.Empty);
        }
    }
}