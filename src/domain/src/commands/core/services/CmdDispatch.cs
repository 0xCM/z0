//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Konst;

    public readonly struct CmdDispatch : ICmdRouter<CmdDispatch>
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly ConcurrentDictionary<ulong,IWfHost> Hosts;

        readonly ICmdRouter Router;

        [MethodImpl(Inline)]
        public CmdDispatch(IWfShell wf)
        {
            Host = WfSelfHost.create(typeof(CmdDispatch));
            Wf = wf.WithHost(Host);
            Hosts = new ConcurrentDictionary<ulong,IWfHost>();
            Router = Cmd.router(wf);
        }

        public CmdResult Dispatch(CmdSpec cmd)
        {
            return default;
        }
    }
}