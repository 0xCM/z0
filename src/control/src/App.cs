//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    using static z;

    class App : IDisposable
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        App(IWfShell wf)
        {
            Host = WfSelfHost.create(typeof(App));
            Wf = wf.WithHost(Host);
            PrintContextSummary();
        }

        void PrintContextSummary()
            => iter(Wf.Settings, s => Wf.Status(string.Format("{0}:{1}", s.Name, s.Value )));

        public void Run()
        {
            try
            {
                var app = Apps.context(Wf);
                var asm = new AsmContext(app, Wf);
                var cstate = new WfCaptureState(Wf, asm);
                using var control = CaptureWorkflow.create(cstate);
                control.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = Polyrand.install(WfShell.create(args));
                using var host = new App(wf);
                host.Run();
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        public void Dispose()
        {

        }
    }

    public static partial class XTend { }
}