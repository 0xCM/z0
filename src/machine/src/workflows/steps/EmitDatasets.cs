//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Reflection;
    
    using static Konst;
    using static Flow;
    using static EmitDatasetsStep;

    public readonly struct EmitDatasetsStep
    {
        public const string WorkerName = nameof(EmitDatasets);
    }
    
    public ref partial struct EmitDatasets  
    {
        public readonly WfContext Wf;

        readonly CorrelationToken Ct;
        
        readonly bool Recapture;

        readonly string[] Args;

        public EmitDatasets(WfContext context, CorrelationToken ct, params string[] args)
        {
            Args = args;
            Ct = ct;
            Wf = context;
            Recapture = false;
            Wf.Initialized(WorkerName, Ct);
        }
        
        void Run(EmitProjectDocsStep kind)
        {
            try
            {
                using var step = new EmitProjectDocs(Wf, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }
        }

        void EmitBytes()
        {
            using var step = EmitResBytes.create(Wf, Ct);
            step.Run();
        }

        void CaptureEmissions()
        {
            var capture = ContextFactory.WfCapture(Wf, Ct);
            using var step = new RecaptureAccessors(capture);
            step.CaptureResBytes();        
        }

        void EmitMetadata()
        {
            using var step = new EmitClrMetadataSets(Wf, Ct);
            step.Run();
        }

        void EmitEnumDatasets()
        {
            using var step = new EmitEnumData(Wf, Ct);
            step.Run();
        }
        
        void EmitLiterals()
        {
            using var step = new EmitFieldLiterals(Wf, Ct);
            step.Run();

        }

        void EmitCatalog()
        {
            using var step = new EmitContentCatalog(Wf, Ct);
            step.Run();
        }

        void EmitBitMasks()
        {
            using var step = new EmitBitMasks(Wf, Ct);
            step.Run();
        }
                        
        public CodeResourceIndex Load()
            => Resources.code(Assembly.LoadFrom(Wf.AppPaths.ResBytes.Name));
        
        public void Run(params string[] args)
        {
            EmitBitMasks();
            EmitMetadata();        
            Run(default(EmitProjectDocsStep));
            EmitBytes();            
            CaptureEmissions();            
            EmitEnumDatasets();
            EmitLiterals();
            EmitCatalog();
        }
 
        public void Dispose()
        {
            Wf.Finished(nameof(EmitDatasets), Ct);
        }
    }
}