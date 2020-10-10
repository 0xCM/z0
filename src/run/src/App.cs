//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;
    using static AppHost;

    [Step]
    sealed class AppHost : WfHost<AppHost>
    {
        public static WfStepId StepId => typeof(AppHost);
    }

    class App : AppShell<App,IAppContext>
    {
        public const PartId Part = PartId.Run;

        public const string PartName = nameof(PartId.Run);

        public const string ActorName = PartName + "/" + nameof(App);

        public CorrelationToken Ct {get;}

        public App()
            : base(Apps.context())
        {
            Ct = correlate(Part);
        }

        public override void RunShell(params string[] args)
        {
            using var wf = WfShell.shell(args);
            using var state = AsmWorkflows.state(wf, AsmWorkflows.context(Context));

            try
            {
                wf.Running(StepId, text.bracket(args.FormatList()));
                using var runner = new Runner(state);
                runner.Run();
                wf.Ran(StepId);
            }
            catch(Exception e)
            {
                wf.Error(e, Ct);
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