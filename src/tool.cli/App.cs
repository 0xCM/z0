//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static Shell;

    using static z;

    readonly struct Shell
    {
        public const PartId ShellId = PartId.ToolCli;

        public const string ShellName = nameof(PartId.ToolCli) + "/" + nameof(App);
    }

    class App : AppShell<App,IAppContext>
    {

        public CorrelationToken Ct {get;}

        public App()
            : base(Flow.app())
        {
            Ct = correlate(ShellId);
        }

        public override void RunShell(params string[] args)
        {
            try
            {
                var config = WfBuilder.configure(Context,args);
                using var log = AB.log(config);
                using var wf = WfBuilder.context(Context, config, log, Ct);
                Flow.status(wf, ShellName, new {Message ="Running shell", Args = text.bracket(args.FormatList())},Ct);

                Flow.status(wf, ShellName, "Shell run complete", Ct);
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