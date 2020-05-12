//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

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
            return AppContext.Create(resolved, random, settings, exchange);
        }
        
        public App()
            : base(CreateAppContext())
        {
        }

        IApiComposition Api 
            => ApiComposition.Assemble(KnownParts.Where(r => r.Id != 0));

        IAsmContext CreateAsmContext()
            => AsmContext.Create(Context.Settings, Context.Messaging, Api, AppPaths.AppCapturePath);
        
        IMachineContext CreateMachineContext(IAsmContext root, PartId[] code)
            => MachineContext.Create(root, code);

        public override void RunShell(params string[] args)
        {            
            var parts = PartParser.Service.ParseValid(args);  
            var context = CreateMachineContext(CreateAsmContext(), parts);  
            Machine.Run(context);   
        }

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend
    {

    }

}