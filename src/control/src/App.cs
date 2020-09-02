//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;
    using System.Reflection;

    using static z;
    using static Konst;
    using static AppShell;

    class App : Shell<App,IWfShell>
    {
        public CorrelationToken Ct {get;}

        public App()
            : base(WfBuilder.context(Assembly.GetEntryAssembly()))
        {
            Ct = correlate(Id);
        }

        public override void RunShell(IWfShell wf)
        {
            // try
            // {
            //     using var control = new CaptureControl(new WfCaptureState(wf, new AsmContext(Context), wf.Config, Ct));
            //     wf.Raise(new LogsConfigured(ActorName, wf.Config.Logs, Ct));
            //     control.Run();
            // }
            // catch(Exception e)
            // {
            //     Raise(WfEvents.error(ActorName, e, Ct));
            // }
        }

        public static int Main(params string[] args)
            => 0;
            //=> Launch(AB.shell(args));
    }

    public static partial class XTend { }
}