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
                P.GMath.Resolved, 
                P.BitCore.Resolved,
                P.BitFields.Resolved,
                P.BitGrids.Resolved,
                P.BitPack.Resolved,
                P.BitSpan.Resolved,                
                P.DVec.Resolved,
                P.GVec.Resolved,
                P.FVec.Resolved,
                P.BitVectors.Resolved,
                P.BitSvc.Resolved,
                P.Blocks.Resolved,
                P.Numeric.Resolved,
                P.Api.Resolved,
                P.Capture.Resolved, 
                P.Cast.Resolved,
                P.Checks.Resolved,
                P.Logix.Resolved,
                P.Cil.Resolved,
                // P.Custom.Resolved,
                P.Dynamic.Resolved,
                P.Enums.Resolved,
                P.Fixed.Resolved, 
                // P.Graphs.Resolved,
                // P.Identify.Resolved,
                // P.Kinds.Resolved,                
                P.Math.Resolved,
                P.MathServices.Resolved, 
                // P.Matrix.Resolved,
                // P.Memories.Resolved,                 
                P.Permute.Resolved,
                // P.Polyrand.Resolved,
                P.Seed.Resolved,
                P.SFuncs.Resolved,
                P.Symbolic.Resolved,
                P.Time.Resolved,
                // P.Textual.Resolved,
                P.Tuples.Resolved,
                P.Typed.Resolved,
                P.Validity.Resolved,
                P.VBits.Resolved,
                P.Vectors.Resolved,
                P.VSvc.Resolved
                };

        static IAppSettings LoadSettings()
        {
            var dir = Env.Current.DevDir + RelativeLocation.Define("asm/app");
            var src = dir + FileName.Define("config.json");
            return AppSettings.Load(src);
        }
        
        static IAsmContext CreateContext()
        {
            var context = IContext.Default;
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var settings = LoadSettings();
            var resolved = ApiComposition.Assemble(Dependencies.Where(r => r.Id != 0));
            var format = AsmFormatConfig.New;            
            var decoder = AsmDecoder.function(context, format);
            var formatter = AsmDecoder.formatter(context, format);
            var factory = AsmDecoder.writerFactory(context);
            return AsmContext.Create(resolved, settings, AppMessages.exchange(), random, format, formatter, decoder, factory);
        }
        
        public App()
            : base(CreateContext())
        {
            term.print("Created application");
            Resolved = Context.ApiSet.Composition.Resolved;
        }
            
        public override IPart[] Resolved {get;}
        
        void ValidateArtifacts()
        {
            using var host = ValidationHost.Create(Context);
            host.Execute();
        }

        void AnalyzeExtracts()
        {
            ExtractionWorkflow.Create(Context).Run();
            
        }

        public override void RunShell(params string[] args)
        {
            //AnalyzeExtracts();
            ValidateArtifacts();
        }

        public static void Main(params string[] args)
        {
            Launch(args);
        }
    } 
}