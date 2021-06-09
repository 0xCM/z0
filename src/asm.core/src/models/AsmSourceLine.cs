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

        public AsmLabel Label {get;}

        public AsmExpr Statement {get;}

        public AsmComment Comment {get;}

        [MethodImpl(Inline)]
        public AsmSourceLine(uint number, AsmExpr statement, AsmComment? comment = null)
        {
            LineNumber = number;
            Label = AsmLabel.Empty;
            Statement = statement;
            Comment = comment ?? AsmComment.Empty;
        }

        [MethodImpl(Inline)]
        public AsmSourceLine(uint number, AsmLabel label, AsmComment? comment = null)
        {
            LineNumber = number;
            Label = label;
            Statement = AsmExpr.Empty;
            Comment = comment ?? AsmComment.Empty;
        }

        public static AsmSourceLine Empty
        {
            [MethodImpl(Inline)]
            get => new AsmSourceLine(0, AsmExpr.Empty);
        }
    }
}