//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Konst;
    using static z;
 
    using P = Z0.Parts;
    

    using static Flow;    
    
    class App : AppShell<App,IAppContext>
    {                
        static IAppContext CreateAppContext()
        {
            var resolved = ApiComposition.Assemble(array(P.GMath.Resolved));
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var settings = AppSettings.Load(AppPaths.AppConfigPath);
            var exchange = AppMsgExchange.Create();
            return AppContext.Create(resolved, random, settings, exchange);
        }
        
        public CorrelationToken Ct {get;}
        
        public App()
            : base(CreateAppContext())
        {
            Ct = correlate(1);
        }

        void Parse(FilePath src)
        {
            var data = XedSourceParser.Service.LoadSource(src);
            if(data.IsNonEmpty)
                term.print($"Parsed {data.Rows.Length} rows from {src}");
            else
                term.warn($"No content was parsed from {src}");
        }

        public override void RunShell(params string[] args)
        {            
            var sink = termsink(Ct);
            var s = settings(Context, Ct);
            var config = new XedEtlConfig(Context, s);
            using var context = Flow.context(Context, Flow.configure(Context, args, Ct),  Ct);
            using var wf = new XedEtl(context, config);
            wf.Run();                                        
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}