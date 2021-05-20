//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    partial struct CodeBlocks
    {
        [Op]
        public static Index<ApiHostBlocks> hosted(Index<ApiCodeBlock> src)
            => src.GroupBy(x => x.HostUri).Select(x => new ApiHostBlocks(x.Key, x.ToArray())).Array();

        [Op]
        public static ReadOnlySpan<ApiHostBlocks> hosted(ReadOnlySpan<ApiCodeBlock> src)
            => src.ToArray().GroupBy(x => x.HostUri).Select(x => new ApiHostBlocks(x.Key, x.ToArray())).Array();
    }
}