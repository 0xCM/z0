//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static Memories;

    using P = Z0.Parts;

    readonly struct SelectedParts : IIndex<IPart>
    {
        public static SelectedParts Selected => default(SelectedParts);
        


        IPart[] IContented<IPart[]>.Content
            => new IPart[]{
                P.GMath.Resolved,  
               };
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
        
        void RunGenerators()
        {
            var hxm = new HexMachineGen();
            hxm.Generate(0,0xF,AppPaths.AppDevRoot + FolderName.Empty);
                        
        }

        public override void RunShell(params string[] args)
        {                        
            var parts = PartIdParser.Service.ParseValid(args);  
            var emitter = AppDataEmitter.Service;                        
            emitter.Emit(Context);
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}