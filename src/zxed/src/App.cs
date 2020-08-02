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
        
        public App()
            : base(CreateAppContext())
        {
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
            var sink = termsink();
            var config = new XedEtlConfig(Context, wfconfig(Context,sink));
            using var context = new WfContext<XedEtlConfig>(Context, config, sink);
            using var wf = new XedEtl(context);
            wf.Run();                                        
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}