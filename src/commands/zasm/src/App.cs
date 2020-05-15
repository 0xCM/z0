//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    
    using static Seed;
    using static Memories;

    using P = Z0.Parts;
    using Asm;
    
    class App : AppShell<App,IAppContext>
    {                
        static IAppContext CreateAppContext()
        {
            var resolved = ApiComposition.Assemble(seq(P.GMath.Resolved));
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var settings = AppSettings.Load(AppPaths.AppConfigPath);
            var exchange = AppMsgExchange.Create();
            return AppContext.Create(resolved, random, settings, exchange);
        }
        
        public App()
            : base(CreateAppContext())
        {
        }


        public override void RunShell(params string[] args)
        {            
            var parts = PartParser.Service.ParseValid(args);  

            Control.iter(HexCodeTemplate.Generate(),term.print);
                                    
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}