//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct WfEvents
    {
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ProcessedEvent<T> processed<T>(WfStepId step, T content, CorrelationToken ct)
            => new ProcessedEvent<T>(step, content, ct);
    }
}