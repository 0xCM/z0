//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;
    using Z0.Machine;

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

        bool StartCpu {get;} 
            = false;

        IResolvedApi Api 
            => ApiComposition.Assemble(KnownParts.Where(r => r.Id != 0));

        IAsmContext CreateAsmContext()
            => AsmContext.Create(Context);
        
        IMachineContext CreateMachineContext(IAsmContext root, PartId[] code)
            => MachineContext.Create(root, code);

        static void RunCpu(IMachineContext context)
            => Cpu.alloc(context).Run();

        public override void RunShell(params string[] args)
        {            
            var parts = PartIdParser.Service.ParseValid(args);  
            var context = CreateMachineContext(CreateAsmContext(), parts);  
            
            if(StartCpu)            
                RunCpu(context);
            else
                AppDataEmitter.Service.Generate(Context);
        }

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend
    {

    }
}