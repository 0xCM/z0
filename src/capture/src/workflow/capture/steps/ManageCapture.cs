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
        
        static TPartCaptureArchive InitTarget(AsmArchiveConfig config, params PartId[] parts) 
        {
            var archive = Archives.Services.CaptureArchive(config.ArchiveRoot);
            archive.Clear(parts);
            return archive;
        }
        
        IPartCatalog[] Catalogs(IApiSet src, params PartId[] parts)
        {
            var dst = z.list<IPartCatalog>();
            if(parts.Length == 0)
            {                
                dst.AddRange(src.Catalogs);
            }
            else
            {
                for(var i=0; i<parts.Length; i++)                
                {
                    var id = parts[i];
                    var catalog = src.Catalogs.Where(c => c.PartId == id && c.ApiHostCount != 0).FirstOrDefault();
                    if(catalog != null)
                        dst.Add(catalog);
                }
            }
            return dst.Array();
        }
        
        public void CaptureParts(AsmArchiveConfig config, params PartId[] parts)
        {
            var dst = InitTarget(config, parts);      
            var catalogs = Catalogs(Context.ApiSet, parts).Array();
            CaptureParts(catalogs, dst);
        }

        public void Consolidated(AsmArchiveConfig config, params PartId[] parts)
        {
            var dst = InitTarget(config, parts);      
            var catalogs = Catalogs(Context.ApiSet, parts).Array();
            var hosts = catalogs.SelectMany(c => c.Hosts).OrderBy(x => x.PartId).ThenBy(x => x.Uri).ToArray();
            var step = CaptureHostStep.create(Workflow); 
            step.CaptureHosts(hosts,dst);
        }

        public void CaptureParts(IPartCatalog[] src, TPartCaptureArchive dst)
        {
            for(var i=0; i<src.Length; i++)
            {
                CapturePart(src[i], dst);
            }
        }
        
        public void CapturePart(IPartCatalog src, TPartCaptureArchive dst)
        {
            if(src.HasApiHostContent)
            {
                Context.Raise(new CapturingPart(src.PartId));
                CaptureHosts(src,dst);
                Context.Raise(new CapturedPart(src.PartId));
            }
        }

        public void CaptureHosts(IPartCatalog src, TPartCaptureArchive dst)
        {
            var step = CaptureHostStep.create(Workflow);             
            z.iter(src.Hosts, h => CaptureHost(step, h, dst));
        }

        public void CaptureHost(CaptureHostStep step, IApiHost host, TPartCaptureArchive dst)
        {                
            Context.Raise(new CapturingHost(host.Uri));
            step.Execute(host, dst);
            Context.Raise(new CapturedHost(host.Uri));
        }
    }
}