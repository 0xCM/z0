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
        public readonly struct CaptureCatalogStep : ICaptureCatalogStep
        {
            readonly CaptureWorkflowContext Context;
            
            [MethodImpl(Inline)]
            internal CaptureCatalogStep(CaptureWorkflowContext context)
            {
                this.Context = context;
            }

            public void CaptureCatalogs(AsmWorkflowConfig config)
            {
                var root = Archives.Services.CaptureArchive(config.EmissionRoot);
                CaptureCatalogs(root);
            }

            public void CaptureCatalogs(ICaptureArchive dst)
            {                
                dst.Clear();
                var catalogs = Context.ApiSet.Composition.Catalogs;

                foreach(var catalog in catalogs)   
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

                    var step = new CaptureHostStep(Context);             
                    foreach(var host in src.ApiHosts)
                        CaptureHost(step, host, dst);

                    Context.Raise(StepEvents.Ended(src, start.Correlation));
                }
            }
       }
    }
}
