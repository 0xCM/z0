//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

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