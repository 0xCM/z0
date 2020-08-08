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
    
    [Step(WfStepKind.EmitDatasets)]
    public ref partial struct EmitDatasets  
    {
        readonly IWfContext Wf;

        readonly CorrelationToken Ct;
        
        readonly bool Recapture;

        readonly string[] Args;

        public EmitDatasets(IWfContext context, CorrelationToken ct, params string[] args)
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

        void Run(EmitResBytesStep kind)
        {
            using var step = EmitResBytes.create(Wf, Ct);
            step.Run();
        }
        
        void Run(RecaptureStep kind)
        {
            var resources = Resources.code(Assembly.LoadFrom(Wf.AppPaths.ResBytes.Name));
            var capture = WfBuilder.wfc(Wf, Ct);
            using var step = new Recapture(capture);
            step.CaptureResBytes();        
        }

        void Run(EmitMetadataSetsStep kind)
        {
            using var step = new EmitMetadataSets(Wf, Ct);
            step.Run();
        }

        void Run(EmitEnumCatalogStep kind)
        {
            using var step = new EmitEnumCatalog(Wf, Ct);
            step.Run();
        }
        
        void Run(EmitFieldLiteralsStep kind)
        {
            using var step = new EmitFieldLiterals(Wf, Ct);
            step.Run();
        }

        void Run(EmitContentCatalogStep kind)
        {
            using var step = new EmitContentCatalog(Wf, Ct);
            step.Run();
        }

        void Run(EmitBitMasksStep kind)
        {
            using var step = new EmitBitMasks(Wf, Ct);
            step.Run();
        }
                                
        public void Run()
        {
            Run(default(EmitMetadataSetsStep));        
            Run(default(EmitBitMasksStep));
            Run(default(EmitProjectDocsStep));
            Run(default(EmitResBytesStep));            
            Run(default(EmitEnumCatalogStep));
            Run(default(EmitFieldLiteralsStep));
            Run(default(EmitContentCatalogStep));
        }
 
        public void Dispose()
        {
            Wf.Finished(nameof(EmitDatasets), Ct);
        }
    }
}