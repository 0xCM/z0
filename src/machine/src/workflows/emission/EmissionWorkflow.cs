//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public ref partial struct EmissionWorkflow  
    {
        readonly IAppContext Context;
        
        readonly bool Recapture;
        
        public EmissionWorkflow(IAppContext context, bool recapture = false)
        {
            Context = context;
            Recapture = recapture;
            term.magenta("Beginning emission workflow");
        }
        
        void ExecEmitDocs()
        {
            new EmitProjectDocs(this).Run();
        }

        void EmitBytes()
        {
            term.magenta("Emitting resbytes");
            var step = new EmitResBytes();
            step.Configure(Context).Run();
        }

        void CaptureEmissions()
        {
            term.magenta("Capturing emissions");
            var suite = ContextFactory.CreateClientContext(Context);
            var ac = new AccessorCapture(suite.AsmContext);
            ac.CaptureResBytes();        
        }

        void EmitMetadata()
        {
            term.magenta("Emitting metadata");                 
            new MetadataEmitter(Context).Emit();
            term.magenta("Emitted metadata");                 
        }

        void EmitEnumDatasets()
        {
            term.magenta("Emitting enum datasets");
            EmitEnumData.Service(Context).Emit();
            term.magenta("Emitted enum datasets");
        }
        
        void EmitLiterals()
        {
            term.magenta("Emitting literal fields");
            new EmitFieldLiterals(Context).Run();                        
            term.magenta("Emitted literal fields");
        }

        void EmitBitMasks()
        {
            term.magenta("Emitting bitmask data");
            ReflectedLiterals.emit(typeof(BitMasks), Context.AppPaths);
            term.magenta("Emitted bitmask data");
        }
                        
        public CodeResourceIndex Load()
            => Resources.code(Assembly.LoadFrom(Context.AppPaths.ResBytes.Name));
        
        public void Run(params string[] args)
        {
            EmitBitMasks();
            EmitMetadata();        
            ExecEmitDocs();
            EmitBytes();            
            if(Recapture)
                CaptureEmissions();            
            EmitEnumDatasets();
            EmitLiterals();
        }
 
        public void Dispose()
        {
            term.magenta("Completed emission workflow");
        }
    }
}