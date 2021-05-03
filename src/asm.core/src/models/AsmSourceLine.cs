//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmSourceLine
    {
        public uint LineNumber {get;}

        public AsmLabel Label {get;}

        public AsmStatementExpr Statement {get;}

        public AsmComment Comment {get;}

        [MethodImpl(Inline)]
        public AsmSourceLine(uint number, AsmStatementExpr statement, AsmComment? comment = null)
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
            Statement = AsmStatementExpr.Empty;
            Comment = comment ?? AsmComment.Empty;
        }

        public static AsmSourceLine Empty
        {
            [MethodImpl(Inline)]
            get => new AsmSourceLine(0, AsmStatementExpr.Empty);
        }
    }
}