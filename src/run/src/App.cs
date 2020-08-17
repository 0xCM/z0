//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static Konst;
    using static z;

    class App : AppShell<App,IAppContext>
    {        
        public const PartId Part = PartId.Run;
        
        public const string PartName = nameof(PartId.Run);

        public const string ActorName = PartName + "/" + nameof(App);

        public CorrelationToken Ct {get;}         
        
        public App()
            : base(Flow.app())
        {
            Ct = CorrelationToken.from(Part);                 
        }

        IResolvedApi Api 
            => ApiComposition.Assemble(KnownParts.Where(r => r.Id != 0));
       
        IRunnerContext CreateArtistryContext(IAsmContext root, PartId[] code)
            => RunnerContext.Create(root, code);


        public override void RunShell(params string[] args)
        {                        
            var parts = PartIdParser.Service.ParseValid(args); 
            if(parts.Length == 0)
                parts = Context.PartIdentities;
            
            var config = Flow.configure(Context, args, Ct);
            using var log = Flow.log(config);
            var wfc = Flow.context(Context, config, log, Ct);
            using var state = WfBuilder.state(wfc, WfBuilder.asm(Context), config);

            try
            {
                Flow.status(wfc, ActorName, new {Message ="Running", Args = text.bracket(args.FormatList())},Ct);            
                using var runner = new Runner(state);
                runner.Run();                
                Flow.status(wfc, ActorName,  "Ran", Ct);
            }
            catch(Exception e)
            {
                Flow.error(wfc, ActorName, e, Ct);                
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