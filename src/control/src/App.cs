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
        static IWfShell describe(IWfShell wf)
        {
            iter(wf.Settings, s => wf.Status(string.Format("{0}:{1}", s.Name, s.Value )));
            return wf;
        }

        static IWfShell Configure(IWfShell wf)
            => describe(wf.WithRandom(Polyrand.@default())
                 .WithHost(WfSelfHost.create(typeof(App)))
                 .WithVerbosity(LogLevel.Babble));

        static void Run(string[] args)
        {
            using var wf = Configure(WfShellInit.create(args));
            var app = Apps.context(wf);
            var asm = new AsmContext(app, wf);
            var cstate = new WfCaptureState(wf, asm);
            using var control = CaptureWorkflow.create(cstate);
            control.Run();
        }

        public static void Main(params string[] args)
        {
            try
            {
                Run(args);
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