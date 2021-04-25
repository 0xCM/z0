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
        public static ApiCaptureResult result(OpIdentity id, CaptureOutcome outcome, CodeBlockPair pair)
            => new ApiCaptureResult(outcome,pair);
    }
}