//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static Konst;

    public class CmdEngine : SystemAgent, ICmdObserver
    {
        CmdEngineSettings Settings {get;}

        ProcessStartInfo StartInfo {get;}

        ICmdObserver Observer {get;}

        WfHost Host {get;}

        IWfShell Wf {get;}

        [MethodImpl(Inline)]
        public CmdEngine(IWfShell wf, CmdEngineSettings settings, ProcessStartInfo start, ICmdObserver observer = null)
            : base(new WfAgentContext(wf), new AgentIdentity(10u,10u))
        {
            Host = WfSelfHost.create(typeof(CmdEngine));
            Wf = wf.WithHost(Host);
            Settings = settings;
            StartInfo = start;
            Observer = observer ?? this;
        }

        public void Information(string data)
        {
            Wf.Status(data);
        }

        public void Error(string data)
        {
            Wf.Error(data);
        }
    }
}