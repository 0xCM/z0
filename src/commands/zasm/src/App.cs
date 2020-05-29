//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;
    using static Memories;

    using P = Z0.Parts;
    
    class App : AppShell<App,IAppContext>
    {                        
        static IAppContext CreateAppContext()
        {
            var resolved = ApiComposition.Assemble(seq(P.GMath.Resolved));
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var settings = AppSettings.Load(AppPaths.AppConfigPath);
            var exchange = AppMsgExchange.Create();
            return Z0.AppContext.Create(resolved, random, settings, exchange);
        }
        
        public App()
            : base(CreateAppContext())
        {
        }



        public override void RunShell(params string[] args)
        {            
            var parts = PartParser.Service.ParseValid(args);  

            //LoadDataBlocks();
            var etl = AsmEtl.Service;
            etl.Publish();                                    
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}