//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Encoded
    {
        [MethodImpl(Inline), Op]
        public static TaggedCodeBlock tag(CodeBlock src, string tag)
            => new TaggedCodeBlock(src, tag);
    }
}