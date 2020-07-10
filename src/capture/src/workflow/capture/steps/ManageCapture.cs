//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;

    public class ManageCaptureStep : IManageCaptureStep
    {
        public ICaptureWorkflow Workflow {get;}

        public ICaptureContext Context 
            => Workflow.Context;

        [MethodImpl(Inline)]
        internal ManageCaptureStep(ICaptureWorkflow workflow)
            => Workflow = workflow;
        
        static TCaptureArchive InitTarget(AsmArchiveConfig config, params PartId[] parts) 
        {
            var archive = Archives.Services.CaptureArchive(config.ArchiveRoot);
            archive.Clear(parts);
            return archive;
        }
        
        IEnumerable<IPartCatalog> Catalogs(IApiSet src, params PartId[] parts)
            => parts.Length == 0 ? src.Catalogs 
            : from c in src.Catalogs
              where parts.Contains(c.PartId) && c.ApiHostCount != 0
              select c;
        

        public void CaptureParts(AsmArchiveConfig config, params PartId[] parts)
        {
            var dst = InitTarget(config, parts);      
            z.iter(Catalogs(Context.ApiSet, parts), c => CapturePart(c,dst));
        }

        public void CapturePart(IPartCatalog src, TCaptureArchive dst)
        {
            if(src.HasApiHostContent)
            {
                Context.Raise(new CapturingPart(src.PartId));
                CaptureHosts(src,dst);
                Context.Raise(new CapturedPart(src.PartId));
            }
        }

        public void CaptureHosts(IPartCatalog src, TCaptureArchive dst)
        {
            var step = CaptureHostStep.create(Workflow);             
            z.iter(src.Hosts, h => CaptureHost(step, h, dst));
        }

        public void CaptureHost(CaptureHostStep step, IApiHost host, TCaptureArchive dst)
        {                
            Context.Raise(new CapturingHost(host.Uri));
            step.Execute(host, dst);
            Context.Raise(new CapturedHost(host.Uri));
        }
    }
}