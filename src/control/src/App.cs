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

    readonly struct AppShell
    {
        public const PartId Id = PartId.Control;

        public const string AppName = nameof(PartId.Control);

        public const string ActorName = AppName + "/" + nameof(App);
    }

    class App : AppShell<App,IAppContext>
    {
        public CorrelationToken Ct {get;}

        public App()
            : base(ContextFactory.create())
        {
            Ct = correlate(Id);
        }

        public override void RunShell(params string[] args)
        {
            try
            {
                var context = Context;
                var config = Flow.configure2(context, args, Ct);
                using var log = Flow.log(config.StatusLog, config.ErrorLog);
                using var termSink = Flow.termsink(log, Ct);
                using var wf = new WfContext(context, Ct, config, termSink);
                using var control = new CaptureControl(new WfCaptureState(wf, new AsmContext(context), config, Ct));
                wf.Raise(new LogsConfigured(ActorName, config.Logs, Ct));

                control.Run();
            }
            catch(Exception e)
            {
                Raise(Flow.error(ActorName, e, Ct));
            }
        }

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend { }
}