//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Threading;

    using Z0.Asm;

    using static zfunc;

    public static class AsmTriggers
    {
        static int LastId;

        internal static int NextId()
            => Interlocked.Increment(ref LastId);
    }
}