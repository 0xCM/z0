//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct ApiExtracts
    {
        [Op, MethodImpl(Inline)]
        internal static ApiCaptureResult summarize(Span<byte> src, OpIdentity id, ExtractTermCode tc, long start, long end, int delta)
        {
            var outcome = complete(tc, start, end, delta);
            var raw = src.Slice(0, (int)(end - start)).ToArray();
            var trimmed = src.Slice(0, outcome.ByteCount).ToArray();
            var bits = CodeBlocks.pair((MemoryAddress)start, raw, trimmed);
            return CodeBlocks.result(id, outcome, bits);
        }
    }
}
