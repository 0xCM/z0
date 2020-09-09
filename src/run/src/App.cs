//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    using static Konst;
    using static z;
    using static RunnerShell;

    [Step(typeof(App))]
    readonly struct RunnerShell : IWfStep<RunnerShell>
    {
        public static WfStepId StepId => typeof(RunnerShell);
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
            var parts = PartIdParser.Service.ParseValid(args);
            if(parts.Length == 0)
                parts = Context.Api.PartIdentities;

            var config = Apps.configure(Context, args);
            using var wf = Flow.shell(config);
            using var state = AsmWfBuilder.state(wf, AsmWfBuilder.asm(Context), config);

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