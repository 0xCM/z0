//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct lang
    {
        [MethodImpl(Inline), Op]
        public static Comment comment(CommentKind kind, Text content)
            => new Comment(kind, content);
    }
}