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

        [Op]
        public static CmdEngine create(IWfShell wf, ICmdObserver observer)
        {
            var settings = new CmdEngineSettings();
            settings.EngineKind = CmdEngineKind.CmdExe;
            settings.Path = FS.path("cmd.exe");

            var info = new ProcessStartInfo(settings.Path.Name);
            info.UseShellExecute = false;
            info.RedirectStandardInput = true;
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.CreateNoWindow = true;
            info.Arguments = EmptyString;
            return new CmdEngine(wf, settings, info, observer);
        }
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