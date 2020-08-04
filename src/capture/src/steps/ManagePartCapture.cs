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
        public static ManagePartCapture create(ICaptureWorkflow wf, PartWfConfig config, WfTermEventSink sink, CorrelationToken? ct = null)
            => new ManagePartCapture(wf, config, sink, ct);

        readonly CorrelationToken Ct;

        readonly CaptureState State;
        
        public ICaptureWorkflow CWf {get;}

        public PartWfConfig Config;

        public WfTermEventSink TermSink {get;}
        
        readonly WfContext Wf;
        
        readonly TPartCaptureArchive TargetArchive;
        
        ICaptureContext Context 
            => CWf.Context;

        [MethodImpl(Inline)]
        internal ManagePartCapture(ICaptureWorkflow cwf, PartWfConfig config, WfTermEventSink sink, CorrelationToken? ct)
        {
            TermSink = sink;
            State = new CaptureState(cwf, config, ct);
            Ct = ct ?? CorrelationToken.create();
            CWf = cwf;
            Wf = config.Context;
            Config = config;
            TargetArchive = Archives.Services.CaptureArchive(Config.Target.ArchiveRoot);    
        }
        
        public void Run()
        {
            Clear(Config);  

            var dst = Archives.Services.CaptureArchive(Config.Target.ArchiveRoot);    
            var catalogs = Catalogs(Context.ApiSet).Array();
            CaptureParts(catalogs, dst);
        }

        IPartCatalog[] Catalogs(IApiSet src)
            => src.Catalogs;


        void CaptureParts(PartWfConfig config)
        {
            Clear(config);  

            var dst = Archives.Services.CaptureArchive(config.Target.ArchiveRoot);    
            var catalogs = Catalogs(Context.ApiSet).Array();
            CaptureParts(catalogs, dst);
        }

        public void Consolidate()
        {
            var catalogs = Catalogs(Context.ApiSet).Array();
            Wf.Raise(new RunningConsolidated(WorkerName, catalogs.Length, Ct));
            
            Clear(Config);

            try
            {
                var a = catalogs.SelectMany(c => c.DataTypeHosts).Cast<IApiHost>();
                var b = catalogs.SelectMany(c => c.OperationHosts).Cast<IApiHost>();
                var hosts = a.Concat(b).OrderBy(x => x.PartId).ThenBy(x => (long)x.HostType.TypeHandle.Value).Array();

                Wf.Status(WorkerName, $"Consolidated {hosts.Length} hosts", Ct);                    
                var dst = Archives.Services.CaptureArchive(Config.Target.ArchiveRoot); 
                using var step = new CaptureHosts(State, hosts, dst, Ct);
                step.Run();

            }
            catch(Exception e)
            {
                Wf.Error(WorkerName, e, Ct);
           }
        }
        
        void CaptureParts(IPartCatalog[] src, TPartCaptureArchive dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                CapturePart(src[i], dst);
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

        void Clear(PartWfConfig config) 
        {
            try
            {
                using var step = new ClearCaptureArchives(config);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(WorkerName, e, Ct);
            }
        }
    }
}