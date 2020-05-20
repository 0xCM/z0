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


        void ParseRex()
        {
            var input = (byte)RexPrefixCode.Rex48;
            var r1 = Prefixes.ParseRex(input);
            insist(r1.Succeeded);
            var output = r1.Value.Encoded;
            insist(input,output);
            term.print(r1.Value.Format());

            var mrm = Prefixes.ParseModRM(0b110110);
            term.print(mrm.Format());
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