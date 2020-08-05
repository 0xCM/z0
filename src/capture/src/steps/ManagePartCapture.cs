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
    using static ManagePartCaptureStep;
    using static z;

    public class ManagePartCapture
    {
        public static ManagePartCapture create(WfState state,  CorrelationToken ct)
            => new ManagePartCapture(state, ct);

        readonly WfContext Wf;

        readonly WfState State;

        public WfConfig Config;

        readonly CorrelationToken Ct;

        readonly ICaptureContext Context;        
        
        readonly ICaptureWorkflow CWf;                

        readonly IApiSet Api;
        
        readonly IPartCatalog[] Catalogs;        
        
        readonly uint CatalogCount;

        readonly IApiHost[] Hosts;

        readonly uint HostCount;
        
        [MethodImpl(Inline)]
        internal ManagePartCapture(WfState state, CorrelationToken ct)
        {
            State = state;
            CWf = State.CWf;
            Config = State.Config;
            Ct = ct;
            Context = CWf.Context;
            Api = Context.ApiSet;
            Catalogs = Api.Catalogs;
            CatalogCount = (uint)Catalogs.Length;            
            var a = Catalogs.SelectMany(c => c.DataTypeHosts).Cast<IApiHost>();
            var b = Catalogs.SelectMany(c => c.OperationHosts).Cast<IApiHost>();
            Hosts = a.Concat(b).OrderBy(x => x.PartId).ThenBy(x => (long)x.HostType.TypeHandle.Value).Array();
            HostCount = (uint)Hosts.Length;
        }
        
        public void Run()
        {
            Clear(Config);  
            CaptureParts(Archives.Services.CaptureArchive(Config.Target.ArchiveRoot));
        }

        void CaptureParts(TPartCaptureArchive dst)
        {
            var count = Catalogs.Length;
            for(var i=0; i<count; i++)
            {
                CapturePart(Catalogs[i], dst);
            }
        }

        // void CaptureParts(WfConfig config)
        // {
        //     Clear(config);  

        //     var dst = Archives.Services.CaptureArchive(config.Target.ArchiveRoot);    
        //     CaptureParts(dst);
        // }

        public void Consolidate()
        {
            Wf.Raise(new RunningConsolidated(WorkerName, Catalogs.Length, Ct));
            
            Clear(Config);

            try
            {
                var dst = Archives.Services.CaptureArchive(Config.Target.ArchiveRoot); 
                using var step = new CaptureHosts(State, Hosts, dst, Ct);
                step.Run();

            }
            catch(Exception e)
            {
                Wf.Error(WorkerName, e, Ct);
           }
        }
                
        void CapturePart(IPartCatalog src, TPartCaptureArchive dst)
        {
            if(src.IsNonEmpty)
            {
                Context.Raise(new CapturingPart(src.PartId));
                CaptureHosts(src,dst);
                Context.Raise(new CapturedPart(src.PartId));
            }
        }

        void CaptureHosts(IPartCatalog src, TPartCaptureArchive dst)
        {
            var step = CaptureHostApi.create(State, Ct);   
            var hosts = span(src.OperationHosts);
            var count = hosts.Length;            
            for(var i=0; i<count; i++)          
            {
                ref readonly var host = ref skip(hosts,i);
                CaptureHost(step, host, dst);
            } 
        }

        void CaptureHost(CaptureHostApi step, IApiHost host, TPartCaptureArchive dst)
        {                
            Context.Raise(new CapturingHost(host.Uri));
            step.Execute(host, dst);
            Context.Raise(new CapturedHost(host.Uri));
        }

        void Clear(WfConfig config) 
        {
            try
            {
                using var step = new ClearCaptureArchives(Wf, config, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(WorkerName, e, Ct);
            }
        }
    }
}