//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Threading;
    
    internal static class AsmTriggers
    {
        static int LastId;

        internal static int NextId()
            => Interlocked.Increment(ref LastId);
    }
}