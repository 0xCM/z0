//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct lang
    {
        /// <summary>
        /// Defines a <see cref='Comment'/>
        /// </summary>
        /// <param name="kind">The sort of comment to define</param>
        /// <param name="content">The comment body</param>
        [MethodImpl(Inline), Op]
        public static Comment comment(CommentKind kind, TextBlock content)
            => new Comment(kind, content);
    }
}