//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class HostCaptureSteps
    {
        public readonly struct ManageCaptureStep : IManageCaptureStep
        {
            public ICaptureWorkflow Workflow {get;}

            public ICaptureContext Context => Workflow.Context;

            [MethodImpl(Inline)]
            internal ManageCaptureStep(ICaptureWorkflow workflow)
            {
                Workflow = workflow;
            }

            public void CaptureCatalogs(AsmArchiveConfig config, params PartId[] parts)
            {
                var root = Archives.Services.CaptureArchive(config.ArchiveRoot);
                CaptureCatalogs(root, parts);
            }

            public void CaptureCatalogs(ICaptureArchive dst, params PartId[] parts)
            {                
                dst.Clear(parts);                
                
                foreach(var catalog in Context.ApiSet.MatchingCatalogs(parts))   
                {
                    if(catalog.ApiHostCount != 0)                    
                        CaptureCatalog(catalog, dst);
                }
            }

            public void CaptureHost(ICaptureHostStep step, IApiHost host, ICaptureArchive dst)
            {                
                step.Execute(host, dst);
            }

            public void CaptureCatalog(IApiCatalog src, ICaptureArchive dst)
            {
                if(src.HasApiHostContent)
                {
                    var start = Context.Raise(StepEvents.Started(src, Context.Correlate()));

                    var step = new CaptureHostStep(Workflow);             
                    foreach(var host in src.ApiHosts)
                        CaptureHost(step, host, dst);

                    Context.Raise(StepEvents.Ended(src, start.Correlation));
                }
            }
       }
    }
}