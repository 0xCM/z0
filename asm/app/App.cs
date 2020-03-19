//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.AsmApp)]

namespace Z0.Asm.Check
{ 
    using R = Z0.Resolutions;

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
                R.Root.Resolution,R.Vectorized.Resolution};


        static IAppSettings LoadSettings()
        {
            var dir = Env.Current.DevDir + FolderName.Define("asm");
            var path = dir + FileName.Define("config.json");
            return AppSettings.Load(path);
        }

        static IAsmContext CreateContext()
        {

            return AsmContext.New(Resolutions.Assemble(), LoadSettings());
        }

        public App()
            : base(CreateContext(), Log.Get(LogTarget.Define(LogArea.App)))
        {

        }
            
        protected override void Execute(params string[] args)
        {
            var rng = Rng.Pcg64(Seed64.Seed05);                
            var context = AsmWorkflowContext.Rooted(Context, rng);
            using var host = AsmValidationHost.Create(context);
            //host.EmitArtifacts();
            host.Run();
        }

        public static void Main(params string[] args) { Run(args); }

    } 
}

