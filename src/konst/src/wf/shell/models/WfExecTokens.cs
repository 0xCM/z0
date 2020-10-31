// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Konst;
    using static z;

    public sealed class WfExecTokens : ConcurrentDictionary<ulong,WfExecToken>
    {
        [MethodImpl(Inline)]
        public static WfExecTokens init()
            => new WfExecTokens();
    }
}