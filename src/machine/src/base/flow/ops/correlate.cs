//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static z;

    partial struct Workflows
    {
        [MethodImpl(Inline)]
        public CorrelationToken<ulong> correlate()
            => new CorrelationToken<ulong>((ulong)z.atomic(ref Correlation));
    }
}