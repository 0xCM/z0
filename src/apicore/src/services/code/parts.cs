//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    partial struct CodeBlocks
    {
        [Op]
        public static ReadOnlySpan<ApiPartBlocks> parts(ReadOnlySpan<ApiHostBlocks> src)
            => src.ToArray().GroupBy(x => x.Part).Select(x => new ApiPartBlocks(x.Key, x.ToArray())).Array();
    }
}