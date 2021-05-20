//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;

    partial struct CodeBlocks
    {
        [Op]
        public static Index<ApiPartBlocks> parts(Index<ApiHostBlocks> src)
            => src.GroupBy(x => x.Part).Select(x => new ApiPartBlocks(x.Key, x.ToArray())).Array();

        [Op]
        public static ReadOnlySpan<ApiPartBlocks> parts(ReadOnlySpan<ApiHostBlocks> src)
            => src.ToArray().GroupBy(x => x.Part).Select(x => new ApiPartBlocks(x.Key, x.ToArray())).Array();

    }
}