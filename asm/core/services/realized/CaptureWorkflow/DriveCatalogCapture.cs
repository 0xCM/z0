//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static AsmEvents;

    partial class HostCaptureSteps
    {
        public readonly struct DriveCatalogCapture
        {
            readonly CaptureWorkflowContext Context;

            [MethodImpl(Inline)]
            internal static DriveCatalogCapture Create(CaptureWorkflowContext context)
                => new DriveCatalogCapture(context);
            
            [MethodImpl(Inline)]
            DriveCatalogCapture(CaptureWorkflowContext context)
            {
                this.Context = context;
            }

            public void CaptureCatalogs(AsmWorkflowConfig config)
            {
                var root = RootEmissionPaths.Define(config.EmissionRoot);
                CaptureCatalogs(root);
            }

            void CaptureCatalogs(RootEmissionPaths root)
            {                
                root.Clear();
                var catalogs = Context.ApiSet.Composition.Catalogs;

                foreach(var catalog in catalogs)   
                {
                    if(catalog.ApiHostCount != 0)                    
                        CaptureCatalog(catalog, root);
                }
            }

            void CaptureCatalog(IApiCatalog src, in RootEmissionPaths dst)
            {
                if(src.HasApiHostContent)
                {
                    var start = Context.Raise(StepEvents.Started(src, Context.Correlate()));

                    var step = DriveHostCapture.Create(Context);
                    foreach(var host in src.ApiHosts)
                    {
                        step.Execute(host, dst);
                    }

                    Context.Raise(StepEvents.Ended(src, start.Correlation));
                }
            }
       }
    }
}
