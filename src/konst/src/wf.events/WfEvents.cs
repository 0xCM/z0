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

    [ApiHost, Events]
    public readonly partial struct WfEvents
    {
        [MethodImpl(Inline), Op]
        public static IWfEventLog log(WfLogConfig config, bool clear = true)
            => new WfEventLog2(FS.path(config.StatusLog.Name), FS.path(config.ErrorLog.Name), clear);
    }
}