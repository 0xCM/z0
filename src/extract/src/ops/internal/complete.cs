//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ApiExtracts
    {
        [Op, MethodImpl(Inline)]
        internal static CaptureOutcome complete(ExtractTermCode tc, long start, long end, int delta)
            => new CaptureOutcome(((ulong)start, (ulong)(end + delta)), tc);
    }
}