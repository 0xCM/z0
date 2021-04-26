//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct CodeBlocks
    {
        [MethodImpl(Inline), Op]
        public static ApiCaptureResult result(OpIdentity id,  ExtractTermCode term, MemoryRange range, CodeBlockPair pair)
            => new ApiCaptureResult(term, range,pair);
    }
}