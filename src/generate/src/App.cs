//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    using static Konst;
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
            return AppContext.Create(resolved, random, settings, exchange);
        }
        
        public App()
            : base(CreateAppContext())
        {
        }

        IApiComposition Api 
            => ApiComposition.Assemble(KnownParts.Where(r => r.Id != 0));
    
        
        void RunGenerators()
        {
            var hxm = new HexMachineGen();
            hxm.Generate(0,0xF,AppPaths.GenSrcDir);
            
        }

        public override void RunShell(params string[] args)
        {                        
            var parts = PartIdParser.Service.ParseValid(args);  
            G.Service.Generate();
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}