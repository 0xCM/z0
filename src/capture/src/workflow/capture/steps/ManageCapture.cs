//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public readonly struct ManageCaptureStep : IManageCaptureStep
    {
        public ICaptureWorkflow Workflow {get;}

        public ICaptureContext Context 
            => Workflow.Context;

        [MethodImpl(Inline)]
        internal ManageCaptureStep(ICaptureWorkflow workflow)
            => Workflow = workflow;
        
        static TCaptureArchive TargetArchive(AsmArchiveConfig config, params PartId[] parts) 
        {
            var archive = Archives.Services.CaptureArchive(config.ArchiveRoot);
            archive.Clear(parts);
            return archive;
        }
        
        public void CaptureCatalogs(AsmArchiveConfig config, params PartId[] parts)
        {

            var dst = TargetArchive(config, parts);      
            var api = Context.ApiSet;
            

            var catalogs = Context.ApiSet.MatchingCatalogs(parts).Where(x => x.ApiHostCount != 0).ToArray();


            foreach(var catalog in catalogs)   
                CaptureCatalog(catalog, dst);

        }

        public void CaptureHost(ICaptureHostStep step, IApiHost host, TCaptureArchive dst)
        {                
            Context.Raise(new CapturingHost(host.Uri));
            step.Execute(host, dst);
            Context.Raise(new CapturedHost(host.Uri));
        }

        public void CaptureCatalog(IApiCatalog src, TCaptureArchive dst)
        {
            if(src.HasApiHostContent)
            {
                Context.Raise(new CapturingPart(src.PartId));

                var step = new CaptureHostStep(Workflow);             
                foreach(var host in src.Hosts)
                    CaptureHost(step, host, dst);

                Context.Raise(new CapturedPart(src.PartId));
            }
        }
    }
}