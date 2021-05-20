//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public static partial class XCode
    {
        public static Index<ApiHostBlocks> ToHostBlocks(this Index<ApiCodeBlock> src)
            => CodeBlocks.hosted(src);

        public static ReadOnlySpan<ApiHostBlocks> ToHostBlocks(this ReadOnlySpan<ApiCodeBlock> src)
            => CodeBlocks.hosted(src);

        public static Index<ApiHostBlocks> ToHostBlocks(this ApiCodeBlock[] src)
            => CodeBlocks.hosted(src);

        public static Index<ApiHostBlocks> ToHostBlocks(this ApiCodeBlocks src)
            => CodeBlocks.hosted(src.Storage);

        public static Index<ApiPartBlocks> ToPartBlocks(this Index<ApiHostBlocks> src)
            => CodeBlocks.parts(src);

        public static ReadOnlySpan<ApiPartBlocks> ToPartBlocks(this ReadOnlySpan<ApiHostBlocks> src)
            => CodeBlocks.parts(src);
    }
}