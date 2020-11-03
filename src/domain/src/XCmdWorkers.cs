//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost(ApiNames.XCmdWorkers)]
    public static partial class XCmdWorkers
    {
        [MethodImpl(Inline), Op]
        public static CmdWorker<EmitRuntimeIndexCmd> Worker(this EmitRuntimeIndexCmd cmd)
            => Cmd.worker(new CmdWorkerFunction<EmitRuntimeIndexCmd>(ApiRuntime.execute));
    }
}