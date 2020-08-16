//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;
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
            Ct = CorrelationToken.define(Part);   
            Raise(Flow.status(ActorName, "Application created", Ct));  
        }

        IResolvedApi Api 
            => ApiComposition.Assemble(KnownParts.Where(r => r.Id != 0));
       
        public override void RunShell(params string[] args)
        {                        
         
            var parts = PartIdParser.Service.ParseValid(args); 
            if(parts.Length == 0)
                parts = Context.PartIdentities;
            

            LoadOpCodes();     

        }

        public void LoadTokens()
        {
            var tokens = AsmOpCodes.Tokens;
            tokens.Iter(t => term.print(t.Format()));                                

            
        }

        void Status<T>(T content)
        {
            Raise(Flow.status(ActorName, content, Ct));
        }

        public void LoadOpCodes()
        {
            var data = AsmOpCodes.dataset().Records.TableSpan();
            var count = data.Count;
            var view = data.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(view,i);
                Status(record.Format());
            }
                           
        }

        public static void Main(params string[] args)
            => Launch(args);

        protected override void OnDispose()
        {
            // Wf.Dispose();
            // Raise(status(ActorName, "Shell finished", Ct));
        }
    }

    public static partial class XTend
    {
        

    }
}