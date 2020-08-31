//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Konst;
    using static z;

    class App : AppShell<App,IAppContext>
    {
        public const PartId Part = PartId.Run;

        public const string PartName = nameof(PartId.Run);

        public const string ActorName = PartName + "/" + nameof(App);

        public CorrelationToken Ct {get;}

        public App()
            : base(ContextFactory.app())
        {
            Ct = correlate(Part);
        }

        public override void RunShell(params string[] args)
        {
            var parts = PartIdParser.Service.ParseValid(args);
            if(parts.Length == 0)
                parts = Context.Api.PartIdentities;

            var config = WfBuilder.configure(Context, args);
            using var log = AB.termlog(config);
            var wfc = WfBuilder.context(Context, config, log, Ct);
            using var state = AsmWfBuilder.state(wfc, AsmWfBuilder.asm(Context), config);

            try
            {
                AB.status(wfc, ActorName, new {Message ="Running", Args = text.bracket(args.FormatList())},Ct);
                using var runner = new Runner(state);
                runner.Run();
                AB.status(wfc, ActorName,  "Ran", Ct);
            }
            catch(Exception e)
            {
                wfc.Error(e, Ct);
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