//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmSyntax
    {
        public readonly struct CommentNode : IAsmSyntaxNode<CommentNode>
        {
            public TextBlock Content {get;}

            public AsmNodeKind NodeKind
                => AsmNodeKind.Comment;
        }

        public readonly struct LineLabelNode : IAsmSyntaxNode<LineLabelNode>
        {
            public TextBlock Content {get;}

            public AsmNodeKind NodeKind => AsmNodeKind.LineLabel;
        }

        public readonly struct LabelDefNode : IAsmSyntaxNode<LabelDefNode>
        {
            public Identifier Name {get;}

            public AsmNodeKind NodeKind
                => AsmNodeKind.LabelDef;
        }

        public readonly struct LabelRefNode : IAsmSyntaxNode<LabelRefNode>
        {
            public LabelDefNode Target {get;}

            [MethodImpl(Inline)]
            public LabelRefNode(LabelDefNode src)
            {
                Target = src;
            }

            public AsmNodeKind NodeKind
                => AsmNodeKind.LabelRef;
        }

        public readonly struct AliasNode : IAsmSyntaxNode<AliasNode>
        {
            public Identifier Name {get;}

            public IAsmSyntaxNode Subject {get;}

            public AsmNodeKind NodeKind
                => AsmNodeKind.Alias;
        }

        public readonly struct KeywordNode : IAsmSyntaxNode<KeywordNode>
        {
            public AsmKeyword Word {get;}

            [MethodImpl(Inline)]
            public KeywordNode(AsmKeyword value)
            {
                Word = value;
            }

            public AsmNodeKind NodeKind
                => AsmNodeKind.Keyword;
        }
    }
}