//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.AsmApp)]

namespace Z0.Asm.Check
{ 
    using R = Z0.Parts;

    using System.Reflection;
    using System.Linq;

    class App : ConsoleApp<App,IAsmContext>
    {

        static IPart[] Dependencies
            => new IPart[]{
                R.Analogs.Resolution, R.AsmCore.Resolution, R.BitCore.Resolution,
                R.BitGrids.Resolution, R.BitSpan.Resolution, R.BitFields.Resolution,
                R.BitVectors.Resolution, R.VBits.Resolution, R.Permute.Resolution,
                R.Blocks.Resolution, R.Fixed.Resolution, R.Math.Resolution,
                R.GenericNumerics.Resolution, R.MathServices.Resolution, R.Intrinsics.Resolution,
                R.VSvc.Resolution, R.LibM.Resolution, R.Logix.Resolution, 
                R.Root.Resolution,R.Vectorized.Resolution, R.VData.Resolution};

        static IAppSettings LoadSettings()
        {
            var dir = Env.Current.DevDir + RelativeLocation.Define("asm/app");
            var src = dir + FileName.Define("config.json");
            return AppSettings.Load(src);
        }

        //ApiComposition.Assemble(resolutions.Where(r => r.Id != 0).ToArray())
        static IAsmContext CreateContext()
        {
            var random = Rng.Pcg64(Seed64.Seed05);                
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

        protected override void Execute(params string[] args)
        {
            ExecuteValidationWorkflow();
        }

        public static void Main(params string[] args)
        {
            Launch(args);
        }

    } 
}