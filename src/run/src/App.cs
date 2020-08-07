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
    using static Flow;
    using static z;

    using P = Z0.Parts;

    class App : AppShell<App,IAppContext>
    {        
        public const PartId Part = PartId.Run;
        
        public const string PartName = nameof(PartId.Run);

        public const string ActorName = PartName + "/" + nameof(App);

        public CorrelationToken Ct {get;}         

        static IAppContext CreateAppContext()
        {
            var resolved = ApiComposition.Assemble(array(P.GMath.Resolved));
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var settings = AppSettings.Load(AppPaths.AppConfigPath);
            var exchange = AppMsgExchange.Create();
            return Apps.context(resolved, random, settings, exchange);
        }
        
        public App()
            : base(CreateAppContext())
        {
            Ct = CorrelationToken.define((byte)Part);   
            Raise(status(ActorName, "Application created", Ct));        
        }

        IResolvedApi Api 
            => ApiComposition.Assemble(KnownParts.Where(r => r.Id != 0));
       
        IRunnerContext CreateArtistryContext(IAsmContext root, PartId[] code)
            => RunnerContext.Create(root, code);

        public override void RunShell(params string[] args)
        {            
            
            Raise(status(ActorName, new {Message ="Running shell", Args = text.bracket(args.FormatList())},Ct));            

            try
            {
                var parts = PartIdParser.Service.ParseValid(args);  
                var context = CreateArtistryContext(WfBuilder.asm(Context), parts);  
                new Runner(context).Run();
            }
            catch(Exception e)
            {
                Raise(error(ActorName, e, Ct));                
            }

            Raise(status(ActorName, "Shell run complete", Ct));
        }

        public static void Main(params string[] args)
            => Launch(args);

        protected override void OnDispose()
        {
            Raise(status(ActorName, "Shell finished", Ct));
        }
    }

    public static partial class XTend
    {

    }
}