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
    using static z;

    using P = Z0.Parts;
    
    class App : AppShell<App,IAppContext>
    {                
        static IAppContext CreateAppContext()
        {
            var resolved = ApiComposition.Assemble(array(P.GMath.Resolved));
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var settings = AppSettings.Load(AppPaths.AppConfigPath);
            var exchange = AppMsgExchange.Create();
            return Apps.context(resolved, random, settings, exchange);
        }

        static IAsmContext CreateAsmContext()
        {
            var resolved = ApiComposition.Assemble(array(P.GMath.Resolved));
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var settings = AppSettings.Load(AppPaths.AppConfigPath);
            var exchange = AppMsgExchange.Create();
            var api = ApiComposition.Assemble(KnownParts.Where(r => r.Id != 0));
            var appContext = Apps.context(resolved, random, settings, exchange);
            return AsmContext.create(appContext);            
        }

        public App()
            : base(CreateAppContext())
        {
        }

        void RunApp(params PartId[] src)
        {

            CodeRunner.Service(CreateAsmContext()).Run();
        }

        public override void RunShell(params string[] args)
        {            
            var parts = PartIdParser.Service.ParseValid(args);              
            RunApp(parts);
        }

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend
    {

    }
}