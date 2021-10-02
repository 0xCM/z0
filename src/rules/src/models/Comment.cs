//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RuleModels
    {
        public readonly struct Comment
        {
            public CommentKind Kind {get;}

            public TextBlock Content {get;}

            [MethodImpl(Inline)]
            public Comment(CommentKind kind, TextBlock content)
            {
                Kind = kind;
                Content = content;
            }
        }
    }
}