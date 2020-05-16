//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm.Data;
    using Z0.Xed;
    using Z0.Asm.Encoding;

    using static Seed;
    using static Memories;

    using P = Z0.Parts;
    
    public static partial class zasm
    {

    }

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

            var codes = new OpCodes();
            codes.ReadLegacy();

            // var selected = Control.array(3u,7u,15u);
            // foreach(var s in selected)
            // {
            //     var g = BinaryKindGenerator.Create(s);
            //     var code = g.Generate();
            //     term.print(code);

            // }

            //Control.iter(HexCodeGenerator.Gen(), term.print);
                                    
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}