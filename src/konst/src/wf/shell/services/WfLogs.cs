//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfLogs
    {
        [MethodImpl(Inline), Op]
        public static IWfEventLog events(WfLogConfig config)
            => new WfEventLog(config);
    }
}