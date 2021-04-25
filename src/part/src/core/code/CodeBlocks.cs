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

    public static partial class XCode
    {
        public static Index<ApiHostBlocks> ToHostBlocks(this Index<ApiCodeBlock> src)
            => src.GroupBy(x => x.HostUri).Select(x => new ApiHostBlocks(x.Key, x.ToArray())).Array();

        public static Index<ApiHostBlocks> ToHostBlocks(this ApiCodeBlock[] src)
            => src.GroupBy(x => x.HostUri).Select(x => new ApiHostBlocks(x.Key, x.ToArray())).Array();

        public static Index<ApiPartBlocks> ToPartBlocks(this Index<ApiHostBlocks> src)
            => src.GroupBy(x => x.Part).Select(x => new ApiPartBlocks(x.Key, x.ToArray())).Array();
    }
}