//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    using static z;
    using static Konst;
    using static AppShell;

    class App : AppShell<App,IAppContext>
    {
        public CorrelationToken Ct {get;}

        public App()
            : base(WfBuilder.app())
        {
            Ct = correlate(Id);
        }

        public override void RunShell(IWfShell wf)
        {
            try
            {
                // var config = WfBuilder.configure(Context, args);
                // using var log = AB.termlog(config.StatusLog, config.ErrorLog);
                // using var sink = AB.termsink(log, Ct);
                // using var wf = new WfContext(Context, Ct, config, sink);

                using var control = new CaptureControl(new WfCaptureState(wf, new AsmContext(Context), wf.Config, Ct));
                wf.Raise(new LogsConfigured(ActorName, wf.Config.Logs, Ct));
                control.Run();
            }
            catch(Exception e)
            {
                Raise(WfEvents.error(ActorName, e, Ct));
            }
        }

        public static int Main(params string[] args)
            => Launch(AB.shell(args));
    }

    public static partial class XTend { }
}