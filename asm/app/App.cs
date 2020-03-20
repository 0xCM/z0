//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.AsmApp)]

namespace Z0.Asm.Check
{ 
    using R = Z0.Resolutions;
    using static Root;

    class App : ConsoleApp<App,IAsmContext>
    {

        static IAssemblyResolution[] Resolutions
            => new IAssemblyResolution[]{
                R.Analogs.Resolution, R.AsmCore.Resolution, R.BitCore.Resolution,
                R.BitGrids.Resolution, R.BitSpan.Resolution, R.BitFields.Resolution,
                R.BitVectors.Resolution, R.VBits.Resolution, R.Permute.Resolution,
                R.Blocks.Resolution, R.Fixed.Resolution, R.Math.Resolution,
                R.GMath.Resolution, R.MathServices.Resolution, R.Intrinsics.Resolution,
                R.IntrinsicsSvc.Resolution, R.LibM.Resolution, R.Logix.Resolution, 
                R.Root.Resolution,R.Vectorized.Resolution, R.VData.Resolution};


        static IAppSettings LoadSettings()
        {
            var dir = Env.Current.DevDir + RelativeLocation.Define("asm/app");
            var path = dir + FileName.Define("config.json");
            return AppSettings.Load(path);
        }

        static IAsmContext CreateContext()
        {
            var settings = LoadSettings();
            iter(settings.All, term.print);
            return AsmContext.New(Resolutions.Assemble(), settings);
        }

        public App()
            : base(CreateContext(), Log.Get(LogTarget.Define(LogArea.App)))
        {

        }
            
        void ExecuteValidationWorkflow()
        {
            var rng = Rng.Pcg64(Seed64.Seed05);                
            var context = AsmWorkflowContext.Rooted(Context, rng);
            using var host = ValidationHost.Create(context);
            host.Run();

        }
        protected override void Execute(params string[] args)
        {

            ExecuteValidationWorkflow();
        }

        public static void Main(params string[] args) { Run(args); }

    } 
}

