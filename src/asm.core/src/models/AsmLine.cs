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
        public const byte InstructionWidth = 46;

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

        public string Format()
        {
            if(Label.IsNonEmpty)
                return string.Format("{0}:",Label.Name);
            else if(Statement.IsNonEmpty)
            {
                if(Comment.IsNonEmpty)
                    return string.Format("{0,-46} ; {1}", Statement, Comment.Content);
                else
                    return Statement.Format();
            }
            else if(Comment.IsNonEmpty)
            {
                return string.Format("; {0}", Comment.Content);
            }
            else
                return EmptyString;
        }

        public override string ToString()
            => Format();

        public static AsmLine Empty
        {
            [MethodImpl(Inline)]
            get => new AsmLine(0, AsmStatementExpr.Empty);
        }
    }
}