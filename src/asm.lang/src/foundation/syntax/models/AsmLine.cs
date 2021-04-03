//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmLine : IRecord<AsmLine>
    {
        public uint LineNumber {get;}

        public AsmLabel Label {get;}

        public AsmStatementExpr Statement {get;}

        public AsmComment Comment {get;}

        [MethodImpl(Inline)]
        public AsmLine(uint number, AsmStatementExpr statement, AsmComment? comment = null)
        {
            LineNumber = number;
            Label = AsmLabel.Empty;
            Statement = statement;
            Comment = comment ?? AsmComment.Empty;
        }

        [MethodImpl(Inline)]
        public AsmLine(uint number, AsmLabel label, AsmComment? comment = null)
        {
            LineNumber = number;
            Label = label;
            Statement = AsmStatementExpr.Empty;
            Comment = comment ?? AsmComment.Empty;
        }


        [MethodImpl(Inline)]
        public string Format()
            => Statement.Format();

        public override string ToString()
            => Format();

        public static AsmLine Empty
        {
            [MethodImpl(Inline)]
            get => new AsmLine(0, AsmStatementExpr.Empty);
        }
    }
}