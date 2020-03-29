//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.AsmApp)]

namespace Z0.Asm.Check
{ 
    using P = Z0.Parts;

    using System.Reflection;
    using System.Linq;

    class App : ConsoleApp<App,IAsmContext>
    {

        static IPart[] Dependencies
            => new IPart[]{
                P.AsmCore.Resolved, 
                P.BitCore.Resolved,
                P.BitGrids.Resolved, 
                P.BitSpan.Resolved, 
                P.BitFields.Resolved,
                P.BitVectors.Resolved, 
                P.Blocks.Resolved, 
                P.Components.Resolved,
                P.Fixed.Resolved, 
                P.GMath.Resolved, 
                P.Intrinsics.Resolved,
                P.LibM.Resolved, 
                P.Logix.Resolved, 
                P.Math.Resolved,
                P.MathServices.Resolved, 
                P.Memories.Resolved, 
                P.Numeric.Resolved,
                P.Permute.Resolved,
                P.Root.Resolved,
                P.VSvc.Resolved, 
                P.VBits.Resolved, 
                P.Vectorized.Resolved, 
                P.VData.Resolved
                };

        static IAppSettings LoadSettings()
        {
            var dir = Env.Current.DevDir + RelativeLocation.Define("asm/app");
            var src = dir + FileName.Define("config.json");
            return AppSettings.Load(src);
        }
        
        static IAsmContext CreateContext()
        {
            var random = Polyrand.Pcg64(Seed64.Seed05);                
            term.print($"Created {random.RngKind} random source");

            var settings = LoadSettings();
            term.print($"loaded settings");

            var resolved = ApiComposition.Assemble(Dependencies.Where(r => r.Id != 0));
            term.print($"Assembled {resolved.Resolved.Length} parts");

            var exchange = AppMsgExchange.Create(AppMsgQueue.Create());
            return AsmContext.Create(resolved, settings, exchange, random, AsmFormatConfig.New);
        }
        
        public App()
            : base(CreateContext())
        {
            term.print("Created application");
        }
            
        void ExecuteValidationWorkflow()
        {
            using var host = ValidationHost.Create(Context);
            host.Run();
        }

        public override void RunShell(params string[] args)
        {
            ExecuteValidationWorkflow();
        }

        public static void Main(params string[] args)
        {
            Launch(args);
        }

    } 
}