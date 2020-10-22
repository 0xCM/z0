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

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static WfSteps Steps(this IWfShell wf)
            => new WfSteps(wf);
    }

    public readonly struct WfSteps
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly ConcurrentDictionary<ulong,IWfHost> Hosts;

        readonly CmdRouter Router;

        [MethodImpl(Inline)]
        public WfSteps(IWfShell wf)
        {
            Host = WfSelfHost.create(typeof(WfSteps));
            Wf = wf.WithHost(Host);
            Hosts = new ConcurrentDictionary<ulong, IWfHost>();
            Router = Cmd.router(Wf);
        }
     }
}