//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly partial struct AsmSyntaxNodes
    {
        public readonly struct Comment : IAsmSyntaxNode<Comment>
        {
            public TextBlock Content {get;}

            public AsmNodeKind NodeKind => AsmNodeKind.Comment;
        }

        public readonly struct LineLabel : IAsmSyntaxNode<LineLabel>
        {
            public TextBlock Content {get;}

            public AsmNodeKind NodeKind => AsmNodeKind.LineLabel;
        }

        public readonly struct LabelDef : IAsmSyntaxNode<LabelDef>
        {
            public Identifier Name {get;}


            public AsmNodeKind NodeKind => AsmNodeKind.LabelDef;
        }

        public readonly struct LabelRef : IAsmSyntaxNode<LabelRef>
        {
            public LabelDef Target {get;}

            [MethodImpl(Inline)]
            public LabelRef(LabelDef src)
            {
                Target = src;
            }

            public AsmNodeKind NodeKind => AsmNodeKind.LabelRef;
        }

        public readonly struct Alias : IAsmSyntaxNode<Alias>
        {
            public Identifier Name {get;}

            public IAsmSyntaxNode Subject {get;}

            public AsmNodeKind NodeKind => AsmNodeKind.Alias;
        }

        public readonly struct Keyword : IAsmSyntaxNode<Keyword>
        {
            public AsmKeyword Word {get;}

            [MethodImpl(Inline)]
            public Keyword(AsmKeyword value)
            {
                Word = value;
            }

            public AsmNodeKind NodeKind => AsmNodeKind.Keyword;
        }
    }
}