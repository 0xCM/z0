//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.AsmApp)]

namespace Z0.Asm.Check
{ 
    using R = Z0.Parts;

    class App : ConsoleApp<App,IAsmContext>
    {
        static IApiPart[] Resolutions
            => new IApiPart[]{
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

        static IAsmContext CreateContext()
        {
            var settings = LoadSettings();
            var resolved = Resolutions.Assemble();
            var exchange = AppMsgExchange.Create(AppMsgQueue.Create());
            var random = Rng.Pcg64(Seed64.Seed05);                
            return AsmContext.Create(resolved, settings, exchange, random, AsmFormatConfig.New);
        }
        
        public App()
            : base(CreateContext())
        {

        }
            
        void ExecuteValidationWorkflow()
        {
            using var host = ValidationHost.Create(Context);
            host.Run();
        }

        protected override void OnExecute(params string[] args)
        {
            ExecuteValidationWorkflow();
        }

        public static void Main(params string[] args)
        {
            Launch(args);
        }

    } 
}

