//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    using static Memories;

    partial class HostCaptureSteps
    {
        public readonly struct DriveCatalogCapture
        {
            readonly HostCaptureContext Context;

 
            [MethodImpl(Inline)]
            internal static DriveCatalogCapture Create(HostCaptureContext context)
                => new DriveCatalogCapture(context);
            
            [MethodImpl(Inline)]
            DriveCatalogCapture(HostCaptureContext context)
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
                    var start = Context.Raise(WorkflowSteps.Started(src, Context.Correlate()));

                    var step = DriveHostCapture.Create(Context);
                    foreach(var host in src.ApiHosts)
                    {
                        step.Execute(host, dst);
                    }

                    Context.Raise(WorkflowSteps.Ended(src, start.Correlation));
                }
            }
       }
    }
}
