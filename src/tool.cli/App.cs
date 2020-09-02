//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static Shelly;

    using static z;

    readonly struct Shelly : IWfStep<Shelly>
    {
        public const PartId ShellId = PartId.ToolCli;

        public const string ShellName = nameof(PartId.ToolCli) + "/" + nameof(App);

        public static WfStepId StepId
            => AB.step<Shelly>();
    }

    class App : AppShell<App,IAppContext>
    {

        public CorrelationToken Ct {get;}

        public App()
            : base(WfBuilder.app())
        {
            Ct = correlate(ShellId);
        }

        public override void RunShell(params string[] args)
        {
            try
            {
                var config = WfBuilder.configure(Context,args);
                using var log = AB.log(config);
                using var wf = WfBuilder.shell(config, log);
                wf.Status(StepId, new {Message ="Running shell", Args = text.bracket(args.FormatList())});

                wf.Status(StepId, "Shell run complete");
            }
            catch(Exception e)
            {
                Raise(WfEvents.error(ShellName, e, Ct));
            }

        }

        public static void Main(params string[] args)
            => Launch(args);

        protected override void OnDispose()
        {

        }
    }

    public static partial class XTend
    {

    }
}