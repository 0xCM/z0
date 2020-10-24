//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

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
        {
            z.iter(Wf.Settings, s => Wf.Status(string.Format("{0}:{1}", s.Name, s.Value )));
        }


        public static void Main(params string[] args)
        {
            try
            {
                using var wf = Polyrand.install(WfShell.create(args));
                using var host = new App(wf);
                var app = Apps.context(wf);
                var asm = new AsmContext(app, wf);
                var cstate = new WfCaptureState(wf, asm);
                using var control = CaptureWorkflow.create(cstate);
                control.Run();
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