//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Encoded
    {

        public static TaggedCodeBlock tag(CodeBlock src, string tag)
            => new TaggedCodeBlock(src, tag);
    }
}