//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    partial struct Encoded
    {
        public static TaggedCodeBlock tag(BasedCodeBlock src, string tag)
            => new TaggedCodeBlock(src, tag);
    }
}