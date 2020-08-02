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

    public class ManageCaptureStep : IManageCaptureStep
    {
        public ICaptureWorkflow Workflow {get;}

        public ICaptureContext Context 
            => Workflow.Context;

        [MethodImpl(Inline)]
        internal ManageCaptureStep(ICaptureWorkflow workflow)
            => Workflow = workflow;
        
        void Clear(PartWfConfig config) 
        {
            try
            {
                using var step = new ClearCaptureArchives(config);
                step.Run();
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
        
        IPartCatalog[] Catalogs(IApiSet src, PartWfConfig config)
        {
            var dst = z.list<IPartCatalog>();
            var parts = config.Parts;
            for(var i=0; i<parts.Length; i++)                
            {
                var id = parts[i].Id;
                var catalog = src.Catalogs.Where(c => c.PartId == id && c.IsNonEmpty).FirstOrDefault();
                if(catalog != null)
                    dst.Add(catalog);
            }
            return dst.Array();
        }
        
        public void CaptureParts(PartWfConfig config)
        {
            Clear(config);  

            var dst = Archives.Services.CaptureArchive(config.Target.ArchiveRoot);    
            var catalogs = Catalogs(Context.ApiSet, config).Array();
            CaptureParts(catalogs, dst);
        }

        public void Consolidated(PartWfConfig config)
        {
            var catalogs = Catalogs(Context.ApiSet, config).Array();

            Clear(config);

            try
            {
                term.print($"Executing consolidated workflow over {catalogs.Length} catalogs: {config.Source} -> {config.Target}");      

                var a = catalogs.SelectMany(c => c.DataTypeHosts).Cast<IApiHost>();
                var b = catalogs.SelectMany(c => c.OperationHosts).Cast<IApiHost>();
                var hosts = a.Concat(b).OrderBy(x => x.PartId).ThenBy(x => (long)x.HostType.TypeHandle.Value).Array();
                
                term.print($"Consolidated {hosts.Length} hosts");      
                
                var dst = Archives.Services.CaptureArchive(config.Target.ArchiveRoot); 

                using var step = CaptureHostStep.create(Workflow);
                step.Capture(hosts, dst);

            }
            catch(Exception e)
            {
                term.error(e);
            }
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
            if(src.IsNonEmpty)
            {
                Context.Raise(new CapturingPart(src.PartId));
                CaptureHosts(src,dst);
                Context.Raise(new CapturedPart(src.PartId));
            }
        }

        public void CaptureHosts(IPartCatalog src, TPartCaptureArchive dst)
        {
            var step = CaptureHostStep.create(Workflow);             
            z.iter(src.OperationHosts, h => CaptureHost(step, h, dst));
        }

        public void CaptureHost(CaptureHostStep step, IApiHost host, TPartCaptureArchive dst)
        {                
            Context.Raise(new CapturingHost(host.Uri));
            step.Execute(host, dst);
            Context.Raise(new CapturedHost(host.Uri));
        }
    }
}