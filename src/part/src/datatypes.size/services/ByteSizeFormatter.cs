//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static root;

    [Formatter]
    readonly struct ByteSizeFormatter : ITextFormatter<ByteSize>
    {
        public string Format(ByteSize src)
            => src.Content == 0 ? "0" : src.Content.ToString("#,#");
    }
}