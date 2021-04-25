//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public static partial class XCode
    {
        public static Index<ApiHostBlocks> ToHostBlocks(this Index<ApiCodeBlock> src)
            => CodeBlocks.hosted(src);

        public static Index<ApiHostBlocks> ToHostBlocks(this ApiCodeBlock[] src)
            => CodeBlocks.hosted(src);

        public static Index<ApiPartBlocks> ToPartBlocks(this Index<ApiHostBlocks> src)
            => CodeBlocks.parts(src);
    }
}