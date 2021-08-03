//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct Comment
        {
            public CommentKind Kind {get;}

            public Text Content {get;}

            [MethodImpl(Inline)]
            public Comment(CommentKind kind, Text content)
            {
                Kind = kind;
                Content = content;
            }
        }
    }
}