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

    class App : ApiShell<App,IAsmContext>
    {
        static IPart[] Dependencies
            => new IPart[]{
                P.AsmCore.Resolved, 
                P.Blocks.Resolved,
                P.Cast.Resolved,
                P.Core.Resolved,
                P.Dynamic.Resolved,
                P.Fixed.Resolved, 
                P.GMath.Resolved, 
                P.Math.Resolved,
                P.MathServices.Resolved, 
                P.Memories.Resolved, 
                P.Numeric.Resolved,
                P.Seed.Resolved,
                P.Symbolic.Resolved,
                P.Vectorized.Resolved,
                };

        static IAppSettings LoadSettings()
        {
            var dir = Env.Current.DevDir + RelativeLocation.Define("asm/app");
            var src = dir + FileName.Define("config.json");
            return AppSettings.Load(src);
        }
        
        static IAsmContext CreateContext()
        {
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            term.print($"Created {random.RngKind} random source");

            var settings = LoadSettings();
            term.print($"loaded settings");

            var resolved = ApiComposition.Assemble(Dependencies.Where(r => r.Id != 0));
            term.print($"Assembled {resolved.Resolved.Length} parts");

            return AsmContext.Create(resolved, settings, AppMsgExchange.New(), random, AsmFormatConfig.New);
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